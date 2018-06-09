using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FastColoredTextBoxNS;
using Zektor.Protocol;

namespace Zektor {
    public class ZektorLogger : GenericColorLogger<ZektorCommand> {
        public ZektorLogger() {
            ShowTooltips = true;
        }

        public override void LogColor(ZektorCommand line, bool isIncoming) {
            if (Window == null || Window.IsDisposed || !Window.IsHandleCreated)
                return;

            if (Window.InvokeRequired) {
                Window.BeginInvoke((Action<ZektorCommand, bool>)LogColor, line, isIncoming);
                return;
            }

            if (Window.LinesCount > MaxLineCount)
                Window.Clear();

            PrepareFor(MsgKind.Formatted, isIncoming);

            LineState currentState = LineState.None, nextState = LineState.STX;
            var lineBytes = line.Serialize(false);

            for (int idx = 0; idx < lineBytes.Count; idx++) {
                if (nextState != LineState.None) currentState = nextState;
                nextState = LineState.None;
                byte b = lineBytes[idx];

                if (b == '^') {
                    currentState = LineState.STX;
                    nextState = LineState.Command;
                }
                else if (b == ':') {
                    currentState = LineState.Separator;
                    nextState = LineState.Checksum;
                }
                else if (b == '$') {
                    currentState = LineState.ETX;
                }
                else if (b == '@') {
                    currentState = LineState.Zone;
                }
                else if (currentState == LineState.Command || currentState == LineState.Channel) {
                    if (b == ' ') nextState = LineState.Param;
                    else if (b == '.') {
                        currentState = LineState.Channel;
                    }
                }
                else if (currentState == LineState.Param || currentState == LineState.Zone) {
                    if (b == ',') {
                        currentState = LineState.Separator;
                        nextState = LineState.Param;
                    }
                    else if (b == '%') {
                        currentState = LineState.Prefix;
                        nextState = LineState.Param;
                    }
                    else if (b == '?') {
                        currentState = LineState.Query;
                    }
                }
                
                LogRaw(new string((char)b, 1), Styles[currentState]);
            }
        }

        public override string GetStyleTooltip(Style ts) {
            return Styles.Select(e => (KeyValuePair<LineState, TextStyle>?)e)
                .FirstOrDefault(kvp => kvp.Value.Value.Equals(ts))?.Key.ToString();
        }

        enum LineState {
            STX,
            Command,
            Channel,
            Param,
            Zone,
            Prefix,
            Separator,
            Query,
            Checksum,
            ETX,
            None
        }

        private static readonly Dictionary<LineState, TextStyle> Styles = new Dictionary<LineState, TextStyle> {
            {LineState.STX, new TextStyle(Brushes.DarkBlue, null, FontStyle.Regular)},
            {LineState.Command, new TextStyle(Brushes.BlueViolet, null, FontStyle.Regular)},
            {LineState.Channel, new TextStyle(Brushes.Coral, null, FontStyle.Regular)},
            {LineState.Param, new TextStyle(Brushes.Orange, null, FontStyle.Regular)},
            {LineState.Zone, new TextStyle(Brushes.Red, null, FontStyle.Regular)},
            {LineState.Prefix, new TextStyle(Brushes.Green, null, FontStyle.Regular)},
            {LineState.Separator, new TextStyle(Brushes.Brown, null, FontStyle.Regular)},
            {LineState.Query, new TextStyle(Brushes.CornflowerBlue, null, FontStyle.Regular)},
            {LineState.Checksum, new TextStyle(Brushes.IndianRed, null, FontStyle.Regular)},
            {LineState.ETX, new TextStyle(Brushes.DarkOliveGreen, null, FontStyle.Regular)},
        };
    }
}