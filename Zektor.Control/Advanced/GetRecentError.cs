using System.Text;

namespace Zektor.Control.Advanced {
    public class GetRecentError : ZektorControlCommand {
        private ErrorCode ErrorCode;
        public override string Command => "!";
        protected override bool ParseCommand(string cmd) {
            if (cmd[0] != '!') return false;
            if (cmd.Length > 0) {
                ErrorCode = (ErrorCode)int.Parse(cmd.Substring(1));
                IsQueryResponse = true;
            }
            else {
                IsQueryRequest = true;
            }
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            sb.Append("!");
            if (IsQueryResponse)
                sb.Append((int)ErrorCode);
        }
    }
}
