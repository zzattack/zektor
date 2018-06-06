namespace Zektor.Protocol.Basic {
    public class SetZone : MultiZoneCommand<InputChannel?> {
        protected override string Command => "SZ";

        protected override InputChannel? ParseParam(string str) {
            return string.IsNullOrEmpty(str) ? (InputChannel?)null : (InputChannel)int.Parse(str);
        }

        protected override string FormatParam(InputChannel? param) {
            return param == null ? "" : ((int)param).ToString();
        }
    }
}