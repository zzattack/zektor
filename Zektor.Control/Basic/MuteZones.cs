using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zektor.Control.Basic {
    public class MuteZones : MultiZoneCommand<MuteOption> {
        public override string Command => "MZ";
        
        protected override MuteOption ParseParam(string str) {
            return (MuteOption)str[0];
        }

        protected override string FormatParam(MuteOption param) {
            return new string((char)param, 1);
        }
    }
}