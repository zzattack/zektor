using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Zektor.Protocol;
using Zektor.Protocol.Basic;

namespace Zektor {
    public partial class ZoneMapControl : UserControl {
        private readonly ZoneState _zs;
        private readonly DeviceState _ds;

        private ZoneMapControl() {
            InitializeComponent();
            this.HandleCreated += OnHandleCreated;
            bsVideoMap.DataSource = ConfigManager.NameMapping.VideoInputNames;
            bsAnalogAudioMap.DataSource = ConfigManager.NameMapping.AudioInputNames;
            bsDigitalAudioMap.DataSource = ConfigManager.NameMapping.AudioInputNames;
        }

        public ZoneMapControl(ZoneState zs, DeviceState ds) : this() {
            _zs = zs;
            _ds = ds;
            zs.PropertyChanged += OnZonePropertyChanged;
            ds.PropertyChanged += OnDevicePropertyChanged;
            lblZone.Text = $"#{zs.Index} -";
            lblZoneName.DataBindings.Add("Text", ConfigManager.NameMapping.ZoneNames.First(z => z.Key == _zs.Index), "Name");
        }

        private void OnHandleCreated(object sender, EventArgs e) {
            UpdateUI();
        }

        private void OnDevicePropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(DeviceState.XS))
                UpdateUI();
        }

        internal void UpdateUI() {
            if (!IsHandleCreated || IsDisposed) return;
            if (InvokeRequired) {
                if (!_updateScheduled) {
                    BeginInvoke((Action)UpdateUI);
                    _updateScheduled = true;
                }
                return;
            }

            _updating = true;
            _updateScheduled = false;

            // show/hide digital audio stuff depending on XS.AUT bit
            if (_ds.XS.HasValue) {
                lblUnknownAudioMode.Visible = false;
                gbIOs.Visible = gbIOs.Enabled = true;

                if (_ds.XS.Value.HasFlag(ExtendedSettings.AUT)) {
                    lblAnalogAudio.Text = "Audio input";
                    lblDigitalAudio.Visible = false;
                    ckbMuteDigitalAudio.Visible = false;
                    cbDigitalAudioInput.Visible = false;
                    nudDigitalAudioDelay.Visible = false;
                }
                else {
                    lblAnalogAudio.Text = "Analog audio input";
                    lblDigitalAudio.Visible = true;
                    ckbMuteDigitalAudio.Visible = true;
                    cbDigitalAudioInput.Visible = true;
                    nudDigitalAudioDelay.Visible = true;
                }
            }
            else {
                gbIOs.Visible = false;
                lblUnknownAudioMode.Visible = true;
            }

            // select chosen sources
            if (_zs.VideoInput.HasValue && (int)_zs.VideoInput < cbVideoInput.Items.Count)
                cbVideoInput.SelectedIndex = (int)_zs.VideoInput.Value;
            else
                cbVideoInput.SelectedIndex = -1;

            if (_zs.AnalogAudioInput.HasValue && (int)_zs.AnalogAudioInput < cbAnalogAudioInput.Items.Count)
                cbAnalogAudioInput.SelectedIndex = (int)_zs.AnalogAudioInput.Value;
            else
                cbAnalogAudioInput.SelectedIndex = -1;

            if (_zs.DigitalAudioInput.HasValue && (int)_zs.DigitalAudioInput < cbDigitalAudioInput.Items.Count)
                cbDigitalAudioInput.SelectedIndex = (int)_zs.DigitalAudioInput.Value;
            else
                cbDigitalAudioInput.SelectedIndex = -1;

            // update mute checkboxes
            ckbMuteVideo.CheckState = CheckStateFrom(_zs.VideoMute);
            ckbMuteAnalogAudio.CheckState = CheckStateFrom(_zs.AnalogAudioMute);
            ckbMuteDigitalAudio.CheckState = CheckStateFrom(_zs.DigitalAudioMute);

            // update num up/downs
            if (_zs.VideoDelay.HasValue) {
                SetBogusValue(nudVideoDelay); // so text is re-written
                nudVideoDelay.Value = _zs.VideoDelay.Value;
            }
            else { // clear box
                nudVideoDelay.Text = "";
                nudVideoDelay.Refresh();
            }

            if (_zs.AnalogAudioDelay.HasValue) {
                SetBogusValue(nudAnalogAudioDelay);
                nudAnalogAudioDelay.Value = _zs.AnalogAudioDelay.Value;
            }
            else {
                nudAnalogAudioDelay.Text = "";
                nudAnalogAudioDelay.Refresh();
            }

            if (_zs.DigitalAudioDelay.HasValue) {
                SetBogusValue(nudDigitalAudioDelay);
                nudDigitalAudioDelay.Value = _zs.DigitalAudioDelay.Value;
            }
            else {
                nudDigitalAudioDelay.Text = "";
                nudDigitalAudioDelay.Refresh();
            }

            UpdateBreakaway();
            _updating = false;
        }

        private void SetBogusValue(NumericUpDown numericUpDown) {
            numericUpDown.Value = numericUpDown.Value == numericUpDown.Minimum ? numericUpDown.Maximum : numericUpDown.Minimum;
        }

        private CheckState CheckStateFrom(MuteOption? mu) {
            return mu.HasValue ? (mu.Value == MuteOption.Muted ? CheckState.Checked : CheckState.Unchecked) : CheckState.Indeterminate;
        }

        private void OnZonePropertyChanged(object sender, PropertyChangedEventArgs e) {
            UpdateUI();
        }

        private void btnRead_Click(object sender, EventArgs e) {
            _zs.ResetZoneInputs();
            var zoneList = new HashSet<int> { _zs.Index };
            var reqs = new ZektorCommand[] {
                new SetZone { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new MuteZone { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new DelaySwitchZones { IsQueryRequest = true, Zones = { (zoneList, null) }, },
            };
            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }

        private void btnChange_Click(object sender, EventArgs e) {
            var reqs = new List<ZektorCommand>();

            bool splitAudio = !_ds.XS.HasValue || (_ds.XS & ExtendedSettings.AUT) == 0;

            // optimize zones using the helper class
            reqs.AddRange(ZoneOptimizer<SetZone, InputChannel?>.OptimizeChannelBasedParameter(
                _zs.Index, splitAudio,
                (InputChannel)cbVideoInput.SelectedIndex,
                (InputChannel)cbAnalogAudioInput.SelectedIndex,
                (InputChannel)cbDigitalAudioInput.SelectedIndex));

            reqs.AddRange(ZoneOptimizer<MuteZone, MuteOption?>.OptimizeChannelBasedParameter(
                _zs.Index, splitAudio,
                ckbMuteVideo.Checked ? MuteOption.Muted : MuteOption.NonMuted,
                ckbMuteAnalogAudio.Checked ? MuteOption.Muted : MuteOption.NonMuted,
                ckbMuteDigitalAudio.Checked ? MuteOption.Muted : MuteOption.NonMuted));

            reqs.AddRange(ZoneOptimizer<DelaySwitchZones, int?>.OptimizeChannelBasedParameter(
                _zs.Index, splitAudio,
                (int)nudVideoDelay.Value,
                (int)nudAnalogAudioDelay.Value,
                (int)nudDigitalAudioDelay.Value));

            _zs.ResetZoneInputs(); // now current selection may be invalidated

            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }

        public event EventHandler<RequestLinesTransmitArgs> RequestLineTransmit;
        protected virtual void OnRequestLineTransmit(RequestLinesTransmitArgs e) {
            RequestLineTransmit?.Invoke(this, e);
        }

        private bool _updating = false;
        bool _updateScheduled = false;
        private void combobox_SelectedIndexChanged(object sender, EventArgs e) {
            if (_updating) return; // prevent recursion
            _updating = true;

            // if currently breakaway isn't active, it's likely all 3 want to
            // be kept in sync
            var cbSender = sender as ComboBox;
            if (!ckbBreakaway.Checked) {
                if (cbVideoInput != cbSender && cbSender.SelectedIndex < cbVideoInput.Items.Count)
                    cbVideoInput.SelectedIndex = cbSender.SelectedIndex;

                if (cbAnalogAudioInput != cbSender && cbSender.SelectedIndex < cbAnalogAudioInput.Items.Count)
                    cbAnalogAudioInput.SelectedIndex = cbSender.SelectedIndex;

                if (cbDigitalAudioInput != cbSender && cbSender.SelectedIndex < cbDigitalAudioInput.Items.Count)
                    cbDigitalAudioInput.SelectedIndex = cbSender.SelectedIndex;
            }

            _updating = false;
        }

        private void UpdateBreakaway() { // all 3 indices equal --> definitely no breakaway
            if (cbVideoInput.SelectedIndex == cbAnalogAudioInput.SelectedIndex
                && cbAnalogAudioInput.SelectedIndex == cbDigitalAudioInput.SelectedIndex) {
                ckbBreakaway.Checked = false;
            }

            // diff video/analog audio idx --> definitely breakaway
            else if (cbVideoInput.SelectedIndex != cbAnalogAudioInput.SelectedIndex) {
                ckbBreakaway.Checked = true;
            }

            // video idx different from digital selection: breakaway if classic mode only
            else {
                if (!_ds.XS.HasValue) // can't tell
                    ckbBreakaway.CheckState = CheckState.Indeterminate;

                // in classic mode they all have to match
                else if (!_ds.XS.Value.HasFlag(ExtendedSettings.AUT))
                    ckbBreakaway.Checked = cbVideoInput.SelectedIndex != cbDigitalAudioInput.SelectedIndex;

                // non-breakaway mode but video==analog (checked above)
                else
                    ckbBreakaway.Checked = false;
            }
        }
    }

    public class RequestLinesTransmitArgs : EventArgs {
        public List<ZektorCommand> Commands { get; private set; } = new List<ZektorCommand>();
        public RequestLinesTransmitArgs(IEnumerable<ZektorCommand> cmds) {
            Commands.AddRange(cmds);
        }

    }
}
