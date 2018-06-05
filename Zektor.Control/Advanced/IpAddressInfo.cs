using System.Net;
using System.Text;

namespace Zektor.Control.Advanced {
    public class IpAddressInfo : ZektorControlCommand {
        public override string Command => "IPA";

        public System.Net.IPAddress IpAddress { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;
            var parts = cmd.Split(',');
            if (parts.Length != 4) return false;
            IpAddress = new IPAddress(new[] {
                byte.Parse(parts[0]),
                byte.Parse(parts[1]),
                byte.Parse(parts[2]),
                byte.Parse(parts[3])
            });
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) {
                sb.Append('?');
            }
            else {
                sb.Append(IpAddress);
            }
        }


    }
}