namespace Zektor.Protocol.Audio {
    public class LipSyncZoneDelay : MultiZoneCommand<int?> {
        protected override string Command => "LSZ";
        protected override int? ParseParam(string str) {
            return int.TryParse(str, out int val) ? (int?)val : null;
        }
        protected override string FormatParam(int? param) {
            return param.HasValue ? param.Value.ToString() : "";
        }
    }
}