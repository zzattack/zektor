using System.Text;

namespace Zektor.Control.Advanced {
    public class TransmitEnable : ZektorControlCommand {
        public override string Command => "XE";
        public TransmitEnableSettings Flags { get; set; }
        public int Options2 { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;
            var parts = cmd.Split(',');
            if (parts.Length != 2) return false;

            Flags = (TransmitEnableSettings)int.Parse(parts[0]);
            Options2 = int.Parse(parts[1]);
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else {
                sb.Append((int)Flags);
                sb.Append(',');
                sb.Append((int)Options2);
            }
        }

    }
}