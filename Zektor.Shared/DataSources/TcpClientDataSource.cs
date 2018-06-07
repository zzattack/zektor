using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Xml;
using NLog;

namespace Zektor.Shared.DataSources {
    public class TcpClientDataSource : WritableDataSource {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly byte[] _readBuf = new byte[1024];
        private readonly object _syncLock = new object();

        private string _hostname;

        private int _port;

        private TcpClient _tcp;

        public TcpClientDataSource() : this("127.0.0.1") { }

        public TcpClientDataSource(string hostname, int port = 6498) {
            Hostname = hostname;
            Port = port;
        }

        public string Hostname {
            get => _hostname;
            set {
                if (_hostname != value && State != ConnectionState.Disconnected)
                    MessageBox.Show("Cannot change property while datasource is enabled");
                else if (!string.IsNullOrEmpty(value) && Uri.CheckHostName(value) == UriHostNameType.Unknown)
                    MessageBox.Show("Invalid hostname given, please correct");
                else
                    _hostname = value;
            }
        }

        public int Port {
            get => _port;
            set {
                if (_port != value && State != ConnectionState.Disconnected)
                    MessageBox.Show("Cannot change property while datasource is enabled");
                else if (20 <= value && value <= 65535)
                    _port = value;
                else
                    MessageBox.Show("Invalid port entered, must be between 24-65535, please correct");
            }
        }

        public override DataSourceType Type => DataSourceType.TcpClient;

        public override bool ValidConfig => 24 <= Port && Port < 65535 && Uri.CheckHostName(Hostname) != UriHostNameType.Unknown;

        public override string DetailedConfig => "TCP client @ " + (Hostname ?? "<no host>") + ":" + Port;

        /// <summary>
        ///     Remote IP, available once connected
        /// </summary>
        public IPAddress RemoteIp { get; private set; }


        public override bool Start(bool failSilently = false) {
            try {
                if (_tcp != null && _tcp.Connected) {
                    var ipEndpoint = _tcp.Client.RemoteEndPoint as IPEndPoint;
                    // already connected?
                    if (ipEndpoint != null && (ipEndpoint.Address.ToString().Equals(Hostname) || ipEndpoint.Address.Equals(Dns.Resolve(Hostname))))
                        return true;
                }

                Cleanup();
                ExpectDisconnect = false;
                var tcp = _tcp = new TcpClient(AddressFamily.InterNetwork);

                if (failSilently) {
                    // async connect
                    _tcp.BeginConnect(Hostname, Port, OnConnect, tcp);
                    OnConnectPending();
                    return true;
                }

                // connect synchronously with 2 second timeout
                var ar = _tcp.BeginConnect(Hostname, Port, null, tcp);
                OnConnectPending();

                var wh = ar.AsyncWaitHandle;
                try {
                    bool waitFinished = ar.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(2), false);
                    if (!waitFinished) {
                        OnConnectFailed(false, new TimeoutException());
                        return false;
                    }
                    else if (_tcp == null || !_tcp.Connected) {
                        OnConnectFailed(false, new SocketException(10060)); // 10060 is a guess
                        return false;
                    }
                    else {
                        OnConnect(ar);
                        return true;
                    }
                }
                finally {
                    wh.Close();
                }
            }
            catch (Exception e) {
                OnConnectFailed(failSilently, e);
                return false;
            }
        }

        public override void Cleanup() {
            _logger.Info("Cleaning up TCP DataProvider");
            RemoteIp = null;
            lock (_syncLock) {
                if (_tcp != null) {
                    _tcp.Close();
                    _tcp = null;
                }
            }

            base.Cleanup();
        }

        public void OnConnect(IAsyncResult iar) {
            try {
                var tcp = iar.AsyncState as TcpClient;
                if (tcp != null && tcp.Client != null) {
                    if (!tcp.Connected) {
                        OnConnectFailed(ExpectDisconnect);
                        return;
                    }

                    tcp.EndConnect(iar);
                    lock (_syncLock) {
                        _tcp = tcp;
                        var stream = tcp.GetStream();
                        stream.BeginRead(_readBuf, 0, _readBuf.Length, TcpOnDataReceived, tcp);
                    }

                    if (tcp.Client.RemoteEndPoint is IPEndPoint)
                        RemoteIp = (tcp.Client.RemoteEndPoint as IPEndPoint).Address;
                    _logger.Info("Connected TCP socket");
                    OnConnected();
                }
            }
            catch (Exception exc) {
                _logger.Error(exc, "Couldn't connect TCP socket");
                OnConnectFailed(true, exc);
            }
        }

        private void TcpOnDataReceived(IAsyncResult r) {
            try {
                var tcp = r.AsyncState as TcpClient;
                if (tcp == null || !tcp.Connected) {
                    OnDisconnect(ExpectDisconnect);
                    return;
                }

                var stream = tcp.GetStream();
                int bytesRead = stream.EndRead(r);
                if (bytesRead == 0) {
                    OnDisconnect(ExpectDisconnect);
                    return;
                }

                var chunk = new byte[bytesRead];
                Array.Copy(_readBuf, chunk, bytesRead);
                try {
                    OnDataReceived(chunk);
                }
                catch (Exception exc) {
                    // this shouldnt lead to disconnect, so catch and log
                    _logger.Error(exc, "Exception down the line in DataSource.OnDataReceived");
                }

                stream.BeginRead(_readBuf, 0, _readBuf.Length, TcpOnDataReceived, tcp);
            }
            catch (IOException) {
                _logger.Error("IOException in TcpOnDataReceived");
                OnDisconnect(ExpectDisconnect);
            }
            catch (InvalidOperationException) {
                _logger.Error("InvalidOperationException in TcpOnDataReceived");
                OnDisconnect(ExpectDisconnect);
            }
            catch (NullReferenceException) {
                _logger.Error("NullReferenceException in TcpOnDataReceived");
            }
            catch (SocketException) {
                _logger.Error("SocketException in TcpOnDataReceived");
            }
        }

        public override bool Write(byte[] buffer, int offset, int count) {
            try {
                if (_tcp == null || !_tcp.Connected) return false;
                var stream = _tcp.GetStream();
                if (!stream.CanWrite)
                    return false;
                stream.Write(buffer, 0, buffer.Length);
                return base.Write(buffer, offset, count);
            }
            catch (IOException) { OnDisconnect(false); }
            catch (InvalidOperationException) { OnDisconnect(false); }
            catch (SocketException) { OnDisconnect(false); }

            return false;
        }

        public override string ToString() {
            return string.IsNullOrEmpty(Name) ? string.Format("TCP {0}:{1}", Hostname ?? "", Port) : Name;
        }

        #region xml serializing/deserializing

        public override void LoadFrom(XmlNode x) {
            base.LoadFrom(x);
            Hostname = x["Hostname"].InnerText;
            Port = int.Parse(x["Port"].InnerText);
        }

        public override void SaveTo(XmlTextWriter xtr) {
            base.SaveTo(xtr);
            xtr.WriteElementString("Hostname", Hostname);
            xtr.WriteElementString("Port", Port.ToString(CultureInfo.InvariantCulture));
        }

        #endregion
    }
}