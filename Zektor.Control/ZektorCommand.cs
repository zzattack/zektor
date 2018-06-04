using System.Collections.Generic;
using System.Text;
using SPAA05.Shared.Protocol;

namespace Zektor.Control {
	public abstract class ZektorCommand : DataLine {
        public override List<byte> Serialize(bool escape = true) {
            var ret = new List<byte>();
            ret.Add(ZektorProtocol.STX);
            ret.AddRange(Encoding.ASCII.GetBytes(FormatLine()));
            ret.Add(ZektorProtocol.ETX);
            return ret;
        }

        protected abstract string FormatLine();
    }
}
