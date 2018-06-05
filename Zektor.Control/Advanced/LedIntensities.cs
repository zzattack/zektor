using System.Text;

namespace Zektor.Control.Advanced {
    public class LedIntensities : ZektorControlCommand {
        public override string Command => "LI";
        public int Mode { get; set; }
        public int Dim { get; set; }
        public int Bright { get; set; }
        public int Off { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;

            var parts = cmd.Split(',');
            if (parts.Length != 4) return false;
            Mode = int.Parse(parts[0]);
            Dim = int.Parse(parts[1]);
            Bright = int.Parse(parts[2]);
            Off = int.Parse(parts[3]);
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else {
                sb.Append(Mode);
                sb.Append(',');
                sb.Append(Dim);
                sb.Append(',');
                sb.Append(Bright);
                sb.Append(',');
                sb.Append(Off);
            }
        }


    }
}