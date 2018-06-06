using System;

namespace Zektor.Protocol.Basic {
    public class DelaySwitchZones : MultiZoneCommand<int?> {
        protected override string Command => "DZ";

        protected override int? ParseParam(string str) {
            return int.TryParse(str, out int val) ? (int?)val : null;
        }

        protected override string FormatParam(int? param) {
            return param.HasValue ? param.Value.ToString() : "";
        }

    }
}