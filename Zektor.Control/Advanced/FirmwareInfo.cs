using System.Text;

namespace Zektor.Protocol.Advanced {
    public class FirmwareInfo : ZektorControlCommand {
        protected override string Command => "V";
        public string Model { get; set; }
        public string FirmwareVersion { get; set; }
        public string SerialNumber { get; set; }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;

            var parts = cmd.Split(',');
            if (parts.Length != 3) return false;
            Model = parts[0];
            FirmwareVersion = parts[1];
            SerialNumber = parts[2];
            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else {
                sb.Append(Model);
                sb.Append(',');
                sb.Append(FirmwareVersion);
                sb.Append(',');
                sb.Append(SerialNumber);
            }
        }


    }
}