using System.Text;

namespace Zektor.Protocol.Audio {
    public class CompositeConverterSettings : ZektorControlCommand {
        protected override string Command => "CCV";

        public int ConverterIdx { get; set; }
        public VideoInputChannel VideoInput { get; set; }
        public int Contrast { get; set; }
        public int Brightness { get; set; }
        public int Saturation { get; set; }
        public int Hue { get; set; }


        protected override void FormatCommand(StringBuilder sb) {
            sb.AppendFormat("{0}", ConverterIdx);
            if (IsQueryRequest) {
                sb.Append('?');
            }
            else {
                sb.AppendFormat(",{0}", (int)VideoInput);
                sb.AppendFormat(",{0}", Contrast);
                sb.AppendFormat(",{0}", Brightness);
                sb.AppendFormat(",{0}", Saturation);
                sb.AppendFormat(",{0}", Hue);
            }
        }

        protected override bool ParseCommand(string cmd) {
            string[] parts = cmd.Split(',');
            if (parts.Length != 6) return false;
            ConverterIdx = int.Parse(parts[0]);
            VideoInput = (VideoInputChannel)int.Parse(parts[1]);
            Contrast = int.Parse(parts[2]);
            Brightness = int.Parse(parts[3]);
            Saturation = int.Parse(parts[4]);
            Hue = int.Parse(parts[5]);
            return true;
        }
    }
}