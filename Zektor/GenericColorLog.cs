using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using FastColoredTextBoxNS;
using Zektor.Shared.Protocol;
using Zektor.Shared.Utility;
using DataReceivedEventArgs = Zektor.Shared.DataSources.DataReceivedEventArgs;

namespace Zektor {

	public enum LogMsgType { Incoming, Outgoing, Info, Warning, Error, Success };
	public enum TimeFormat { None, ProgramTime, LocalTime };

	public interface IProtocolLogger {
		FastColoredTextBox Window { get; set; }
    }
    public interface IProtocolLogger<in T> : IProtocolLogger where T : DataLine {
        void LogColor(T line, bool isIncoming);
    }

    public interface IAttachingLogger {
        object AttachedProto { get; }
    }
    public interface IAttachingLogger<in T> : IAttachingLogger where T : IDataLine {
        new IDataProtocol<T> AttachedProto { get; }
    }
    public class GenericLogger {
		public virtual FastColoredTextBox Window { get; set; }
    }
    public interface IConfigurableLogger {
        bool ShowBogus { get; set; }
        bool ShowLines { get; set; }
        bool ShowTooltips { get; set; }
        TimeFormat ShowTime { get; set; }
        bool ForceASCII { get; set; }
        bool ForceHEX { get; set; }
    }

    public class GenericColorLogger<T> : GenericLogger, IProtocolLogger<T>, IAttachingLogger<T>, IConfigurableLogger where T : DataLine {
        protected TextStyle CurrentStyle;

        protected MsgKind LastMsgKind;
        public bool LastIsIncoming;
        private DataProtocol<T> _attachedProto;
        public bool ShowBogus { get; set; }
        public bool ShowLines { get; set; }
        public bool ShowTooltips { get; set; }
        public TimeFormat ShowTime { get; set; }
        public virtual bool ForceASCII { get; set; }
        public virtual bool ForceHEX { get; set; }
        public bool HideOutgoing { get; set; }
        public bool HideIncoming { get; set; }

        public virtual int MaxLineCount => 3000;

        private static Stopwatch _sw = Stopwatch.StartNew();

        public GenericColorLogger() {
            ShowBogus = false;
            ShowLines = true;
            ShowTime = TimeFormat.None;
            CurrentStyle = InfoStyle;
        }

        public IDataProtocol<T> AttachedProto => _attachedProto;
        object IAttachingLogger.AttachedProto => _attachedProto;

        public void Attach(DataProtocol<T> proto) {
            Detach();
            if (_attachedProto != proto) {
                _attachedProto = proto;
                proto.BogusReceived += OnAttachedProtoOnBogusReceived;
                proto.BogusSent += OnAttachedProtoOnBogusSent;
                proto.LineReceived += OnAttachedProtoOnLineReceived;
                proto.LineSent += OnAttachedProtoOnLineSent;
            }
        }
        public void Detach() {
            if (_attachedProto == null)
                return;
            _attachedProto.BogusReceived -= OnAttachedProtoOnBogusReceived;
            _attachedProto.BogusSent -= OnAttachedProtoOnBogusSent;
            _attachedProto.LineReceived -= OnAttachedProtoOnLineReceived;
            _attachedProto.LineSent -= OnAttachedProtoOnLineSent;
            _attachedProto = null;
        }

        private void OnAttachedProtoOnLineSent(object sender, LineTransmitEventArgs<T> args) {
            if (ShowLines && !HideOutgoing && Window != null && Window.IsHandleCreated && !Window.IsDisposed) {
                if (Window.InvokeRequired)
                    // ensure it's queued
                    Window.BeginInvoke((Action<T, bool>)LogColor, args.Line, false);
                else
                    LogColor(args.Line, false);
            }
        }
        private void OnAttachedProtoOnLineReceived(object sender, LineTransmitEventArgs<T> args) {
            if (ShowLines && !HideIncoming && Window != null && Window.IsHandleCreated && !Window.IsDisposed) {
                if (Window.InvokeRequired)
                    // ensure it's queued
                    Window.BeginInvoke((Action<T, bool>)LogColor, args.Line, true);
                else
                    LogColor(args.Line, true);
            }
        }
        private void OnAttachedProtoOnBogusSent(object sender, DataReceivedEventArgs args) {
            if (ShowBogus && Window != null && Window.IsHandleCreated && !Window.IsDisposed) {
                if (Window.InvokeRequired)
                    // ensure it's queued
                    Window.BeginInvoke((Action<IEnumerable<byte>, bool, bool>)LogData, args.Data, false, true);
                else
                    LogData(args.Data, false, true);
            }
        }
        private void OnAttachedProtoOnBogusReceived(object sender, DataReceivedEventArgs args) {
            if (ShowBogus)
                LogData(args.Data, true);
        }

        /// <summary>
        /// Adds the necessary newlines and direction indicators
        /// </summary>
        /// <param name="isIncoming">Direction of logged data</param>
        protected void PrepareFor(MsgKind msgKind, bool isIncoming) {
            bool direction =
                (msgKind == MsgKind.Formatted) ||
                (msgKind == MsgKind.Data && (isIncoming != LastIsIncoming || LastMsgKind != MsgKind.Data));

            bool newline = (ShowTime != TimeFormat.None ||
                (msgKind == MsgKind.Data && (isIncoming != LastIsIncoming || LastMsgKind != MsgKind.Data)) ||
                (msgKind == MsgKind.Text) ||
                (msgKind == MsgKind.Formatted))
                && (Window.LinesCount > 1 || Window.Text.Length > 0); // lines count is much faster to check, but invalid first time

            var msg = new StringBuilder();
            if (newline)
                msg.AppendLine();

            if (ShowTime == TimeFormat.ProgramTime) {
                msg.AppendFormat("{0}:{1:D2}:{2:D2}.{3:D3} ", (int)_sw.Elapsed.TotalHours, _sw.Elapsed.Minutes, _sw.Elapsed.Seconds, (int)_sw.Elapsed.Milliseconds);
            }
            else if (ShowTime == TimeFormat.LocalTime) {
                var now = DateTime.Now.TimeOfDay;
                msg.AppendFormat("[{0}] ", now.ToString());
            }
            if (direction) {
                msg.Append(" ");
                msg.Append(isIncoming ? "<<" : ">>");
                msg.Append(" ");
            }

            TextStyle style = isIncoming ? IncomingStyle : OutGoingStyle;
            LogRaw(msg.ToString(), style, false);
            LastIsIncoming = isIncoming;
            LastMsgKind = msgKind;
        }
        protected enum MsgKind {
            Formatted,
            Data,
            Text
        }


        public virtual void LogColor(T line, bool isIncoming) {
            if (Window == null || Window.IsDisposed || !Window.IsHandleCreated)
                return;

            if (Window.InvokeRequired) {
                Window.BeginInvoke((Action<T, bool>)LogColor, line, isIncoming);
                return;
            }
            Window.BeginUpdate();

            if (Window.LinesCount > MaxLineCount)
                Window.Clear();

            PrepareFor(MsgKind.Formatted, isIncoming);
            
            var lineBytes = line.Serialize(false);
            for (int idx = 0; idx < lineBytes.Count; idx++) {
                byte b = lineBytes[idx];
                LogRaw(b.ToString("X2") + " ", BrownStyle);
            }

            Window.EndUpdate();
        }

        public virtual IReadOnlyDictionary<object, TextStyle> StyleSet => new Dictionary<object, TextStyle>();

        public virtual void LogData(IEnumerable<byte> data, bool isIncoming, bool doScroll = true) {
			if (Window.InvokeRequired) {
				Window.BeginInvoke((Action<bool, IEnumerable<byte>>)((isIncoming1, data1) => LogData(data1, isIncoming1)), isIncoming, data);
			}
			else if (!Window.IsDisposed && Window.IsHandleCreated) {
				bool ascii = (!ForceHEX && ForceASCII) || data.Any() && data.Count(c => 
					('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z') || (' ' <= c && c <= '9') || @"!@#$%^&*()-=+_{}[]/\?.,:;'|\r\n" .Contains(c.ToString()))
					/ (double)data.Count() > 0.90;
				PrepareFor(MsgKind.Data, isIncoming);
				var msgType = isIncoming ? LogMsgType.Incoming : LogMsgType.Outgoing;
				string msg = ascii ? Encoding.Default.GetString(data.ToArray()) : Util.ByteArrayToHexString(data);
				LogRaw(msg, Styles[(int)msgType], doScroll);
			}
		}
		public void LogText(string text, LogMsgType msgType, bool doScroll = true) {
			if (Window.InvokeRequired) {
				Window.BeginInvoke((Action<string, LogMsgType, bool>)LogText, text, msgType, doScroll);
			}
			else if (!Window.IsDisposed && Window.IsHandleCreated) {
				PrepareFor(MsgKind.Text, msgType == LogMsgType.Incoming);
				LogRaw(text, Styles[(int)msgType], doScroll);
			}
		}

		protected void LogRaw(string text, TextStyle style, bool doScroll = true) {
			if (Window.InvokeRequired) {
				Window.BeginInvoke((Action<string, TextStyle, bool>)LogRaw, text, style, doScroll);
			}
			else if (!Window.IsDisposed && Window.IsHandleCreated) {
				// some stuffs for best performance
				Window.BeginUpdate();
				
				if (Window.LinesCount > MaxLineCount)
					Window.Clear();
				if (Window.LinesCount > 0 && Window.Lines[Window.LinesCount - 1].Length > 800)
					Window.AppendText("\r\n");

				if (doScroll)
					Window.Selection.BeginUpdate();

				FastColoredTextBoxNS.Range oldSelection = null;
				//remember user selection
				if (doScroll && !IsScrolledToEnd)
					oldSelection = Window.Selection.Clone();

				//add text with predefined style
				Window.AppendText(text, style);

				if (doScroll) {
					if (oldSelection == null)
						Window.GoEnd();
					else {
						Window.Selection.Start = oldSelection.Start;
						Window.Selection.End = oldSelection.End;
					}
					Window.Selection.EndUpdate();
				}

				Window.EndUpdate();
			}
        }

        public static readonly TextStyle IncomingStyle = new TextStyle(Brushes.DarkOliveGreen, null, FontStyle.Regular);
        public static readonly TextStyle OutGoingStyle = new TextStyle(Brushes.Brown, null, FontStyle.Regular);
        public static readonly TextStyle InfoStyle = new TextStyle(Brushes.Navy, null, FontStyle.Regular);
        public static readonly TextStyle WarningStyle = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
        public static readonly TextStyle ErrorStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        public static readonly TextStyle SuccessStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
        public static readonly TextStyle NormalStyle = new TextStyle(Brushes.Black, null, FontStyle.Regular);
        private static TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Regular);
        private static readonly TextStyle[] Styles = { IncomingStyle, OutGoingStyle, InfoStyle, WarningStyle, ErrorStyle, SuccessStyle };
        
        protected bool IsScrolledToEnd {
			get {
				var userSelection = Window.Selection.Clone();
				return userSelection.IsEmpty && userSelection.Start.iLine >= Window.LinesCount - 2;
			}
		}

        public override FastColoredTextBox Window {
            get => base.Window;
            set {
                if (base.Window != null)
                    base.Window.ToolTipNeeded -= OnTooltipNeeded;

                base.Window = value;

                if (value != null)
                    value.ToolTipNeeded += OnTooltipNeeded;
            }
        }

        public virtual string GetStyleTooltip(Style ts) { return null; }

        protected virtual void OnTooltipNeeded(object sender, ToolTipNeededEventArgs args) {
            var appliedStyles = Window.GetStylesOfChar(args.Place);
            foreach (var st in appliedStyles) {
                string txt = GetStyleTooltip(st);
                args.ToolTipText = txt;
                if (txt != null) return;
            }
        }
    }
}