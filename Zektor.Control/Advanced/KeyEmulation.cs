using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zektor.Protocol.Advanced {
    using KeyDefinition = ValueTuple<string, int, int>;

    public class KeyEmulation : ZektorControlCommand {
        protected override string Command => "K";
        public List<int> KeyCodes { get; } = new List<int>();
        public static readonly List<KeyDefinition> KeyDefinitions;

        static KeyEmulation() {
            KeyDefinitions = new List<(string, int, int)> { 
                // name, pressed code, released code
                ("1", 1, 43),
                ("2", 2, 44),
                ("3", 3, 45),
                ("4", 4, 46),
                ("5", 5, 47),
                ("6", 6, 48),
                ("7", 7, 49),
                ("8", 8, 50),
                ("Zone 1", 9, 51),
                ("Zone 2", 10, 52),
                ("Zone 3", 11, 53),
                ("Zone 4", 12, 54),
                ("Zone 5", 13, 55),
                ("Zone 6", 14, 56),
                ("Zone 7", 15, 57),
                ("Zone 8", 16, 58),
                ("A/V Toggle", 20, 62),
                ("Power Toggle", 42, 63),
                ("Exit Setup Mode", 0, 0),
            };
        }

        protected override bool ParseCommand(string cmd) {
            if (IsQueryRequest) return cmd.Length == 0;

            var parts = cmd.Split(',');
            foreach (var part in parts)
                KeyCodes.Add(int.Parse(part));

            return true;
        }
        
        protected override void FormatCommand(StringBuilder sb) {
            if (IsQueryRequest) sb.Append('?');
            else {
                foreach (var key in KeyCodes) sb.AppendFormat("{0},", key);
                if (KeyCodes.Any()) sb.Remove(sb.Length - 1, 1); // remove last ','
            }
        }

    }
}