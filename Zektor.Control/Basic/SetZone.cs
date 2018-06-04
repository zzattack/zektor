using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zektor.Control.Basic {
    public class SetZone : MultiZoneCommand<InputChannel> {
        public override string Command => "SZ";

        protected override InputChannel ParseParam(string str) {
            return (InputChannel)int.Parse(str);
        }

        protected override string FormatParam(InputChannel param) {
            return ((int)param).ToString();
        }
    }
}