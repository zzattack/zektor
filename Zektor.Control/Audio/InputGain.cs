using System.Text;
using Zektor.Control.Basic;

namespace Zektor.Control.Audio {
    public class InputGain : MultiZoneCommand<int> {
        // todo: it's not really Zones but rather Inputs that can be listed
        public override string Command => "GAI";
        protected override int ParseParam(string str) { return int.Parse(str); }
        protected override string FormatParam(int param) { return param.ToString(); }
    }
}