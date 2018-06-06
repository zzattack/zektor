using System.Text;

namespace Zektor.Protocol.Audio {
    public class VolumeToneStepSize : ZektorControlCommand {
        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }


        protected override string Command => "VTS";
    }
}