namespace Zektor.Protocol.Basic {
    public class MuteZone : MultiZoneCommand<MuteOption?> {
        protected override string Command => "MZ";
        protected override MuteOption? ParseParam(string str) {
            return string.IsNullOrEmpty(str) ? MuteOption.None : (MuteOption)str[0];
        }

        protected override string FormatParam(MuteOption? param) {
            return param == null ? "" : new string((char)param.Value, 1);
        }
    }
}