using System.Text;

namespace Zektor.Protocol.Audio {
    public class MasterVolume : ZektorControlCommand {
        protected override string Command => "MV";
        public int Volume { get; set; } // in 0.5dB steps

        protected override bool ParseCommand(string cmd) {
            if (cmd == "?") IsQueryRequest = true;
            else Volume = int.Parse(cmd);
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append("?");
            else sb.Append(Volume);
        }
        
    }
}
