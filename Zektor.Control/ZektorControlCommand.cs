using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zektor.Control {
    public abstract class ZektorControlCommand : ZektorCommand {
        public abstract string Command { get; }
        public bool IsQueryResponse { get; set; }
        public bool IsQueryRequest { get; set; }
        public override bool Parse(List<byte> data) {
            if (data.Count < Command.Length) return false;

            int idx = 0;
            // lines either start with '=' follower by command,
            if (data[0] == '=') {
                idx++;
                IsQueryResponse = true;
            }

            // or lines start directly with command
            var bs = Encoding.ASCII.GetBytes(Command);
            if (!bs.SequenceEqual(data.Skip(idx).Take(bs.Length))) return false;

            idx += bs.Length; // skip command name

            // most commands have a space directly after the name, if so, skip it
            if (data[idx] == ' ') idx++;

            string cmd = Encoding.Default.GetString(data.ToArray(), idx, data.Count - idx);
            return ParseCommand(cmd);
        }

        protected override string FormatLine() {
            StringBuilder sb = new StringBuilder();
            if (IsQueryResponse) sb.Append('=');
            sb.Append(Command);
            sb.Append(' ');

            FormatCommand(sb);
            return sb.ToString();
        }

        protected abstract void FormatCommand(StringBuilder sb);
        /// <summary>
        /// Parse command from string.
        /// Prefix and (optional) '=' prefix are already stripped.
        /// </summary>
        /// <param name="cmd"></param>
        protected abstract bool ParseCommand(string cmd);


        protected static ChannelBitmap ConsumeChannel(ref string cmd) {
            ChannelBitmap ret = ChannelBitmap.All;
            // if first character is a '.' then the channel follows next as 3-digit number
            if (cmd[0] == '.') {
                ret = (ChannelBitmap)int.Parse(cmd.Substring(1, 3));
                cmd = cmd.Substring(5);
            }

            return ret;
        }

    }
}