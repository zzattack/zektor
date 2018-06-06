namespace Zektor.Protocol.Audio {
    public class DigitalRoute : MultiZoneCommand<DigitalRouteOption?> {
        protected override string Command => "DRZ";
        protected override DigitalRouteOption? ParseParam(string str) {
            return string.IsNullOrEmpty(str) ? (DigitalRouteOption?)null : (DigitalRouteOption)int.Parse(str);
        }

        protected override string FormatParam(DigitalRouteOption? param) {
            return param == null ? "" : ((int)param).ToString();
        }
    }
}