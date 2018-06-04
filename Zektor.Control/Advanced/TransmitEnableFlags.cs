using System.Text;

namespace Zektor.Control.Advanced {
    public class TransmitEnableFlags : ZektorControlCommand {
        public override string Command => "XE";
        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }


    }
}