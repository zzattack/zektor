using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zektor.Protocol;
using Zektor.Protocol.Audio;

namespace Zektor {
    public partial class LipSyncZoneControl : UserControl {
        private readonly ZoneState _zs;

        private LipSyncZoneControl() {
            InitializeComponent();
            HandleCreated += OnHandleCreated;
        }

        private void OnHandleCreated(object sender, EventArgs e) {
            UpdateUI();
        }

        public LipSyncZoneControl(ZoneState zs) : this() {
            _zs = zs;
            zs.PropertyChanged += OnInputPropertyChanged;
            lblZoneIdx.Text = zs.Index.ToString();
            UpdateUI();
        }

        private void UpdateUI() {
            if (!IsHandleCreated || IsDisposed) return;
            if (InvokeRequired) {
                BeginInvoke((Action)UpdateUI);
                return;
            }
            // lazy way to get it all to update
            OnInputPropertyChanged(this, new PropertyChangedEventArgs(nameof(InputState.LipSyncDelay)));
        }

        private void OnInputPropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (InvokeRequired) {
                BeginInvoke((PropertyChangedEventHandler)OnInputPropertyChanged, sender, e);
                return;
            }
            if (e.PropertyName == nameof(InputState.LipSyncDelay)) {
                UpdateDelayLabel(_zs.LipSyncDelay);
            }
        }

        private void btnRead_Click(object sender, EventArgs e) {
            _zs.ResetDelay();
            var zoneList = new HashSet<int> { _zs.Index };
            var reqs = new ZektorCommand[] {
                new LipSyncZoneDelay { IsQueryRequest = true, Zones = { (zoneList, null) }, },
            };
            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }

        private void btnChange_Click(object sender, EventArgs e) {
            var zoneList = new HashSet<int> { _zs.Index };
            var reqs = new ZektorCommand[] {
                new LipSyncZoneDelay { Zones = { (zoneList, tkbDelay.Value) }, },
            };
            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }
        private void tkbDelay_Scroll(object sender, EventArgs e) {
            UpdateDelayLabel(tkbDelay.Value);
        }
        private void UpdateDelayLabel(int? val) {
            if (!val.HasValue) {
                lblDelayVal.Text = "unknown";
            }
            else {
                tkbDelay.Value = (int)val;
                lblDelayVal.Text = $@"{val.Value / 48.0:F3}ms";
            }
        }

        public event EventHandler<RequestLinesTransmitArgs> RequestLineTransmit;
        protected virtual void OnRequestLineTransmit(RequestLinesTransmitArgs e) {
            RequestLineTransmit?.Invoke(this, e);
        }

    }

}
