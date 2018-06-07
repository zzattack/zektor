using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Zektor.Protocol.Annotations;
using Zektor.Protocol.Audio;
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
        
        private int? _volume;
        private int? _bass;
        private int? _treble;
        private int? _eqBand1;
        private int? _eqBand2;
        private int? _eqBand3;
        private int? _eqBand4;
        private int? _eqBand5;
        private StereoMixDownMode? _stereoMixdown;
        private DigitalRouteOption? _digitalRoute;

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


        public int? Volume {
            get => _volume;
            set {
                if (value == _volume) return;
                _volume = value;
                OnPropertyChanged();
            }
        }
        
        public int? Bass {
            get => _bass;
            set {
                if (value == _bass) return;
                _bass = value;
                OnPropertyChanged();
            }
        }
        
        public int? Treble {
            get => _treble;
            set {
                if (value == _treble) return;
                _treble = value;
                OnPropertyChanged();
            }
        }
        
        public int? EqBand1 {
            get => _eqBand1;
            set {
                if (value == _eqBand1) return;
                _eqBand1 = value;
                OnPropertyChanged();
            }
        }

        public int? EqBand2 {
            get => _eqBand2;
            set {
                if (value == _eqBand2) return;
                _eqBand2 = value;
                OnPropertyChanged();
            }
        }
        

        public int? EqBand3 {
            get => _eqBand3;
            set {
                if (value == _eqBand3) return;
                _eqBand3 = value;
                OnPropertyChanged();
            }
        }
        
        public int? EqBand4 {
            get => _eqBand4;
            set {
                if (value == _eqBand4) return;
                _eqBand4 = value;
                OnPropertyChanged();
            }
        }

        public int? EqBand5 {
            get => _eqBand5;
            set {
                if (value == _eqBand5) return;
                _eqBand5 = value;
                OnPropertyChanged();
            }
        }
        
        public StereoMixDownMode? StereoMixdown {
            get => _stereoMixdown;
            set {
                if (value == _stereoMixdown) return;
                _stereoMixdown = value;
                OnPropertyChanged();
            }
        }
        
        public DigitalRouteOption? DigitalRoute {
            get => _digitalRoute;
            set {
                if (value == _digitalRoute) return;
                _digitalRoute = value;
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
            else if (cmd is ZoneVolumeAdjust zv && zv.IsQueryResponse) {
                foreach (var (_, level) in zv.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if (level.AdjustMode == VolumeAdjust.Absolute) Volume = level.Adjustment;
                }
            }
            else if (cmd is BassLevelAdjust ba && ba.IsQueryResponse) {
                foreach (var (_, level) in ba.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if (level.AdjustMode == VolumeAdjust.Absolute) Bass = level.Adjustment;
                }
            }
            else if (cmd is TrebleLevelAdjust ta && ta.IsQueryResponse) {
                foreach (var (_, level) in ta.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if (level.AdjustMode == VolumeAdjust.Absolute) Treble = level.Adjustment;
                }
            }
            else if (cmd is Eq1z eq1 && eq1.IsQueryResponse) {
                foreach (var (_, level) in eq1.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if (level.AdjustMode == VolumeAdjust.Absolute) EqBand1 = level.Adjustment;
                }
            }
            else if (cmd is Eq2z eq2 && eq2.IsQueryResponse) {
                foreach (var (_, level) in eq2.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if (level.AdjustMode == VolumeAdjust.Absolute) EqBand2 = level.Adjustment;
                }
            }
            else if (cmd is Eq3z eq3 && eq3.IsQueryResponse) {
                foreach (var (_, level) in eq3.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if (level.AdjustMode == VolumeAdjust.Absolute) EqBand3 = level.Adjustment;
                }
            }
            else if (cmd is Eq4z eq4 && eq4.IsQueryResponse) {
                foreach (var (_, level) in eq4.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if (level.AdjustMode == VolumeAdjust.Absolute) EqBand4 = level.Adjustment;
                }
            }
            else if (cmd is Eq5z eq5 && eq5.IsQueryResponse) {
                foreach (var (_, level) in eq5.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    if (level.AdjustMode == VolumeAdjust.Absolute) EqBand5 = level.Adjustment;
                }
            }
            else if (cmd is MixDownStereo mds && mds.IsQueryResponse) {
                foreach (var (_, sm) in mds.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    StereoMixdown = sm;
                }
            }
            else if (cmd is DigitalRoute drz && drz.IsQueryResponse) {
                foreach (var (_, dr) in drz.Zones.Where(tuple => tuple.Item1.Contains(Index))) {
                    DigitalRoute = dr;
                }
            }
        }

        public void ResetZoneInputs() {
            _videoInput = null;
            _analogAudioInput = null;
            _digitalAudioInput = null;
            _videoMute = null;
            _analogAudioMute = null;
            _digitalAudioMute = null;
            _videoDelay = null;
            _analogAudioDelay = null;
            _digitalAudioDelay = null;
            OnPropertyChanged("inputs");
        }
        public void ResetZoneAudioControls() {
            _volume = null;
            _bass = null;
            _treble = null;
            _eqBand1 = null;
            _eqBand2 = null;
            _eqBand3 = null;
            _eqBand4 = null;
            _eqBand5 = null;
            _stereoMixdown = null;
            _digitalRoute = null;
            OnPropertyChanged("audio");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}