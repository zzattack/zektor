using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Zektor.Protocol;
using Zektor.Protocol.Audio;

namespace Zektor {
    public partial class AudioSettingsControl : UserControl {
        private readonly ZoneState _zs;

        private AudioSettingsControl() {
            InitializeComponent();
            cbStereoMixdownMode.DataSource = Enum.GetValues(typeof(StereoMixDownMode));
            cbDigitalRouteOption.DataSource = Enum.GetValues(typeof(DigitalRouteOption));
            this.HandleCreated += OnHandleCreated; 
        }

        public AudioSettingsControl(ZoneState zs) : this() {
            _zs = zs;
            zs.PropertyChanged += OnZonePropertyChanged;
            lblZone.Text = $"#{zs.Index} -";
            lblZoneName.DataBindings.Add("Text", ConfigManager.NameMapping.ZoneNames.First(z => z.Key == _zs.Index), "Name");
            UpdateUI();
        }
        private void OnHandleCreated(object sender, EventArgs e) {
            UpdateUI();
        }

        private void OnZonePropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (InvokeRequired) {
                BeginInvoke((PropertyChangedEventHandler)OnZonePropertyChanged, sender, e);
                return;
            }

            if (e.PropertyName == "audio") UpdateUI();

            else if (e.PropertyName == nameof(ZoneState.Volume)) {
                UpdateVolumeLabel(_zs.Volume);
            }
            else if (e.PropertyName == nameof(ZoneState.Bass)) {
                UpdateBassLabel(_zs.Bass);
            }
            else if (e.PropertyName == nameof(ZoneState.Treble)) {
                UpdateTrebleLabel(_zs.Treble);
            }
            else if (e.PropertyName == nameof(ZoneState.EqBand1) && _zs.EqBand1.HasValue) {
                tkbEqBand1.Value = _zs.EqBand1.Value;
            }
            else if (e.PropertyName == nameof(ZoneState.EqBand2) && _zs.EqBand2.HasValue) {
                tkbEqBand2.Value = _zs.EqBand2.Value;
            }
            else if (e.PropertyName == nameof(ZoneState.EqBand3) && _zs.EqBand3.HasValue) {
                tkbEqBand3.Value = _zs.EqBand3.Value;
            }
            else if (e.PropertyName == nameof(ZoneState.EqBand4) && _zs.EqBand4.HasValue) {
                tkbEqBand4.Value = _zs.EqBand4.Value;
            }
            else if (e.PropertyName == nameof(ZoneState.EqBand5) && _zs.EqBand5.HasValue) {
                tkbEqBand5.Value = _zs.EqBand5.Value;
            }
            else if (e.PropertyName == nameof(ZoneState.StereoMixdown)) {
                if (_zs.StereoMixdown.HasValue)
                    cbStereoMixdownMode.SelectedItem = _zs.StereoMixdown;
                else
                    cbStereoMixdownMode.SelectedIndex = -1;
            }
            else if (e.PropertyName == nameof(ZoneState.DigitalRoute)) {
                if (_zs.DigitalRoute.HasValue)
                    cbDigitalRouteOption.SelectedItem = _zs.DigitalRoute;
                else
                    cbDigitalRouteOption.SelectedIndex = -1;
            }
        }

        private void UpdateVolumeLabel(int? val) {
            if (!val.HasValue) {
                lblVolumeLevelVal.Text = "unknown";
            }
            else {
                tkbZoneVolume.Value = (int)val;
                if (val == 0) {
                    lblVolumeLevelVal.Text = "Full mute";
                }
                else {
                    double attenuation = (int)val / 2.0 - 100.0;
                    lblVolumeLevelVal.Text = attenuation.ToString("F1") + "dB";
                }
            }
        }

        private void UpdateBassLabel(int? val) {
            if (!val.HasValue) {
                lblBassLevelVal.Text = "unknown";
            }
            else {
                tkbBassLevel.Value = (int)val;
                lblBassLevelVal.Text = (val >= 128 ? "+" : "") + (((int)val - 128) / 2.0).ToString("F1") + "dB";
            }
        }

        private void UpdateTrebleLabel(int? val) {
            if (!val.HasValue) {
                lblTrebleLevelVal.Text = "unknown";
            }
            else {
                tkbTrebleLevel.Value = (int)val;
                lblTrebleLevelVal.Text = (val >= 128 ? "+" : "") + (((int)val - 128) / 2.0).ToString("F1") + "dB";
            }
        }

        private void tkbZoneVolume_Scroll(object sender, EventArgs e) {
            UpdateVolumeLabel(tkbZoneVolume.Value);
        }

        private void tkbBassLevel_Scroll(object sender, EventArgs e) {
            UpdateBassLabel(tkbBassLevel.Value);
        }

        private void tkbTrebleLevel_Scroll(object sender, EventArgs e) {
            UpdateTrebleLabel(tkbTrebleLevel.Value);
        }

        private void UpdateUI() {
            if (!IsHandleCreated || IsDisposed) return;
            if (InvokeRequired) {
                BeginInvoke((Action)UpdateUI);
                return;
            }
            // lazy way to get it all to update
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.Volume)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.Bass)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.Treble)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.EqBand1)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.EqBand2)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.EqBand3)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.EqBand4)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.EqBand5)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.StereoMixdown)));
            OnZonePropertyChanged(this, new PropertyChangedEventArgs(nameof(ZoneState.DigitalRoute)));
        }

        public event EventHandler<RequestLinesTransmitArgs> RequestLineTransmit;
        protected virtual void OnRequestLineTransmit(RequestLinesTransmitArgs e) {
            RequestLineTransmit?.Invoke(this, e);
        }

        private void btnFlatten_Click(object sender, EventArgs e) {
            _zs.ResetEqualizerControls();
            var zoneList = new HashSet<int> { _zs.Index };
            var reqs = new ZektorCommand[] {
                new Eq1z { Zones = { (zoneList, new LevelAdjustment(128, VolumeAdjust.Absolute)) } },
                new Eq2z { Zones = { (zoneList, new LevelAdjustment(128, VolumeAdjust.Absolute)) } },
                new Eq3z { Zones = { (zoneList, new LevelAdjustment(128, VolumeAdjust.Absolute)) } },
                new Eq4z { Zones = { (zoneList, new LevelAdjustment(128, VolumeAdjust.Absolute)) } },
                new Eq5z { Zones = { (zoneList, new LevelAdjustment(128, VolumeAdjust.Absolute)) } },
            };
            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }

        private void btnReadAll_Click(object sender, EventArgs e) {
            _zs.ResetZoneAudioControls();
            var zoneList = new HashSet<int> { _zs.Index };
            var reqs = new ZektorCommand[] {
                new ZoneVolumeAdjust { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new BassLevelAdjust { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new TrebleLevelAdjust { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new Eq1z { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new Eq2z { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new Eq3z { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new Eq4z { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new Eq5z { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new MixDownStereo { IsQueryRequest = true, Zones = { (zoneList, null) }, },
                new DigitalRoute { IsQueryRequest = true, Zones = { (zoneList, null) }, },
            };
            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }

        private void btnChangeAll_Click(object sender, EventArgs e) {
            var zoneList = new HashSet<int> { _zs.Index };
            var reqs = new ZektorCommand[] {
                new ZoneVolumeAdjust { Zones = { (zoneList, new LevelAdjustment(tkbZoneVolume.Value, VolumeAdjust.Absolute)) }, },
                new BassLevelAdjust { Zones = { (zoneList, new LevelAdjustment(tkbBassLevel.Value, VolumeAdjust.Absolute)) }, },
                new TrebleLevelAdjust { Zones = { (zoneList, new LevelAdjustment(tkbTrebleLevel.Value, VolumeAdjust.Absolute)) }, },
                new Eq1z { Zones = { (zoneList, new LevelAdjustment(tkbEqBand1.Value, VolumeAdjust.Absolute)) }, },
                new Eq2z { Zones = { (zoneList, new LevelAdjustment(tkbEqBand2.Value, VolumeAdjust.Absolute)) }, },
                new Eq3z { Zones = { (zoneList, new LevelAdjustment(tkbEqBand3.Value, VolumeAdjust.Absolute)) }, },
                new Eq4z { Zones = { (zoneList, new LevelAdjustment(tkbEqBand4.Value, VolumeAdjust.Absolute)) }, },
                new Eq5z { Zones = { (zoneList, new LevelAdjustment(tkbEqBand5.Value, VolumeAdjust.Absolute)) }, },
                new MixDownStereo { Zones = { (zoneList, cbStereoMixdownMode.SelectedItem as StereoMixDownMode?) }, },
                new DigitalRoute { Zones = { (zoneList, cbDigitalRouteOption.SelectedItem as DigitalRouteOption?) }, },
            };
            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }


    }
}
