using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using NLog;
using Timer = System.Threading.Timer;

namespace Zektor.Shared.DataSources {
    public abstract class DataSource : IDisposable, INotifyPropertyChanged {
        protected static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly AutoResetEvent _areStartStop = new AutoResetEvent(false);
        private bool _abortReconnect; // set to true to "unschedule" reconnect

        private Timer _reconnectTimer;

        private ConnectionState _state = ConnectionState.Disconnected;

        protected bool ExpectDisconnect;

        protected AutoResetEvent LineReadyEvent = new AutoResetEvent(false);

        // list of (sink only) datasources that receive all data read on this datasource
        public BindingList<WritableDataSource> Republishers = new BindingList<WritableDataSource>();

        public string Name { get; set; }

        public int LastDataArrived { get; set; }

        // whether an automatic universal log file is written for this source
        // unique type 
        public abstract DataSourceType Type { get; }

        // determines whether selected settings could be valid
        public abstract bool ValidConfig { get; }

        public long TotalReceived { get; protected set; }
        public bool AlwaysFireConnectionFailed { get; set; } = false;
        public bool AlwaysFireConnectionPending { get; set; } = false;

        public virtual ConnectionState State => _state;

        public abstract string DetailedConfig { get; }

        public ReconnectBehavior ReconnectBehavior { get; set; } = ReconnectBehavior.ReconnectAlways;

        public virtual string DisplayName => ToString();

        public virtual void Dispose() {
            Stop();
            if (_reconnectTimer != null) {
                _reconnectTimer.Change(-1, -1);
                _reconnectTimer.Dispose();
                _reconnectTimer = null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler ConnectionEstablished;
        public event EventHandler ConnectionPending;
        public event EventHandler<ConnectingFailedArgs> ConnectingFailed;
        public event EventHandler<ConnectionLostArgs> ConnectionLost;
        public event EventHandler<DataReceivedEventArgs> DataReceived;

        protected virtual void OnDataReceived(IEnumerable<byte> data) {
            // Util.DebugLog("<< DS: " + Util.ByteArrayToHexString(data));
            LastDataArrived = Environment.TickCount;
            TotalReceived += data.Count();
            FireDataReceived(this, new DataReceivedEventArgs(data));

            // republish
            foreach (var w in Republishers)
                Task.Factory.StartNew(() => w.Write(data.ToArray()));
        }

        protected virtual void FireDataReceived(object sender, DataReceivedEventArgs args) {
            DataReceived?.Invoke(sender, args);
        }


        /// <summary>
        ///     Enabled a datasource. This function always calls either OnConnect() or OnConnectFailed().
        ///     Upon success, should call OnConnect(). In case of failure should call OnConnectFailed().
        /// </summary>
        /// <param name="failSilently">Whether a message may be shown in case the datasource cannot be enabled.</param>
        /// <returns></returns>
        public abstract bool Start(bool failSilently = false);

        public virtual void Stop() {
            TotalReceived = 0;
            ExpectDisconnect = true;
            Cleanup();
            OnDisconnect(true);
        }

        public virtual void Cleanup() {
            _areStartStop.Set();
        }

        protected virtual void OnConnected() {
            if (_state != ConnectionState.Connected) {
                _state = ConnectionState.Connected;
                OnPropertyChanged("State");
            }

            _areStartStop.Set();

            if (ConnectionEstablished != null)
                ConnectionEstablished(this, EventArgs.Empty);
        }

        /// <summary>
        ///     Signals connecting on Start() failed.
        /// </summary>
        /// <param name="failSilently">
        ///     Whether the connection attempt was automatically triggered or user-triggered.
        ///     If not user-triggered, reconnection behaviour should not be broken.
        /// </param>
        protected virtual void OnConnectFailed(bool failSilently, Exception exc = null) {
            var sb = new StringBuilder();
            sb.Append("Connection failed");
            if (exc != null) {
                sb.Append(": ");
                sb.Append(exc.Message);
                if (exc.InnerException != null)
                    sb.AppendFormat(" [{0}]", exc.InnerException);
            }

            if (ReconnectBehavior == ReconnectBehavior.ReconnectAlways) {
                _state = ConnectionState.Connecting;
                ApplyReconnectBehavior();
            }
            else {
                _state = ConnectionState.Disconnected;
            }

            _areStartStop.Set();

            ConnectingFailed?.Invoke(this, new ConnectingFailedArgs(sb.ToString(), exc, failSilently));
            _logger.Error(exc, sb.ToString());
        }

        protected virtual void OnConnectPending() {
            if (_state < ConnectionState.Connecting || AlwaysFireConnectionPending) {
                _state = ConnectionState.Connecting;
                OnPropertyChanged("State");
                ConnectionPending?.Invoke(this, EventArgs.Empty);
            }

            _areStartStop.Set();
        }

        protected virtual void OnDisconnect(bool expected, bool forceEventFire = false) {
            bool wasConnected = State == ConnectionState.Connected;
            _state = ConnectionState.Disconnected;
            // else: ApplyReconnectBehavior will set it to Connecting

            // if state wasn't already "Disconnected", fire event
            if (wasConnected || forceEventFire || AlwaysFireConnectionFailed)
                ConnectionLost?.Invoke(this, new ConnectionLostArgs(
                    expected ? ReconnectBehavior.Ignore : ReconnectBehavior, null));

            if (!expected) {
                Cleanup(); // enforce a proper disconnect
                ApplyReconnectBehavior();
            }
            else {
                // make sure pending reconnects are skipped
                _abortReconnect = true;
            }
        }

        protected void ApplyReconnectBehavior() {
            if (ReconnectBehavior == ReconnectBehavior.Ignore)
                _logger.Error("Applying reconnect behavior {0}: ignoring", Name);
            else if (ReconnectBehavior == ReconnectBehavior.ReconnectAlways ||
                     ReconnectBehavior == ReconnectBehavior.Reestablish)
                ScheduleReconnect();
        }

        private void ScheduleReconnect() {
            // prevent multiple timers from being scheduled simultaneously
            if (_reconnectTimer != null) {
                _logger.Debug("Skipping reconnect attempt scheduling (already planned)");
            }
            // prevent "reconnecting" if somehow already connected
            else if (State == ConnectionState.Connected) {
                _logger.Debug("Skipping reconnect attempt scheduling (already reconnected)");
            }
            else {
                _logger.Debug("Scheduling reconnect in 2s on {0}", Name);
                _abortReconnect = false;
                _reconnectTimer = new Timer(delegate {
                    _reconnectTimer = null;
                    if (_abortReconnect) {
                        _logger.Debug("Aborting scheduled reconnect attempt", Name);
                        return;
                    }

                    // if the state is not connected, we don't intend to be connected
                    // if the state is connected, some previous attempt already succeeded by now
                    if (!Start(true)) {
                        _logger.Debug("Scheduled reconnect failed on {0}", Name);
                        ScheduleReconnect();
                    }
                }, null, TimeSpan.FromSeconds(2), new TimeSpan(-1));
            }
        }

        public virtual void LoadFrom(XmlNode x) {
            Name = x.Attributes["Name"].InnerText;
        }

        public virtual void SaveTo(XmlTextWriter xtr) {
            xtr.WriteAttributeString("Name", Name);
            xtr.WriteAttributeString("Type", Type.ToString());
        }

        public void WriteTo(XmlTextWriter xtr) {
            xtr.WriteStartElement("DataSource");
            SaveTo(xtr);
            xtr.WriteEndElement();
        }

        public override string ToString() {
            return Name;
        }

        public virtual void OnPropertyChanged(string propertyName) {
            var handler = PropertyChanged;
            if (handler == null || Application.OpenForms.Count == 0)
                return;
            var mainForm = Application.OpenForms[0];
            if (mainForm == null)
                return; // No main form - no calls

            if (mainForm.InvokeRequired)
                mainForm.BeginInvoke(handler, this, new PropertyChangedEventArgs(propertyName));
            else
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DataReceivedEventArgs : EventArgs {
        public readonly byte[] Data;

        public DataReceivedEventArgs(IEnumerable<byte> data) {
            Data = data.ToArray();
        }
    }

    public class ConnectingFailedArgs : EventArgs {
        public ConnectingFailedArgs(string msg, Exception exc, bool silent) {
            Message = msg;
            ExceptionObject = exc;
            Silent = silent;
        }

        public string Message { get; }
        public Exception ExceptionObject { get; }
        public bool Silent { get; }
    }

    public class ConnectionLostArgs : EventArgs {
        public ConnectionLostArgs(ReconnectBehavior option, Exception exc) {
            ReconnectOption = option;
            ExceptionObject = exc;
        }

        public ReconnectBehavior ReconnectOption { get; }
        public Exception ExceptionObject { get; }
    }

    public enum DataSourceType {
        NullSource,
        SerialPort,
        TcpClient
    }

    public enum ReconnectBehavior {
        ReconnectAlways, // always attempt to reconnect
        Reestablish, // reconnect only if initial connnect is successful
        Ignore // ignore
    }
}