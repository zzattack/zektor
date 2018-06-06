namespace Zektor.Protocol {
    public class AcknowledgeResponse : ZektorCommand {
        protected override bool Parse(string data) {
            return data.Length == 1 && data[0] == '+';
        }
        protected override string Format() {
            return "+";
        }
    }
}