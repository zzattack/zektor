using System.Text;

namespace Zektor.Protocol {
    public abstract class ZektorControlCommand : ZektorCommand {
        protected abstract string Command { get; }
        public bool IsQueryResponse { get; protected set; }
        public bool IsQueryRequest { protected get; set; }

        protected override bool Parse(string data) {
            if (data.Length < Command.Length) return false;

            int idx = 0;
            // lines either start with '=' follower by command,
            if (data[0] == '=') {
                IsQueryResponse = true;
                idx++;
            }

            // or lines start directly with command
            if (!data.Substring(idx).StartsWith(Command)) return false;

            idx += Command.Length; // skip command name

            // after command, either a space or '.ch' should follow
            char nextCh = data[idx];
            if (nextCh != '.' && nextCh != ' ') return false;
            

            // most commands have a space directly after the name, if so, skip it
            if (data[idx] == ' ') idx++;

            if (idx > 0)
                data = data.Remove(0, idx);

            return ParseCommand(data);
        }

        protected override string Format() {
            StringBuilder sb = new StringBuilder();
            if (IsQueryResponse) sb.Append('=');
            sb.Append(Command);

            if (this is IHasChannel ich) {
                if (ich.Channels != ChannelBitmap.All)
                    sb.AppendFormat(".{0}", (int)ich.Channels);
            }
            sb.Append(' ');

            FormatCommand(sb);
            return sb.ToString();
        }

        /// <summary>
        /// Format command to StringBuilder.
        /// Do not append '=' for responses.
        /// Do not append Command name or initial space
        /// </summary>
        /// <param name="sb"></param>
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

    public interface IHasChannel {
        ChannelBitmap Channels { get; set; } 
    }
}