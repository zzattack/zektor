using System.Text;

namespace Zektor.Protocol.Basic {
    public class PowerControl : ZektorControlCommand {
        protected override string Command => "P";
        public PowerState State { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (cmd.Length != 1) return false;
            if (cmd[0] == '?') IsQueryRequest = true;
            else State = (PowerState)cmd[0];
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else sb.Append((char)State);
        }
    }
}