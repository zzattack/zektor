using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zektor.Protocol;
using Zektor.Protocol.Audio;

namespace Zektor {
    public partial class LipSyncInputControl : UserControl {
        private readonly InputState _ist;

        private LipSyncInputControl() {
            InitializeComponent();
            HandleCreated += OnHandleCreated;
        }

        private void OnHandleCreated(object sender, EventArgs e) {
            UpdateUI();
        }

        public LipSyncInputControl(InputState ist) : this() {
            _ist = ist;
            ist.PropertyChanged += OnInputPropertyChanged;
            lblInputIdx.Text = ist.Index.ToString();
            UpdateUI();
        }

        private void OnInputPropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (InvokeRequired) {
                BeginInvoke((PropertyChangedEventHandler)OnInputPropertyChanged, sender, e);
                return;
            }
            if (e.PropertyName == nameof(InputState.LipSyncDelay)) {
                UpdateDelayLabel(_ist.LipSyncDelay);
            }
        }

        private void btnRead_Click(object sender, EventArgs e) {
            _ist.ResetState();
            var inputList = new HashSet<int> { _ist.Index };
            var reqs = new ZektorCommand[] {
                new LipSyncInputDelay { IsQueryRequest = true, Inputs = { (inputList, null) }, },
            };
            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }

        private void btnChange_Click(object sender, EventArgs e) {
            var inputList = new HashSet<int> { _ist.Index };
            var reqs = new ZektorCommand[] {
                new LipSyncInputDelay { Inputs = { (inputList, tkbDelay.Value) }, },
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
        private void UpdateUI() {
            if (!IsHandleCreated || IsDisposed) return;
            if (InvokeRequired) {
                BeginInvoke((Action)UpdateUI);
                return;
            }
            // lazy way to get it all to update
            OnInputPropertyChanged(this, new PropertyChangedEventArgs(nameof(InputState.LipSyncDelay)));
        }

        public event EventHandler<RequestLinesTransmitArgs> RequestLineTransmit;
        protected virtual void OnRequestLineTransmit(RequestLinesTransmitArgs e) {
            RequestLineTransmit?.Invoke(this, e);
        }

    }
}
