using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zektor.Protocol;
using Zektor.Protocol.Advanced;
using Zektor.Protocol.Basic;
using Zektor.Protocol.Audio;
using Zektor.Shared.DataSources;
using Zektor.Shared.Utility;
using PowerState = Zektor.Protocol.PowerState;

namespace Zektor {
    public partial class MainForm : Form {
        private DataSource _ds = new TcpClientDataSource("10.31.45.57", 50005);
        private readonly ZektorProtocol _proto = new ZektorProtocol();
        private readonly GenericColorLogger<ZektorCommand> _logger = new ZektorLogger();
        private readonly DeviceState _deviceState = new DeviceState();

        public MainForm() {
            InitializeComponent();

            _logger.Window = this.fctbLog;
            _logger.Attach(_proto);
            _logger.ShowBogus = true;
            _logger.ForceHEX = false;
            _logger.ForceASCII = true;

            // hook events
            SetupDataSource();
            _proto.LineReceived += (sender, args) => _deviceState.Update(args.Line);
            _proto.DeviceState = _deviceState;
            _deviceState.PropertyChanged += OnDeviceStateChanged;
            _deviceState.KeyStateChanged += OnDeviceKeyStateChanged;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // hook pbXS panel clicks
            var pbXSs = pbXS_ACK.Parent.Controls.OfType<Panel>().Where(p => p.Name.StartsWith("pbXS_"));
            foreach (var panel in pbXSs) {
                panel.Tag = (ExtendedSettings)Enum.Parse(typeof(ExtendedSettings), panel.Name.Substring(5));
                panel.Click += pbXS_Click;
            }
            // mirrored KYE and KYD panels
            pbMirrored_KYD.Tag = ExtendedSettings.KYD;
            pbMirrored_KYE.Tag = ExtendedSettings.KYE;
            pbMirrored_KYD.Click += pbXS_Click;
            pbMirrored_KYE.Click += pbXS_Click;

            // hook pbXE panel clicks
            var pbXEs = pbXE_CTL.Parent.Controls.OfType<Panel>().Where(p => p.Name.StartsWith("pbXE_"));
            foreach (var panel in pbXEs) {
                panel.Tag = (TransmitEnableSettings)Enum.Parse(typeof(TransmitEnableSettings), panel.Name.Substring(5));
                panel.Click += pbXE_Click;
            }

            // populate key press tables
            foreach (var keyTuple in KeyEmulation.KeyDefinitions) {
                int rowId = dgvKeyEmulation.Rows.Add(keyTuple.Item1, keyTuple.Item2, keyTuple.Item3);
                var row = dgvKeyEmulation.Rows[rowId];
                row.Tag = keyTuple;

                if (keyTuple.Item2 != 0) { // skip 'exit setup' keycode 0
                    rowId = dgvKeyEnabling.Rows.Add(keyTuple.Item1, CheckState.Indeterminate, "Enable", "Disable", "Toggle");
                    row = dgvKeyEnabling.Rows[rowId];
                    row.Tag = keyTuple;
                }
            }

            cbLightingMode.DataSource = Enum.GetValues(typeof(LightingMode));
        }

        private void OnDeviceStateChanged(object sender, PropertyChangedEventArgs e) {
            if (InvokeRequired) {
                BeginInvoke((PropertyChangedEventHandler)OnDeviceStateChanged, sender, e);
                return;
            }

            #region Main tab

            if (e.PropertyName == nameof(DeviceState.PowerState)) {
                if (_deviceState.PowerState == null) return;
                if (_deviceState.PowerState == PowerState.PowerOn) {
                    lblPowerStateVal.Text = "on";
                    lblPowerStateVal.ForeColor = Color.Green;
                }
                else if (_deviceState.PowerState == PowerState.PowerOff) {
                    lblPowerStateVal.Text = "off";
                    lblPowerStateVal.ForeColor = Color.Red;
                }
            }

            else if (e.PropertyName == nameof(DeviceState.MasterVolume)) {
                if (_deviceState.MasterVolume.HasValue)
                    UpdateVolumeLabel(_deviceState.MasterVolume.Value);
            }

            #endregion

            #region Advanced tab

            if (e.PropertyName == nameof(DeviceState.IPAddress)) {
                if (_deviceState.IPAddress == null) return;
                tbIpAddress.Text = _deviceState.IPAddress.ToString();
            }
            else if (e.PropertyName == nameof(DeviceState.Version)) {
                if (_deviceState.Version == null) return;
                tbFirmwareVersion.Text = _deviceState.Version.ToString();
            }
            else if (e.PropertyName == nameof(DeviceState.LastErrorCode)) {
                if (_deviceState.LastErrorCode == null) return;
                tbLastErrorCode.Text = _deviceState.LastErrorCode.ToString();
            }
            else if (e.PropertyName == nameof(DeviceState.Capabilities)) {
                if (_deviceState.Capabilities == null) return;
                tbCapabilities.Text = _deviceState.Capabilities.ToString();

                // create necessary zone and input controls if they don't exist yet
                if (flowLayoutZones.Controls.Count != _deviceState.Capabilities.NumZones) {
                    flowLayoutZones.Controls.Clear();
                    flowLayoutAudioControls.Controls.Clear();

                    for (int i = 0; i < _deviceState.Capabilities.NumZones; i++) {
                        var zs = _deviceState.Zones[i];
                        var zc = NewZoneMapControl(zs);
                        flowLayoutZones.Controls.Add(zc);
                        var ac = NewZoneAudioControl(zs);
                        flowLayoutAudioControls.Controls.Add(ac);
                    }
                }

                /* TODO
                // create necessary zone and input controls if they don't exist yet
                if (flowLayoutInputs.Controls.Count != _deviceState.Capabilities.NumInputs) {
                    flowLayoutInputs.Controls.Clear();
                    for (int i = 0; i < _deviceState.Capabilities.NumInputs; i++) {
                        var ins = _deviceState.GetInputState(i);
                        var ic = new InputControls(ins);
                        flowLayoutInputs.Controls.Add(ic);
                    }
                }*/
            }

            else if (e.PropertyName == nameof(DeviceState.Lighting)) {
                if (_deviceState.Lighting == null) return;
                cbLightingMode.SelectedItem = _deviceState.Lighting.Mode;
                nudBright.Value = _deviceState.Lighting.Bright;
                nudDimmed.Value = _deviceState.Lighting.Dim;
                nudStandby.Value = _deviceState.Lighting.Standbye;
            }

            else if (e.PropertyName == nameof(DeviceState.XS)) {
                if (!_deviceState.XS.HasValue) return;

                var pbXSs = pbXS_ACK.Parent.Controls.OfType<Panel>().Where(p => p.Name.StartsWith("pbXS_"))
                    .Union(new[] { pbMirrored_KYD, pbMirrored_KYE });
                foreach (var pb in pbXSs) {
                    var flag = (ExtendedSettings)pb.Tag;
                    // if this fires, XS is guaranteed to have a value
                    if (_deviceState.XS.Value.HasFlag(flag)) pb.BackColor = Color.Green;
                    else pb.BackColor = Color.Red;
                }

                rbAudioModeAutoConvert.Checked = _deviceState.XS.Value.HasFlag(ExtendedSettings.AUT);
                rbAudioModeClassic.Checked = !_deviceState.XS.Value.HasFlag(ExtendedSettings.AUT);
            }

            else if (e.PropertyName == nameof(DeviceState.XE)) {
                if (!_deviceState.XE.HasValue) return;

                var pbXEs = pbXE_CTL.Parent.Controls.OfType<Panel>().Where(p => p.Name.StartsWith("pbXE_"));
                foreach (var pb in pbXEs) {
                    var flag = (TransmitEnableSettings)pb.Tag;
                    // if this fires, XE is guaranteed to have a value
                    if (_deviceState.XE.Value.HasFlag(flag)) pb.BackColor = Color.Green;
                    else pb.BackColor = Color.Red;
                }
            }
            #endregion
        }

        private ZoneMapControl NewZoneMapControl(ZoneState zs) {
            var zc = new ZoneMapControl(zs, _deviceState);
            zc.RequestLineTransmit += (sender, args) => args.Commands.ForEach(c => _proto.Write(c));
            return zc;
        }

        private AudioSettingsControl NewZoneAudioControl(ZoneState zs) {
            var ac = new AudioSettingsControl(zs, _deviceState);
            ac.RequestLineTransmit += (sender, args) => args.Commands.ForEach(c => _proto.Write(c));
            return ac;
        }

        #region Connection events
        private void OnConnect(object sender, EventArgs e) {
            _logger.LogText("Connected to Zektor", LogMsgType.Success);
            lblConnectionStateVal.ForeColor = Color.Green;
            lblConnectionStateVal.Text = "yes";

            Task.Run(() => {
                // knowing capabilities and extended settings first is useful
                _proto.Write(new QueryCapabilityInfo { IsQueryRequest = true });
                _proto.Write(new ControlSettings { IsQueryRequest = true });

                // next we can query whatever else we want to know
                _proto.Write(new PowerControl { IsQueryRequest = true });

                var allZones = new HashSet<int>(new Range(1, 8).Flatten());
                _proto.Write(new SetZone { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new MuteZone { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new DelaySwitchZones { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new MasterVolume { IsQueryRequest = true, });
                _proto.Write(new ZoneVolumeAdjust { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new BassLevelAdjust { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new TrebleLevelAdjust { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new Eq1z { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new Eq2z { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new Eq3z { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new Eq4z { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new Eq5z { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new MixDownStereo { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new DigitalRoute { IsQueryRequest = true, Zones = { (allZones, null) }, });
                _proto.Write(new FirmwareInfo { IsQueryRequest = true });
                _proto.Write(new RecentError { });
                _proto.Write(new TransmitEnable { IsQueryRequest = true });
                _proto.Write(new LedIntensities { IsQueryRequest = true });
                _proto.Write(new IpAddressInfo { IsQueryRequest = true });
            });
        }

        private void OnDisconnect(object sender, ConnectionLostArgs e) {
            _logger.LogText("Connection to Zektor lost", LogMsgType.Error);
            lblConnectionStateVal.ForeColor = Color.Red;
            lblConnectionStateVal.Text = "no";
        }

        private void OnConnecting(object sender, EventArgs e) {
            _logger.LogText("Connecting...", LogMsgType.Info);
            lblConnectionStateVal.ForeColor = Color.Orange;
            lblConnectionStateVal.Text = "busy";
        }

        private void OnConnectFailed(object sender, ConnectingFailedArgs e) {
            _logger.LogText("Connection failed, retrying in 2s", LogMsgType.Error);
            lblConnectionStateVal.ForeColor = Color.Black;
            lblConnectionStateVal.Text = "no";
        }
        #endregion

        #region Main control tab UI events
        private void btnConnect_Click(object sender, EventArgs e) {
            if (_ds == null) btnSetup_Click(null, null);
            _ds?.Start();
        }

        private void btnDisconnect_Click(object sender, EventArgs e) {
            _ds.Stop();
        }

        private void btnSetup_Click(object sender, EventArgs e) {
            using (var form = new ConnectionSetupForm(_ds)) {
                if (form.ShowDialog() == DialogResult.OK) {
                    _ds = form.DataSource;
                }
            }
        }
        private void SetupDataSource() {
            // setup datasource
            _ds.ReconnectBehavior = ReconnectBehavior.ReconnectAlways;
            _ds.AlwaysFireConnectionFailed = true;
            _ds.AlwaysFireConnectionPending = true;
            _ds.ConnectionEstablished += OnConnect;
            _ds.ConnectingFailed += OnConnectFailed;
            _ds.ConnectionPending += OnConnecting;
            _ds.ConnectionLost += OnDisconnect;
            _proto.Attach(_ds);
        }

        private void btnPowerOn_Click(object sender, EventArgs e) {
            _proto.Write(new PowerControl { State = PowerState.PowerOn });
        }

        private void btnPowerOff_Click(object sender, EventArgs e) {
            _proto.Write(new PowerControl { State = PowerState.PowerOff });
        }

        private void btnPowerToggle_Click(object sender, EventArgs e) {
            _proto.Write(new PowerControl { State = PowerState.Toggle });
        }

        private void btnReadMasterVolume_Click(object sender, EventArgs e) {
            // invalidate cache
            _deviceState.MasterVolume = null;
            _proto.Write(new MasterVolume { IsQueryRequest = true });
        }

        private void btnChangeMasterVolume_Click(object sender, EventArgs e) {
            _proto.Write(new MasterVolume { Volume = tkbMasterVolume.Value });
        }
        private void tkbMasterVolume_Scroll(object sender, EventArgs e) {
            UpdateVolumeLabel(tkbMasterVolume.Value);
        }

        private void UpdateVolumeLabel(int vol) {
            this.tkbMasterVolume.Value = vol;
            if (vol == 0) {
                lblVolumeLevelVal.Text = "Full mute";
            }
            else {
                double attenuation = vol / 2.0 - 100.0;
                lblVolumeLevelVal.Text = attenuation.ToString("F1") + "dB";
            }
        }

        private void btnReadAudioMode_Click(object sender, EventArgs e) {
            // invalidate cache
            _deviceState.XS = null;
            _proto.Write(new ControlSettings { IsQueryRequest = true });
        }

        private void btnChangeAudioMode_Click(object sender, EventArgs e) {
            _proto.Write(new ControlSettings {
                XS = ExtendedSettings.AUT,
                EnableXS = rbAudioModeAutoConvert.Checked ? BitState.Enable : BitState.Disable
            });
        }
        #endregion

        #region Advanced control tab UI events
        private void btnReadIP_Click(object sender, EventArgs e) {
            _deviceState.IPAddress = null;
            _proto.Write(new IpAddressInfo { IsQueryRequest = true });
        }

        private void btnChangeIP_Click(object sender, EventArgs e) {
            _proto.Write(new IpAddressInfo {
                IpAddress = IPAddress.Parse(tbIpAddress.Text),
            });
        }

        private void btnReadFirmware_Click(object sender, EventArgs e) {
            _deviceState.Version = null;
            _proto.Write(new FirmwareInfo { IsQueryRequest = true });
        }

        private void btnReadErrorCode_Click(object sender, EventArgs e) {
            _deviceState.LastErrorCode = null;
            _proto.Write(new RecentError { IsResponse = false });
        }

        private void btnReadCapabilities_Click(object sender, EventArgs e) {
            _deviceState.Capabilities = null;
            _proto.Write(new QueryCapabilityInfo { IsQueryRequest = true });
        }

        private void btnReadLightingMode_Click(object sender, EventArgs e) {
            _deviceState.Lighting = null;
            _proto.Write(new LedIntensities { IsQueryRequest = true });
        }

        private void btnChangeLightingMode_Click(object sender, EventArgs e) {
            _proto.Write(new LedIntensities {
                Mode = (LightingMode)cbLightingMode.SelectedItem,
                Bright = (int)nudBright.Value,
                Dim = (int)nudDimmed.Value,
                Standby = (int)nudStandby.Value,
            });
        }

        private void btnReadControlSettings_Click(object sender, EventArgs e) {
            _deviceState.XS = null;
            _proto.Write(new ControlSettings { IsQueryRequest = true });
        }

        private void btnReadTransmitEnableSettings_Click(object sender, EventArgs e) {
            _deviceState.XE = null;
            _proto.Write(new TransmitEnable { IsQueryRequest = true });
        }

        private void pbXS_Click(object sender, EventArgs e) {
            var flag = (ExtendedSettings)((Panel)sender).Tag;
            var currentFlags = _deviceState.XS ?? ExtendedSettings.All;
            _proto.Write(new ControlSettings {
                XS = flag,
                EnableXS = currentFlags.HasFlag(flag) ? BitState.Disable : BitState.Enable
            });
        }

        private void pbXE_Click(object sender, EventArgs e) {
            var flag = (TransmitEnableSettings)((Panel)sender).Tag;
            var currentFlags = _deviceState.XE ?? TransmitEnableSettings.All;
            _proto.Write(new TransmitEnable {
                XE = flag,
                EnableXE = currentFlags.HasFlag(flag) ? BitState.Disable : BitState.Enable
            });
        }

        private void btnOptimize_Click(object sender, EventArgs e) {
            // some options have absolutely no effect on the proper working
            // of this program, while some others are somewhat desired

            // enable options
            _proto.Write(new ControlSettings {
                XS = ExtendedSettings.ASY // Asynchronous mode
                    | ExtendedSettings.CSE // Append a checksums to all responses
                    | ExtendedSettings.ECO, // Enable the ‘Parameter Changed’ Strings
                EnableXS = BitState.Enable,
            });

            // disable others
            _proto.Write(new ControlSettings {
                XS = ExtendedSettings.ACK // don't acknowledge everything
                     | ExtendedSettings.CHM // Only send a “.ch” when needed.
                     ,// | ExtendedSettings.CRE, // Don’t send CRs/LFs at end of responses
                EnableXS = BitState.Disable,
            });

            // enable all change notifications
            _proto.Write(new TransmitEnable {
                XE = TransmitEnableSettings.All,
                EnableXE = BitState.Enable,
            });
        }

        #endregion

        #region Keys tab UI events
        private void btnReadKeysEnabled_Click(object sender, EventArgs e) {
            foreach ((string key, int press, int release) in KeyEmulation.KeyDefinitions) {
                if (press == 0) continue;
                _proto.Write(new KeyEnable { IsQueryRequest = true, KeyCode = press });
            }
        }
        private void OnDeviceKeyStateChanged(object sender, KeyStateChangedEventArgs e) {
            if (InvokeRequired) {
                BeginInvoke((EventHandler<KeyStateChangedEventArgs>)OnDeviceKeyStateChanged, sender, e);
                return;
            }
            foreach (DataGridViewRow row in dgvKeyEnabling.Rows) {
                var rowTup = ((string, int, int))row.Tag;
                if (rowTup.Item1 != e.KeyTuple.Item1) continue;
                row.Cells[1].Value = e.KeyEnabled;
            }
        }

        private void dgvKeyEmulation_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvKeyEmulation.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                var row = dgvKeyEmulation.Rows[e.RowIndex];
                var keyTup = ((string, int, int))row.Tag;

                _proto.Write(new KeyEmulation {
                    KeyCodes = { e.ColumnIndex == 1 ? keyTup.Item2 : keyTup.Item3 }
                });
            }
        }

        private void dgvKeyEnabling_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvKeyEnabling.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                var row = dgvKeyEnabling.Rows[e.RowIndex];
                var keyTup = ((string, int, int))row.Tag;
                EnableState es;
                if (e.ColumnIndex == 2) es = EnableState.Enabled;
                else if (e.ColumnIndex == 3) es = EnableState.Disabled;
                else if (e.ColumnIndex == 4) es = EnableState.Toggle;
                else return;
                _proto.Write(new KeyEnable {
                    KeyCode = keyTup.Item2,
                    State = es,
                });
            }
        }

        #endregion

    }
}
