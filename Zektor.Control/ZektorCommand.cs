using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Zektor.Shared.Protocol;

namespace Zektor.Protocol {
	public abstract class ZektorCommand : DataLine {
        internal bool HasChecksum { get; set; }

        public override List<byte> Serialize(bool escape = true) {
            var ret = new List<byte>();
            ret.Add(ZektorProtocol.STX);
            ret.AddRange(Encoding.ASCII.GetBytes(Format()));

            if (HasChecksum) {
                ret.Add((byte)':');
                // when transmitting, the '^' STX is not part of checksum
                byte cks = CalcChecksum(ret, 1, ret.Count - 1);
                ret.AddRange(Encoding.ASCII.GetBytes(cks.ToString("d3")));
            }

            ret.Add(ZektorProtocol.ETX);
            return ret;
        }

        private static Regex reCksEnd = new Regex(@":\d{1,3}$");

        public sealed override bool Parse(List<byte> data) {
            // see if there's a checksum, if so, verify it
            string str = Encoding.ASCII.GetString(data.ToArray());
            if (reCksEnd.IsMatch(str)) {
                int idx = str.LastIndexOf(":");
                int cks = int.Parse(str.Substring(idx + 1));
                str = str.Substring(0, idx);

                // when receiving, the '^' STX _is_ part of checksum
                byte cksCalc = CalcChecksum(data, 0, idx + 1);
                cksCalc += (byte)'^';
                if (cks != cksCalc)
                    return false;

                HasChecksum = true;
            }

            return Parse(str);
        }
        private static byte CalcChecksum(IList<byte> data, int idx, int count) {
            unchecked {
                byte sum = 0;
                for (int i = idx; i < idx + count; i++) sum += data[i];
                return sum;
            }
        }

        protected abstract bool Parse(string data);

        protected abstract string Format();
    }
}
