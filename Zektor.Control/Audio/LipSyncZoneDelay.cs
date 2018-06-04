using System.Text;
using Zektor.Control.Basic;

namespace Zektor.Control.Audio {
    public class LipSyncZoneDelay : MultiZoneCommand<int> {
        public override string Command => "LSZ";
        protected override int ParseParam(string str) { return int.Parse(str); }
        protected override string FormatParam(int param) { return param.ToString(); }
    }
}