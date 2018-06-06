using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using SPAA05.Shared.Properties;
using SPAA05.Shared.Utility;
using Zektor.Protocol.Advanced;
using Zektor.Protocol.Audio;
using Zektor.Protocol.Basic;

namespace Zektor.Protocol {
    public class DeviceState : INotifyPropertyChanged {
        public BindingList<ZoneState> Zones = new BindingList<ZoneState>();
        public BindingList<InputState> Inputs = new BindingList<InputState>();

        private IPAddress _ipAddress = IPAddress.Any;
        private ExtendedSettings? _xs;
        private TransmitEnableSettings? _xe;
        private LightingState _lighting;
        private Dictionary<string, bool?> _keysState = new Dictionary<string, bool?>();
        private VersionState _version;
        private ErrorCode? _lastErrorCode;
        private CapabilitiesInfo _capabilities;
        private PowerState? _powerState;
        private int? _masterVolume;

        public DeviceState() {
            foreach (var key in KeyEmulation.KeyDefinitions)
                _keysState[key.Item1] = null;
        }

        public PowerState? PowerState {
            get => _powerState;
            set {
                if (value == _powerState) return;
                _powerState = value;
                OnPropertyChanged();
            }
        }

        public int? MasterVolume {
            get => _masterVolume;
            set {
                if (value == _masterVolume) return;
                _masterVolume = value;
                OnPropertyChanged();
            }
        }

        public IPAddress IPAddress {
            get => _ipAddress;
            set {
                if (Equals(value, _ipAddress)) return;
                _ipAddress = value;
                OnPropertyChanged();
            }
        }

        public VersionState Version {
            get => _version;
            set {
                if (Equals(value, _version)) return;
                _version = value;
                OnPropertyChanged();
            }
        }

        public ErrorCode? LastErrorCode {
            get => _lastErrorCode;
            set {
                if (value == _lastErrorCode) return;
                _lastErrorCode = value;
                OnPropertyChanged();
            }
        }

        public CapabilitiesInfo Capabilities {
            get => _capabilities;
            set {
                if (Equals(value, _capabilities)) return;
                _capabilities = value;
                OnPropertyChanged();
            }
        }

        public LightingState Lighting {
            get => _lighting;
            set {
                if (Equals(value, _lighting)) return;
                _lighting = value;
                OnPropertyChanged();
            }
        }

        public ExtendedSettings? XS {
            get => _xs;
            set {
                if (value == _xs) return;
                _xs = value;
                OnPropertyChanged();
            }
        }

        public TransmitEnableSettings? XE {
            get => _xe;
            set {
                if (value == _xe) return;
                _xe = value;
                OnPropertyChanged();
            }
        }


        public void Update(ZektorCommand cmd) {
            if (cmd is PowerControl pwr && pwr.IsQueryResponse) {
                PowerState = pwr.State;
            }
            else if (cmd is MasterVolume mv && mv.IsQueryResponse) {
                MasterVolume = mv.Volume;
            }
            else if (cmd is ControlSettings xs && xs.IsQueryResponse) {
                XS = xs.XS;
            }
            else if (cmd is TransmitEnable xe && xe.IsQueryResponse) {
                XE = xe.XE;
            }
            else if (cmd is IpAddressInfo ip && ip.IsQueryResponse) {
                IPAddress = ip.IpAddress;
            }
            else if (cmd is FirmwareInfo fw && fw.IsQueryResponse) {
                Version = new VersionState {
                    Model = fw.Model,
                    FirmwareVersion = fw.FirmwareVersion,
                    SerialNumber = fw.SerialNumber
                };
            }
            else if (cmd is RecentError err && err.IsResponse) {
                LastErrorCode = err.ErrorCode;
            }
            else if (cmd is QueryCapabilityInfo cap && cap.IsQueryResponse) {
                Capabilities = new CapabilitiesInfo {
                    NumInputs = cap.NumInputs,
                    NumZones = cap.NumZones,
                    ChannelBitmap = cap.ChannelBitmap
                };

                if (Zones.Count != Capabilities.NumZones) {
                    Zones.Clear();
                    for (int i = 0; i < Capabilities.NumZones; i++)
                        Zones.Add(new ZoneState(i + 1));
                }

                if (Inputs.Count != Capabilities.NumInputs) {
                    Inputs.Clear();
                    for (int i = 0; i < Capabilities.NumInputs; i++)
                        Inputs.Add(new InputState(i));
                }
            }
            else if (cmd is LedIntensities li && li.IsQueryResponse) {
                Lighting = new LightingState {
                    Mode = li.Mode,
                    Bright = li.Bright,
                    Dim = li.Dim,
                    Standbye = li.Standby
                };
            }
            else if (cmd is KeyEnable ke && ke.IsQueryResponse) {
                int pressKey = ke.KeyCode.Value; // guaranteed to have value if IsQueryResponse
                var keyTup = KeyEmulation.KeyDefinitions.FirstOrDefault(t => t.Item2 == pressKey);
                bool isEnabled = ke.State == EnableState.Enabled;
                _keysState[keyTup.Item1] = isEnabled;
                OnKeyStateChanged(new KeyStateChangedEventArgs(keyTup, isEnabled));
            }

            // delegate zone-specific commands to affected zones
            if (cmd is IZoneCommand zc) {
                foreach (int zone in zc.AffectedZones) {
                    Zones[zone].Update(cmd);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event EventHandler<KeyStateChangedEventArgs> KeyStateChanged;

        protected virtual void OnKeyStateChanged(KeyStateChangedEventArgs e) {
            KeyStateChanged?.Invoke(this, e);
        }
    }

    public class InputState : INotifyPropertyChanged {
        public InputState(int idx) {
            Index = idx;
        }

        public int Index { get; private set; } // Zero-based index. So 'Zone 1' is stored at idx 0.

        public void Update(ZektorCommand cmd) {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class VersionState {
        public string Model;
        public string FirmwareVersion;
        public string SerialNumber;

        public override string ToString() {
            return $"Model: {Model} / FW: {FirmwareVersion} / Serial: {SerialNumber}";
        }
    }

    public class CapabilitiesInfo {
        public int NumZones;
        public int NumInputs;
        public int ChannelBitmap;
        public override string ToString() {
            return $"Zones: {NumZones} / Inputs: {NumInputs} / Channel bitmap: {ChannelBitmap}";
        }
    }

    public class LightingState {
        public LightingMode Mode;
        public int Bright;
        public int Dim;
        public int Standbye;
    }

    public class KeyStateChangedEventArgs : EventArgs {
        public (string, int, int) KeyTuple { get; set; }
        public bool KeyEnabled { get; set; }
        public KeyStateChangedEventArgs((string, int, int) keyTuple, bool enabled) {
            KeyTuple = keyTuple;
            KeyEnabled = enabled;
        }
    }


}
