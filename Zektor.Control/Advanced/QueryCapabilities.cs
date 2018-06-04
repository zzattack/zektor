using System.Text;

namespace Zektor.Control.Advanced {
    public class QueryCapabilities : ZektorControlCommand {
        public override string Command => "QI?";
        protected override bool ParseCommand(string cmd) {
            return false;
        }

        protected override void FormatCommand(StringBuilder sb) {
        }


    }
}