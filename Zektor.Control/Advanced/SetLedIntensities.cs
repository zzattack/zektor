using System.Text;

namespace Zektor.Control.Advanced {
    public class SetLedIntensities : ZektorControlCommand {
        public override string Command => "LI";

        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }


    }
}