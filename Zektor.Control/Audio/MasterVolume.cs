using System.Text;

namespace Zektor.Control.Audio {
    public class MasterVolume : ZektorControlCommand {
        public override string Command => "MV";
        public int VolumeAdjustment { get; set; } // in 0.5dB steps

        protected override bool ParseCommand(string cmd) {
            if (cmd == "?") IsQueryRequest = true;
            else VolumeAdjustment = int.Parse(cmd);
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append("?");
            else sb.Append(VolumeAdjustment);
        }
        
    }
}
