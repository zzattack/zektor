using System.Text;

namespace Zektor.Protocol.Basic {
    public class QueryStatus : ZektorControlCommand {
        protected override string Command => "Q";
        public QueryFlags QueryFlags { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (cmd[0] == '?') IsQueryRequest = true;
            else QueryFlags = (QueryFlags)int.Parse(cmd.Substring(2));

            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else sb.Append((int)QueryFlags);
        }
    }

    public abstract class QueryZoneStatus : ZektorControlCommand {
        public ZoneBitmap Zones { get; set; }
        protected override bool ParseCommand(string cmd) {
            if (cmd[0] == '?') IsQueryRequest = true;
            else Zones = (ZoneBitmap)int.Parse(cmd.Substring(2));

            return true;
        }

        protected sealed override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else sb.Append((int)Zones);
        }
    }

    public class QuerySetZonesStatus : QueryZoneStatus {
        protected override string Command => "QSZ";
    }
    public class QueryMuteZonesStatus : QueryZoneStatus {
        protected override string Command => "QMZ";
    }
    public class QueryDelayZonesStatus : QueryZoneStatus {
        protected override string Command => "QDZ";
    }
}
