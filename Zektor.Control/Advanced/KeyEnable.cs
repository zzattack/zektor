using System.Text;

namespace Zektor.Protocol.Advanced {
    public class KeyEnable : ZektorControlCommand {
        protected override string Command => "KE";
        public EnableState State { get; set; }
        public int? KeyCode { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0; // after '?' no data should follow

            // query commands may have data in front of them for multiple keys
            if (cmd.EndsWith("?")) {
                IsQueryRequest = true;
                cmd.Remove(cmd.Length - 1);
            }

            var parts = cmd.Split(',');
            if (parts.Length >= 1) KeyCode = int.Parse(parts[0]);
            if (parts.Length >= 2) State = (EnableState)parts[1][0];

            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (KeyCode.HasValue) {
                sb.Append(KeyCode);
                sb.Append(',');
                if (!IsQueryRequest) sb.Append((char)(int)State);
            }
            if (IsQueryRequest) sb.Append('?');
        }
    }
}