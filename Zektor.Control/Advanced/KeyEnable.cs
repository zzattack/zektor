using System.Text;

namespace Zektor.Control.Advanced {
    public class KeyEnable : ZektorControlCommand {
        public override string Command => "KE";
        public KeyEnableState State { get; set; } = KeyEnableState.None;
        public int? KeyCode { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0; // after '?' no data should follow

            // query commands may have data in front of them for multiple keys
            if (cmd.EndsWith("?")) {
                IsQueryRequest = true;
                cmd.Remove(cmd.Length - 1);
            }

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