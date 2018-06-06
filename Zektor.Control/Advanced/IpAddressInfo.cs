using System.Net;
using System.Text;

namespace Zektor.Protocol.Advanced {
    public class IpAddressInfo : ZektorControlCommand {
        protected override string Command => "IPA";

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
                var bs = IpAddress.GetAddressBytes();
                sb.AppendFormat("{0:d3},{1:d3},{2:d3},{3:d3}", bs[0], bs[1], bs[2], bs[3]);
            }
        }


    }
}