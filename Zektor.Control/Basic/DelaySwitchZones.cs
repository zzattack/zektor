namespace Zektor.Control.Basic {
    public class DelaySwitchZones : MultiZoneCommand<int> {
        public override string Command => "DZ";
        protected override string FormatParam(int param) {
            return param.ToString();
        }

        protected override int ParseParam(string str) {
            return int.Parse(str);
        }
    }
}