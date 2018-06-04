using System.Collections.Generic;
using System.Text;
using Zektor.Control.Basic;

namespace Zektor.Control.Audio {
    public class MixDownStereo : MultiZoneCommand<StereoMixDownMode> {
        public override string Command => "MXZ";
        
        protected override StereoMixDownMode ParseParam(string str) {
            return (StereoMixDownMode)int.Parse(str);
        }

        protected override string FormatParam(StereoMixDownMode param) {
            return ((int)param).ToString();
        }
    }
}