namespace Zektor.Protocol.Audio {
    public class MixDownStereo : MultiZoneCommand<StereoMixDownMode?> {
        protected override string Command => "MXZ";
        
        protected override StereoMixDownMode? ParseParam(string str) {
            return (StereoMixDownMode)int.Parse(str);
        }

        protected override string FormatParam(StereoMixDownMode? param) {
            return !param.HasValue ? "" : ((int)param.Value).ToString();
        }
    }
}