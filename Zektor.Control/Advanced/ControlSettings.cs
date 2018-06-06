using System.Text;

namespace Zektor.Protocol.Advanced {
    public class ControlSettings : ZektorControlCommand {
        protected override string Command => "XS";
        public ExtendedSettings XS { get; set; }
        public BitState EnableXS { get; set; } = BitState.None;
        public int Options2 { get; set; }
        public BitState EnableOptions2 { get; set; } = BitState.None;

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;
            var parts = cmd.Split(',');
            if (parts.Length != 2) return false;

            if (parts[0][0] == '+' || parts[0][0] == '-') {
                EnableXS = (BitState)parts[0][0];
                parts[0] = parts[0].Substring(1);
            }
            XS = (ExtendedSettings)int.Parse(parts[0]);

            if (parts[1][0] == '+' || parts[1][0] == '-') {
                EnableOptions2 = (BitState)parts[1][0];
                parts[1] = parts[1].Substring(1);
            }
            Options2 = int.Parse(parts[1]);
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else {
                if (EnableXS != BitState.None) sb.Append((char)(int)EnableXS);
                sb.Append((int)XS);
                sb.Append(',');
                if (EnableOptions2 != BitState.None) sb.Append((char)(int)EnableOptions2);
                sb.Append(Options2);
            }
        }

    }
}