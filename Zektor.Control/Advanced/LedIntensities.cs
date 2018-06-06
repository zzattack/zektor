using System.Text;

namespace Zektor.Protocol.Advanced {
    public class LedIntensities : ZektorControlCommand {
        protected override string Command => "LI";
        public LightingMode Mode { get; set; }
        public int Dim { get; set; }
        public int Bright { get; set; }
        public int Standby { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;

            var parts = cmd.Split(',');
            if (parts.Length != 4) return false;
            Mode = (LightingMode)int.Parse(parts[0]);
            Dim = int.Parse(parts[1]);
            Bright = int.Parse(parts[2]);
            Standby = int.Parse(parts[3]);
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else {
                sb.Append((int)Mode);
                sb.Append(',');
                sb.Append(Dim);
                sb.Append(',');
                sb.Append(Bright);
                sb.Append(',');
                sb.Append(Standby);
            }
        }


    }
}