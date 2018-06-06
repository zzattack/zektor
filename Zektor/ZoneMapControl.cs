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
        }

        public ZoneMapControl(ZoneState zs, DeviceState ds) : this() {
            _zs = zs;
            _ds = ds;
            zs.PropertyChanged += OnZonePropertyChanged;
            ds.PropertyChanged += OnDevicePropertyChanged;
            lblZoneIdx.Text = zs.Index.ToString();
            UpdateUI();
        }

        private void OnDevicePropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == nameof(DeviceState.XS))
                UpdateUI();
        }

        private void UpdateUI() {
            if (InvokeRequired) {
                BeginInvoke((Action)UpdateUI);
                return;
            }

            // show/hide digital audio stuff depending on XS.AUT bit
            if (_ds.XS.HasValue) {
                lblUnknownAudioMode.Visible = false;
                gbIOs.Visible = gbIOs.Enabled = true;

                if (_ds.XS.Value.HasFlag(ExtendedSettings.AUT)) {
                    lblAnalogAudio.Text = "Audio input";
                    lblDigitalAudio.Visible = false;
                    ckbMuteDigitalAudio.Visible = false;
                    cbDigitalAudioInput.Visible = false;
                }
                else {
                    lblAnalogAudio.Text = "Analog audio input";
                    lblDigitalAudio.Visible = true;
                    ckbMuteDigitalAudio.Visible = true;
                    cbDigitalAudioInput.Visible = true;
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

            ckbMuteVideo.CheckState = CheckStateFrom(_zs.VideoMute);
            ckbMuteAnalogAudio.CheckState = CheckStateFrom(_zs.AnalogAudioMute);
            ckbMuteDigitalAudio.CheckState = CheckStateFrom(_zs.DigitalAudioMute);
        }

        private CheckState CheckStateFrom(MuteOption? mu) {
            return mu.HasValue ? (mu.Value == MuteOption.Muted ? CheckState.Checked : CheckState.Unchecked) : CheckState.Indeterminate;
        }

        private void OnZonePropertyChanged(object sender, PropertyChangedEventArgs e) {
            UpdateUI();
        }

        private void btnRead_Click(object sender, EventArgs e) {
            _zs.Reset();
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
            reqs.AddRange(OptimizeInputs());
            reqs.AddRange(OptimizeMutes());

            _zs.Reset(); // now current selection may be invalidated

            OnRequestLineTransmit(new RequestLinesTransmitArgs(reqs));
        }

        private List<SetZone> OptimizeInputs() {
            var sz = new List<SetZone>();

            // first make zone for video channel
            var videoZone = new SetZone();
            SetZone audioZone = null;

            videoZone.Channels = ChannelBitmap.YPbPrVideo;
            (HashSet<int>, InputChannel?) tup = (new HashSet<int>{_zs.Index}, (InputChannel)cbVideoInput.SelectedIndex);
            videoZone.Zones.Add(tup);
            sz.Add(videoZone);

            if (cbAnalogAudioInput.SelectedIndex == cbVideoInput.SelectedIndex) {
                // audio and video index is similar, so just update bitmap
                videoZone.Channels |= ChannelBitmap.AnalogAudio;
            }
            else {
                audioZone = new SetZone();
                // analog audio will require unique line
                audioZone.Channels = ChannelBitmap.AnalogAudio;
                tup = (new HashSet<int> { _zs.Index }, (InputChannel)cbAnalogAudioInput.SelectedIndex);
                audioZone.Zones.Add(tup);
                sz.Add(audioZone);
            }

            // only if using classic mode, it may be possible to specify another digital audio source
            if (!_ds.XS.HasValue || (_ds.XS & ExtendedSettings.AUT) == 0) {
                // see if digital audio matches video channel
                if (cbDigitalAudioInput.SelectedIndex == cbVideoInput.SelectedIndex)
                    videoZone.Channels |= ChannelBitmap.DigitalAudio;

                else if (audioZone != null && cbDigitalAudioInput.SelectedIndex == cbAnalogAudioInput.SelectedIndex)
                    audioZone.Channels |= ChannelBitmap.DigitalAudio;

                else {
                    // also need unique command for digital audio
                    var digiZone = new SetZone();
                    digiZone.Channels = ChannelBitmap.DigitalAudio;
                    tup = (new HashSet<int> { _zs.Index }, (InputChannel)cbDigitalAudioInput.SelectedIndex);
                    digiZone.Zones.Add(tup);
                    sz.Add(digiZone);
                }
            }
            return sz;
        }

        private List<MuteZone> OptimizeMutes() {
            var mz = new List<MuteZone>();

            // first make zone for video channel
            var videoZone = new MuteZone();
            MuteZone audioZone = null;

            videoZone.Channels = ChannelBitmap.YPbPrVideo;
            (HashSet<int>, MuteOption?) tup = (new HashSet<int> { _zs.Index }, ckbMuteVideo.Checked ? MuteOption.Muted : MuteOption.NonMuted);
            videoZone.Zones.Add(tup);
            mz.Add(videoZone);

            if (ckbMuteVideo.Checked == ckbMuteAnalogAudio.Checked) {
                // audio and video index is similar, so just update bitmap
                videoZone.Channels |= ChannelBitmap.AnalogAudio;
            }
            else {
                audioZone = new MuteZone();
                // analog audio will require unique line
                audioZone.Channels = ChannelBitmap.AnalogAudio;
                tup = (new HashSet<int> { _zs.Index }, ckbMuteAnalogAudio.Checked ? MuteOption.Muted : MuteOption.NonMuted);
                audioZone.Zones.Add(tup);
                mz.Add(audioZone);
            }

            // only if using classic mode, it may be possible to specify another digital audio source
            if (!_ds.XS.HasValue || (_ds.XS & ExtendedSettings.AUT) == 0) {
                // see if digital audio matches video channel
                if (ckbMuteDigitalAudio.Checked == ckbMuteVideo.Checked)
                    videoZone.Channels |= ChannelBitmap.DigitalAudio;

                else if (audioZone != null && ckbMuteDigitalAudio.Checked == ckbMuteAnalogAudio.Checked)
                    audioZone.Channels |= ChannelBitmap.DigitalAudio;

                else {
                    // also need unique command for digital audio
                    var digiZone = new MuteZone();
                    digiZone.Channels = ChannelBitmap.DigitalAudio;
                    tup = (new HashSet<int> { _zs.Index }, ckbMuteDigitalAudio.Checked ? MuteOption.Muted : MuteOption.NonMuted);
                    digiZone.Zones.Add(tup);
                    mz.Add(digiZone);
                }
            }
            return mz;
        }


        public event EventHandler<RequestLinesTransmitArgs> RequestLineTransmit;

        protected virtual void OnRequestLineTransmit(RequestLinesTransmitArgs e) {
            RequestLineTransmit?.Invoke(this, e);
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e) {
            // all 3 indices equal --> definitely no breakaway
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
                if (_ds.XS.HasValue && !_ds.XS.Value.HasFlag(ExtendedSettings.AUT))
                    ckbBreakaway.Checked = cbVideoInput.SelectedIndex != cbDigitalAudioInput.SelectedIndex;
                else // can't tell
                    ckbBreakaway.CheckState = CheckState.Indeterminate;
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
