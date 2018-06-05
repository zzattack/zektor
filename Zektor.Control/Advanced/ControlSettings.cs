using System.Text;

namespace Zektor.Control.Advanced {
    public class ControlSettings : ZektorControlCommand {
        public override string Command => "XS";
        public ExtendedSettings XS { get; set; }
        public int Options2 { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;
            var parts = cmd.Split(',');
            if (parts.Length != 2) return false;

            XS = (ExtendedSettings)int.Parse(parts[0]);
            Options2 = int.Parse(parts[1]);
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else {
                sb.Append((int)XS);
                sb.Append(',');
                sb.Append((int)Options2);
            }
        }

    }
}