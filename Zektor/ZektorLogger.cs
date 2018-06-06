using System;
using System.Collections.Generic;
using System.Drawing;
using FastColoredTextBoxNS;
using SPAA05.Shared.UI.ColorLoggers;
using Zektor.Protocol;

namespace Zektor {
    public class ZektorLogger : GenericColorLogger<ZektorCommand> {

        public override void LogColor(ZektorCommand line, bool isIncoming) {
            if (Window == null || Window.IsDisposed || !Window.IsHandleCreated)
                return;

            if (Window.InvokeRequired) {
                Window.BeginInvoke((Action<ZektorCommand, bool>)LogColor, line, isIncoming);
                return;
            }
            Window.BeginUpdate();

            if (Window.LinesCount > MaxLineCount)
                Window.Clear();

            PrepareFor(MsgKind.Formatted, isIncoming);

            LineState currentState = LineState.None, nextState = LineState.STX;
            var lineBytes = line.Serialize(false);

            for (int idx = 0; idx < lineBytes.Count; idx++) {
                if (nextState != LineState.None) currentState = nextState;
                byte b = lineBytes[idx];

                if (currentState == LineState.STX) {
                    nextState = LineState.Command;
                }
                else if (currentState == LineState.Command) {
                    if (b == ' ') nextState = LineState.Param;
                }
                else if (currentState == LineState.Param) {
                    if (b == ',') {
                        currentState = LineState.Separator;
                        nextState = LineState.Param;
                    }
                    else if (b == '%' || b == '@') {
                        currentState = LineState.Prefix;
                        nextState = LineState.Param;
                    }
                    else if (b == '?') {
                        currentState = LineState.Query;
                    }
                }
                else if (b == ':') {
                    currentState = LineState.Separator;
                    nextState = LineState.Checksum;
                }
                if (b == '$') {
                    currentState = LineState.ETX;
                }
                LogRaw(new string((char)b, 1), _styles[currentState]);
            }

            Window.EndUpdate();
        }


        enum LineState {
            STX,
            Command,
            Param,
            Prefix,
            Separator,
            Query,
            Checksum,
            ETX,
            None
        }

        private static readonly Dictionary<LineState, TextStyle> _styles = new Dictionary<LineState, TextStyle> {
            {LineState.STX, new TextStyle(Brushes.DarkBlue, null, FontStyle.Regular)},
            {LineState.Command, new TextStyle(Brushes.BlueViolet, null, FontStyle.Regular)},
            {LineState.Param, new TextStyle(Brushes.Red, null, FontStyle.Regular)},
            {LineState.Prefix, new TextStyle(Brushes.Orange, null, FontStyle.Regular)},
            {LineState.Separator, new TextStyle(Brushes.Brown, null, FontStyle.Regular)},
            {LineState.Query, new TextStyle(Brushes.CornflowerBlue, null, FontStyle.Regular)},
            {LineState.Checksum, new TextStyle(Brushes.IndianRed, null, FontStyle.Regular)},
            {LineState.ETX, new TextStyle(Brushes.Green, null, FontStyle.Regular)},
        };
    }
}