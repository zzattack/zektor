using System.Text;

namespace Zektor.Protocol.Advanced {
    public class TransmitEnable : ZektorControlCommand {
        protected override string Command => "XE";
        public TransmitEnableSettings XE { get; set; }
        public BitState EnableXE { get; set; } = BitState.None;
        public int Options2 { get; set; }
        public BitState EnableOptions2 { get; set; } = BitState.None;

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;
            var parts = cmd.Split(',');
            if (parts.Length < 2) return false;

            if (parts[0][0] == '+' || parts[0][0] == '-') {
                EnableXE = (BitState)parts[0][0];
                parts[0] = parts[0].Substring(1);
            }
            XE = (TransmitEnableSettings)int.Parse(parts[0]);

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
                if (EnableXE != BitState.None) sb.Append((char)(int)EnableXE);
                sb.Append((int)XE);
                sb.Append(',');
                if (EnableOptions2 != BitState.None) sb.Append((char)(int)EnableOptions2);
                sb.Append(Options2);
            }
        }

    }
}