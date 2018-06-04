using System.Text;

namespace Zektor.Control.Advanced {
    public class IpAddress : ZektorControlCommand {
        public override string Command => "IPA";
        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }


    }
}