using System.Text;

namespace Zektor.Protocol.Advanced {
    public class RecentError : ZektorCommand {
        public bool IsResponse { get; set; }
        public ErrorCode ErrorCode { get; set; }
        protected override bool Parse(string cmd) {
            if (cmd.Length < 1 || cmd[0] != '!') return false;
            if (cmd.Length > 1) {
                ErrorCode = (ErrorCode)int.Parse(cmd.Substring(1));
                IsResponse = true;
            }
            else IsResponse = false;
            return true;
        }

        protected override string Format() {
            StringBuilder sb = new StringBuilder();
            sb.Append('!');
            if (IsResponse)
                sb.Append((int)ErrorCode);
            return sb.ToString();
        }
    }
}
