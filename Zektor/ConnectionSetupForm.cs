using System.Linq;
using System.Windows.Forms;
using Zektor.Shared.DataSources;
using Zektor.Shared.USB;
using Zektor.Shared.Utility;

namespace Zektor {
    public partial class ConnectionSetupForm : Form {
        private bool _updatingUI;
        public DataSource DataSource { get; set; }
        private ConnectionSetupForm() {
            InitializeComponent();

            cbBaudrate.DataSource = new[] { 19200, 9600 };
            UsbNotification.DeviceArrival += (s, args) => UpdateDeviceSources(args.DeviceType == DeviceType.DBT_DEVTYP_PORT ? args.Name : null);
            UsbNotification.DeviceRemovalComplete += (s, args) => UpdateDeviceSources();
            UpdateDeviceSources();
        }

        public ConnectionSetupForm(DataSource ds) : this() {
            SelectDataSource(ds);
        }

        private void SelectDataSource(DataSource ds) {
            _updatingUI = true;
            DataSource = ds;
            rbSerialPort.Checked = pnlSerial.Visible = ds is SerialPortDataSource;
            rbTcpIp.Checked = pnlTcp.Visible = ds is TcpClientDataSource;

            if (ds is TcpClientDataSource tcp) {
                tbHostname.Text = tcp.Hostname;
                nudTcpPort.Value = tcp.Port;
            }
            else if (ds is SerialPortDataSource sp) {
                cbSerialPort.SelectedItem = sp.PortInfo;
                cbBaudrate.SelectedItem = sp.BaudRate;
            }
            _updatingUI = false;
        }

        private void UpdateDeviceSources(string selectPort = null) {
            var selected = cbSerialPort.SelectedItem;
            cbSerialPort.Items.Clear();
            var ports = SerialPortInfo.GetPorts().ToArray();
            cbSerialPort.Items.AddRange(ports);
            // keep currently selected if still exists
            if (ports.Contains(selected)) cbSerialPort.SelectedItem = selected;
            // else select newly arrived port
            else cbSerialPort.SelectedItem = ports.FirstOrDefault(p => p.Name.Equals(selectPort));
        }

        private void RbSerialPortCheckedChanged(object sender, System.EventArgs e) {
            if (_updatingUI) return;
            if (rbSerialPort.Checked && !(DataSource is SerialPortDataSource))
                SelectDataSource(new SerialPortDataSource());
            else if (rbTcpIp.Checked && !(DataSource is TcpClientDataSource))
                SelectDataSource(new TcpClientDataSource("", 50005));
        }

        private void btnAccept_Click(object sender, System.EventArgs e) {
            UpdateSettings();
        }

        public void UpdateSettings() {
            if (DataSource is TcpClientDataSource tcp) {
                // stop source if something important changed
                if (tcp.State != ConnectionState.Disconnected && (tcp.Port != nudTcpPort.Value || tcp.Hostname != tbHostname.Text))
                    tcp.Stop();

                tcp.Hostname = tbHostname.Text;
                tcp.Port = (int)nudTcpPort.Value;
            }
            else if (DataSource is SerialPortDataSource) {
                var serialSrc = DataSource as SerialPortDataSource;
                var spiq = cbSerialPort.SelectedItem as SerialPortInfo;
                int baud = int.Parse(cbBaudrate.Text);

                // stop if something significant changed
                if (serialSrc.State != ConnectionState.Disconnected && (!serialSrc.PortInfo.Equals(spiq) || serialSrc.BaudRate != baud))
                    serialSrc.Stop();

                serialSrc.PortInfo = spiq;
                serialSrc.BaudRate = int.Parse(cbBaudrate.Text);
            }
        }
    }
}
