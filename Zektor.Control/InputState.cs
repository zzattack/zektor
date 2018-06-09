using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Zektor.Protocol.Annotations;
using Zektor.Protocol.Audio;

namespace Zektor.Protocol {
    public class InputState : INotifyPropertyChanged {
        private int? _lipSyncDelay;
        public int Index { get; private set; } // Zero-based index. So 'Zone 1' is stored at idx 0.

        public InputState(int idx) {
            Index = idx;
        }

        public int? LipSyncDelay {
            get => _lipSyncDelay;
            set {
                if (value == _lipSyncDelay) return;
                _lipSyncDelay = value;
                OnPropertyChanged();
            }
        }

        public void Update(ZektorCommand cmd) {
            if (cmd is LipSyncInputDelay lsi && lsi.IsQueryResponse) {
                foreach (var (_, delay) in lsi.Inputs.Where(tuple => tuple.Item1.Contains(Index))) {
                    LipSyncDelay = delay;
                }
            }
        }

        public void ResetState() {
            _lipSyncDelay = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}