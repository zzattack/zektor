using System.Text;

namespace Zektor.Control.Advanced {
    public class EmulateKeyPress : ZektorControlCommand {
        public override string Command => "K";
        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }


    }
}