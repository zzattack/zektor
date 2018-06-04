using System.Text;
using Zektor.Control.Basic;

namespace Zektor.Control.Audio {
    public class DigitalRoute : MultiZoneCommand<DigitalRouteOption> {
        public override string Command => "DRZ";
        protected override DigitalRouteOption ParseParam(string str) {
            return (DigitalRouteOption)int.Parse(str);
        }

        protected override string FormatParam(DigitalRouteOption param) {
            return ((int)param).ToString();
        }
    }
}