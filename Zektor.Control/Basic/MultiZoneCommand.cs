using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zektor.Control.Basic {
    /// <summary>
    /// Many commands take a number of zones and some specific kind of parameter.
    /// This can serve as base class for parsing and formatting such commands.
    /// </summary>
    /// <typeparam name="T">The specific type of parameter for inheriting commands.</typeparam>
    /// 
    public abstract class MultiZoneCommand<T> : ZektorControlCommand {
        public List<(HashSet<int>, T)> Zones = new List<(HashSet<int>, T)>();
        public ChannelBitmap Channels = ChannelBitmap.All;

        protected override bool ParseCommand(string cmd) {
            Channels = ConsumeChannel(ref cmd);

            // remainder is , separated tokens
            string[] parts = cmd.Split(',');

            HashSet<int> zoneEntries = new HashSet<int>();
            foreach (string part in parts) {
                if (part[0] == '@') zoneEntries.Add(int.Parse(part.Substring(1)));
                else {
                    if (part == "?") {
                        if (Zones.Count != 0) return false; // can only query for one set of zones
                        Zones.Add((zoneEntries, default(T)));
                        IsQueryRequest = true;
                    }
                    else {
                        T param = ParseParam(part);
                        this.Zones.Add((zoneEntries, param));
                    }
                    zoneEntries = new HashSet<int>();
                }
            }
            if (zoneEntries.Count > 0) {
                // last zone entries list is non-empty
                return false;
            }

            return true;
        }

        protected override void FormatCommand(StringBuilder sb) {
            if (Channels != ChannelBitmap.All)
                sb.AppendFormat(".{0}", (int)Channels);

            foreach (var zone in Zones) {
                foreach (var zoneEntry in zone.Item1) {
                    sb.Append('@');
                    sb.Append(zoneEntry);
                    sb.Append(',');
                }
                if (!IsQueryRequest) {
                    sb.Append(FormatParam(zone.Item2));
                    sb.Append(',');
                }
            }
            if (Zones.Any())
                sb.Remove(sb.Length - 1, 1); // remove last ,

            if (IsQueryRequest) sb.Append('?');
        }

        protected abstract T ParseParam(string str);
        protected abstract string FormatParam(T param);

        public void MakeSimple(int zone, T param) {
            Zones.Clear();
            Zones.Add(  (new HashSet<int> { zone }, param)  );
        }
    }
}