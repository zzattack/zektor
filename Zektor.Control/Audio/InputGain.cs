namespace Zektor.Protocol.Audio {
    public class InputGain : MultiZoneCommand<int?> {
        // todo: it's not really Zones but rather Inputs that can be listed
        protected override string Command => "GAI";
        protected override int? ParseParam(string str) {
            return int.TryParse(str, out int val) ? (int?)val : null;
        }
        protected override string FormatParam(int? param) {
            return param.HasValue ? param.Value.ToString() : "";
        }
    }
}