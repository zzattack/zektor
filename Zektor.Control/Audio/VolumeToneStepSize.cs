using System.Text;

namespace Zektor.Control.Audio {
    public class VolumeToneStepSize : ZektorControlCommand {
        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }


        public override string Command => "VTS";
    }
}