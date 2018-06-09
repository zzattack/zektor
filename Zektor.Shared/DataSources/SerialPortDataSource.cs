#define SP_MS
// #define SP_COMMS

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Zektor.Shared.Utility;

namespace Zektor.Shared.DataSources {
    public class SerialPortDataSource : WritableDataSource {
#if SP_MS
        internal SerialPort Port = new SerialPort();
#else
		internal SerialConnection Port = new SerialConnection();
#endif

        public SerialPortInfo PortInfo { get; set; }

        public static Stopwatch sw = Stopwatch.StartNew();
        private SerialPortWatcher _watcher;
        public int BaudRate { get; set; }

        public override DataSourceType Type => DataSourceType.SerialPort;

        public override bool ValidConfig {
            get {
                return PortInfo != null && !string.IsNullOrEmpty(PortInfo.Name) &&
                       SerialPortInfo.GetPorts(true).Any(p => p.Equals(PortInfo));
            }
        }

        public override string DetailedConfig => "SerialPort " + (PortInfo != null ? PortInfo.Name : "N/A") + "@" + BaudRate + "bps";

        public SerialPortDataSource() {
            PortInfo = new SerialPortInfo();
            BaudRate = 115200;
        }

        public SerialPortDataSource(SerialPortInfo spInfo, int baudrate = 115200) {
            PortInfo = spInfo;
            BaudRate = baudrate;
        }

        public SerialPortDataSource(string portname, int baudrate) {
            var ports = SerialPortInfo.GetPorts();
            PortInfo = ports.FirstOrDefault(p => p.Name == portname) ?? new SerialPortInfo {
                Name = portname,
                Description = "Disconnected device"
            };
            BaudRate = baudrate;
        }

        public override bool Start(bool failSilently) {
            if (PortInfo == null || string.IsNullOrEmpty(PortInfo.Name) || !PortInfo.IsConnected) {
                OnConnectFailed(failSilently, new ArgumentException("Cannot connect because no valid serial port was selected."));
                return false;
            }
            /*else if (_scanChannels == null || _scanChannels.Count == 0) {
                MessageBox.Show("No channels selected, will only listen on current channel", "Channel switch inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }*/

#if SP_MS
            if (Port == null || Port.PortName != PortInfo.Name || Port.BaudRate != BaudRate) RenewSerialPort();
#else
			if (Port == null || Port.Options.PortName != PortInfo.Name || Port.Options.BaudRate != BaudRate) {
				if (Port != null) Cleanup();
				RenewSerialPort();
			}
#endif
            OnConnectPending();
            ExpectDisconnect = false;
            if (!Port.IsOpen)
                try {
                    Port.Open();
                    TimeBeginPeriod(1);
                    if (Port.IsOpen) {
                        OnConnected();
                        return true;
                    }

                    OnConnectFailed(failSilently, new InvalidProgramException("Port did not open successfully"));
                    return false;
                }
                catch (UnauthorizedAccessException ua) {
                    OnConnectFailed(failSilently, new InvalidOperationException(
                        "Port unavailable, is it already opened elsewhere?", ua));
                    return false;
                }
                catch (IOException io) {
                    OnConnectFailed(failSilently, new InvalidOperationException(
                        "Port cannot be opened. Is the device present and functioning?", io));
                    return false;
                }
                catch (NullReferenceException) { return false; }

            return true;
        }

        public override void Cleanup() {
            try {
                if (Port != null) {
#if SP_MS
                    Port.DataReceived -= OnDataReceived;
#elif SP_COMMS
					Port.DataAvailable -= OnDataReceived;
#endif
                    if (Port.IsOpen)
                        Port.Close();
                    Port.Dispose();
                    Port = null;
                }
            }
            catch (IOException) { }
            catch (AccessViolationException) { }
            catch (UnauthorizedAccessException ua) { }

            TimeEndPeriod(1);

            if (_watcher != null) {
                _watcher.Dispose();
                _watcher = null;
            }

            base.Cleanup();
        }

        public override void Dispose() {
            base.Dispose();
            if (Port != null) {
                Port.Dispose();
                Port = null;
            }
        }

        private void RenewSerialPort() {
            //if (State == ConnectionState.Connected)
            //	throw new InvalidOperationException("Port shouldnt' be renewed while enabled!");
            if (Port != null)
                Cleanup();

#if SP_MS
            Port = new SerialPort();
            Port.PortName = PortInfo.Name;
            Port.BaudRate = BaudRate;
            Port.StopBits = StopBits.One;
            Port.Parity = Parity.None;
            Port.RtsEnable = false;
#else
			Port = new SerialConnection();
			var options =
 new SerialOptions(PortInfo.Name, BaudRate, CommStudio.Connections.Parity.None, 8, CommStopBits.One, false, false, false, false, false, false);
			Port.SetOptions(options);
			Port.WaitMethod = WaitMethod.Sleep;
#endif
            Port.Encoding = Encoding.Default;

#if SP_MS
            Port.DataReceived += OnDataReceived;
#else
			Port.DataAvailable += this.OnDataReceived;
#endif

            if (_watcher != null)
                _watcher.Dispose();
            _watcher = new SerialPortWatcher(PortInfo.Name);
            _watcher.DeviceRemoved += (sender, args) => OnDisconnect(false);

            Port.Encoding = Encoding.Default;
        }

        private void OnDataReceived(object sender, EventArgs args) {
            try {
                var readBuffer = new List<byte>();
                // read all available Data
#if SP_MS
                // read all available Data
                while (Port.BytesToRead > 0) {
                    int c = Math.Min(1024, Port.BytesToRead);
#else
				while (Port.Available > 0) {
					int c = Math.Min(1024, Port.Available);
#endif
                    var buff = new byte[c];
                    int count = Port.Read(buff, 0, c);
                    Array.Resize(ref buff, count);
                    readBuffer.AddRange(buff);
                }

                // asynchronously notify the interested parties
                var burst = readBuffer.ToArray();
                base.OnDataReceived(burst);
            }
            catch (IOException) { }
            catch (InvalidOperationException) { }
        }

        public override bool Write(byte[] data, int index, int count) {
            /*int written = */
            try {
                if (Port == null || !Port.IsOpen) {
                    return false;
                }

                Port.Write(data, index, count);
                return base.Write(data, index, count);
            }
            catch (IOException) { OnDisconnect(false); }
            catch (ArgumentException) { OnDisconnect(false); }
            catch (TimeoutException) { OnDisconnect(false); }
            catch (UnauthorizedAccessException) { OnDisconnect(false); }
            catch (InvalidOperationException) { OnDisconnect(false); }

            return false;
        }

        public override string ToString() {
            return string.Format("{0} ({1})",
                string.IsNullOrEmpty(Name) ? "Unknown device" : Name,
                PortInfo != null && PortInfo.IsConnected ? PortInfo.Name : "Disconnected device");
        }

        #region P/Invoke imports

        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod", SetLastError = true)]
        private static extern uint TimeBeginPeriod(uint uMilliseconds);

        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod", SetLastError = true)]
        private static extern uint TimeEndPeriod(uint uMilliseconds);

        #endregion

        #region xml serializing/deserializing

        public override void LoadFrom(XmlNode x) {
            base.LoadFrom(x);
            var ports = SerialPortInfo.GetPorts();
            string portname = x["PortName"].InnerText;
            PortInfo = ports.FirstOrDefault(p => p.Name == portname) ?? new SerialPortInfo {
                Name = portname,
                Description = "Disconnected device"
            };
            BaudRate = int.Parse(x["Baudrate"].InnerText);
        }

        public override void SaveTo(XmlTextWriter xtr) {
            base.SaveTo(xtr);
            xtr.WriteElementString("PortName", PortInfo?.Name ?? "");
            xtr.WriteElementString("Baudrate", BaudRate.ToString(CultureInfo.InvariantCulture));
        }

        #endregion
    }
}