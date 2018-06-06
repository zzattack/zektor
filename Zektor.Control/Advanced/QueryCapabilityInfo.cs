using System.Text;

namespace Zektor.Protocol.Advanced {
    public class QueryCapabilityInfo : ZektorControlCommand {
        protected override string Command => "QI";
        public int NumZones { get; set; }
        public int NumInputs { get; set; }
        public int ChannelBitmap { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;

            var parts = cmd.Split(',');
            if (parts.Length != 3) return false;
            NumZones = int.Parse(parts[0]);
            NumInputs = int.Parse(parts[1]);
            ChannelBitmap = int.Parse(parts[2]);
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else {
                sb.Append(NumZones);
                sb.Append(',');
                sb.Append(NumInputs);
                sb.Append(',');
                sb.Append(ChannelBitmap);
            }
        }


    }
}