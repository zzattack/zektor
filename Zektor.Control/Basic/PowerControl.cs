using System.Collections.Generic;
using System.Text;

namespace Zektor.Control.Basic {
    public class PowerControl : ZektorControlCommand {
        public override string Command => "P";
        public PowerAction Action { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (cmd.Length != 1) return false;
            if (cmd[0] == '?') IsQueryRequest = true;
            else Action = (PowerAction)cmd[0];
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else sb.Append((char)Action);
        }
    }
}