using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using SPAA05.Shared.Properties;
using Zektor.Protocol.Basic;

namespace Zektor.Protocol {
    public class ZoneState : INotifyPropertyChanged {
        public int Index { get; private set; } // 1-based index. So 'Zone 1' is has idx 1.
        private VideoInputChannel? _videoInput;
        private InputChannel? _analogAudioInput;
        private InputChannel? _digitalAudioInput;
        private MuteOption? _videoMute;
        private MuteOption? _analogAudioMute;
        private MuteOption? _digitalAudioMute;
        private int? _videoDelay;
        private int? _analogAudioDelay;
        private int? _digitalAudioDelay;

        public ZoneState(int zoneIndex) {
            this.Index = zoneIndex;
        }

        public VideoInputChannel? VideoInput {
            get => _videoInput;
            set {
                if (value == _videoInput) return;
                _videoInput = value;
                OnPropertyChanged();
            }
        }

        public InputChannel? AnalogAudioInput {
            get => _analogAudioInput;
            set {
                if (value == _analogAudioInput) return;
                _analogAudioInput = value;
                OnPropertyChanged();
            }
        }

        public InputChannel? DigitalAudioInput {
            get => _digitalAudioInput;
            set {
                if (value == _digitalAudioInput) return;
                _digitalAudioInput = value;
                OnPropertyChanged();
            }
        }

        public MuteOption? VideoMute {
            get => _videoMute;
            set {
                if (value == _videoMute) return;
                _videoMute = value;
                OnPropertyChanged();
            }
        }

        public MuteOption? AnalogAudioMute {
            get => _analogAudioMute;
            set {
                if (value == _analogAudioMute) return;
                _analogAudioMute = value;
                OnPropertyChanged();
            }
        }

        public MuteOption? DigitalAudioMute {
            get => _digitalAudioMute;
            set {
                if (value == _digitalAudioMute) return;
                _digitalAudioMute = value;
                OnPropertyChanged();
            }
        }

        public int? VideoDelay {
            get => _videoDelay;
            set {
                if (value == _videoDelay) return;
                _videoDelay = value;
                OnPropertyChanged();
            }
        }

        public int? AnalogAudioDelay {
            get => _analogAudioDelay;
            set {
                if (value == _analogAudioDelay) return;
                _analogAudioDelay = value;
                OnPropertyChanged();
            }
        }

        public int? DigitalAudioDelay {
            get => _digitalAudioDelay;
            set {
                if (value == _digitalAudioDelay) return;
                _digitalAudioDelay = value;
                OnPropertyChanged();
            }
        }

        public void Update(ZektorCommand cmd) {
            if (cmd is SetZone sz && sz.IsQueryResponse) {
                foreach (var (_, ch) in sz.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if ((sz.Channels & ChannelBitmap.YPbPrVideo) != 0) VideoInput = (VideoInputChannel)ch;
                    if ((sz.Channels & ChannelBitmap.AnalogAudio) != 0) AnalogAudioInput = (InputChannel)ch;
                    if ((sz.Channels & ChannelBitmap.DigitalAudio) != 0) DigitalAudioInput = (InputChannel)ch;
                }
            }
            else if (cmd is MuteZone mz && mz.IsQueryResponse) {
                foreach (var (_, mute) in mz.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if ((mz.Channels & ChannelBitmap.YPbPrVideo) != 0) VideoMute = mute;
                    if ((mz.Channels & ChannelBitmap.AnalogAudio) != 0) AnalogAudioMute = mute;
                    if ((mz.Channels & ChannelBitmap.DigitalAudio) != 0) DigitalAudioMute = mute;
                }
            }
            else if (cmd is DelaySwitchZones dz && dz.IsQueryResponse) {
                foreach (var (_, delay) in dz.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if ((dz.Channels & ChannelBitmap.YPbPrVideo) != 0) VideoDelay = delay;
                    if ((dz.Channels & ChannelBitmap.AnalogAudio) != 0) AnalogAudioDelay = delay;
                    if ((dz.Channels & ChannelBitmap.DigitalAudio) != 0) DigitalAudioDelay = delay;
                }
            }
        }
        public void Reset() {
            _videoInput = null;
            _analogAudioInput = null;
            _digitalAudioInput = null;
            _videoMute = null;
            _analogAudioMute = null;
            _digitalAudioMute = null;
            _videoDelay = null;
            _analogAudioDelay = null;
            _digitalAudioDelay = null;
            OnPropertyChanged("all");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}