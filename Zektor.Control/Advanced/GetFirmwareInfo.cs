using System.Text;

namespace Zektor.Control.Advanced {
    public class GetFirmwareInfo : ZektorControlCommand {
        public override string Command => "V?";
        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }


    }
}