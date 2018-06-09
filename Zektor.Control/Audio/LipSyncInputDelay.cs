namespace Zektor.Protocol.Audio {
    public class LipSyncInputDelay : MultiInputCommand<int?> {
        protected override string Command => "LSI";


        protected override int? ParseParam(string str) {
            return int.TryParse(str, out int val) ? (int?)val : null;
        }
        protected override string FormatParam(int? param) {
            return param.HasValue ? param.Value.ToString() : "";
        }

    }
}