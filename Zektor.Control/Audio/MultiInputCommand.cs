using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zektor.Protocol.Audio {
    public abstract class MultiInputCommand<T> : ZektorControlCommand, IMultiInputCommand {
        public List<(HashSet<int>, T)> Inputs { get; set; } = new List<(HashSet<int>, T)>();

        protected override void FormatCommand(StringBuilder sb) {
            foreach (var input in Inputs) {
                foreach (var inputEntry in input.Item1) {
                    sb.Append('@');
                    sb.Append(inputEntry);
                    sb.Append(',');
                }
                if (!IsQueryRequest) {
                    sb.Append(FormatParam(input.Item2));
                    sb.Append(',');
                }
            }
            if (Inputs.Any())
                sb.Remove(sb.Length - 1, 1); // remove last ,

            if (IsQueryRequest) sb.Append('?');
        }

        protected override bool ParseCommand(string cmd) {
            // remainder is , separated tokens
            string[] parts = cmd.Split(',');

            HashSet<int> inputEntries = new HashSet<int>();
            foreach (string part in parts) {
                if (part[0] == '@') inputEntries.Add(int.Parse(part.Substring(1)));
                else {
                    if (part == "?") {
                        if (!Inputs.Any()) return false; // can only query for one set of zones
                        Inputs.Add((inputEntries, default(T)));
                        IsQueryRequest = true;
                    }
                    else {
                        Inputs.Add((inputEntries, ParseParam(part)));
                    }
                    inputEntries = new HashSet<int>();
                }
            }
            if (inputEntries.Count > 0) {
                // last zone entries list is non-empty
                return false;
            }

            return true;
        }

        protected abstract T ParseParam(string str);
        protected abstract string FormatParam(T param);
        public IEnumerable<int> AffectedInputs {
            get {
                foreach (var inputSet in Inputs) {
                    foreach (var input in inputSet.Item1)
                        yield return input - 1;
                }
            }
        }
    }

    public interface IMultiInputCommand {
        IEnumerable<int> AffectedInputs { get; }
    }
}