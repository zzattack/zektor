using System.Text;

namespace Zektor.Control.Advanced {
    public class ControlSettings : ZektorControlCommand {
        public override string Command => "XS";

        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }

    }
}