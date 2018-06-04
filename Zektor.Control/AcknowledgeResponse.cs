using System.Collections.Generic;

namespace Zektor.Control {
    public class AcknowledgeResponse : ZektorCommand {
        public override bool Parse(List<byte> data) {
            return data.Count == 1 && data[0] == '+';
        }
        protected override string FormatLine() {
            return "+";
        }
    }
}