using System;
using System.Collections.Generic;
using System.Linq;
using Zektor.Shared.DataSources;

namespace Zektor.Shared.Protocol {
    public interface IDataLine {
        List<byte> Serialize(bool escape = true);
        bool Parse(List<byte> data);
    }

    public abstract class DataLine : IDataLine {
        public abstract List<byte> Serialize(bool escape = true);
        public abstract bool Parse(List<byte> data);

        /// <summary>
        ///     Escapes all occurrences of characters in 'escapeBytes'.
        ///     These are PREFIXED with 'escaper'.
        /// </summary>
        public static List<byte> Escape(IEnumerable<byte> escapeBytes, byte escaper, IList<byte> input, int start = 0) {
            return Escape(escapeBytes, escaper, input, start, input.Count - start);
        }

        public static List<byte> Escape(IEnumerable<byte> escapeBytes, byte escaper, IList<byte> input, int start, int length) {
            var ret = new List<byte>();
            for (var i = 0; i < start; i++)
                ret.Add(input[i]);
            for (int i = start; i < start + length; i++) {
                if (escapeBytes.Contains(input[i]))
                    ret.Add(escaper);
                ret.Add(input[i]);
            }

            for (int i = start + length; i < input.Count; i++)
                ret.Add(input[i]);
            return ret;
        }

        public static List<byte> SafeUnescape(byte escaper, IEnumerable<byte> escapeBytes, IList<byte> input) {
            return SafeUnescape(escaper, escapeBytes, input, 0, input.Count - 0);
        }

        public static List<byte> SafeUnescape(byte escaper, IEnumerable<byte> escapeBytes, IList<byte> input, int start, int length) {
            var ret = new List<byte>();
            for (var i = 0; i < start; i++)
                ret.Add(input[i]);

            for (int i = start; i < start + length; i++) {
                if (input[i] == escaper)
                    if (i + 1 < input.Count && escapeBytes.Contains(input[i + 1]))
                        i++;
                ret.Add(input[i]);
            }

            return ret;
        }
    }

    public class LineTransmitEventArgs<T> : EventArgs where T : DataLine {
        public readonly T Line;

        public LineTransmitEventArgs(T line) {
            Line = line;
        }
    }

    public interface IDataProtocol<T> where T : IDataLine {
        void Attach(DataSource dataSource);
        void Detach();
        event EventHandler<DataReceivedEventArgs> BogusReceived;

        event EventHandler<DataReceivedEventArgs> BogusSent;
        // event EventHandler<LineTransmitEventArgs<T>> LineReceived;
        // event EventHandler<LineTransmitEventArgs<T>> LineSent;
    }

    public abstract class DataProtocol<T> : IDataProtocol<IDataLine>, IDisposable where T : DataLine {
        protected readonly List<byte> _buffer = new List<byte>();

        // signals the protocol that the NEXT line can only complete once completiontest finishes
        private volatile Func<List<byte>, bool> _completionTest;
        public DataSource DataSource { get; set; }
        public event EventHandler<DataReceivedEventArgs> BogusReceived;
        public event EventHandler<DataReceivedEventArgs> BogusSent;

        public virtual void Attach(DataSource dataSource) {
            Detach();
            DataSource = dataSource;
            if (DataSource != null) {
                DataSource.DataReceived -= ForwardToBufferHandler;
                DataSource.DataReceived += ForwardToBufferHandler;
                //if (DataSource is TcpServerDataSource) {
                //   throw new ArgumentException("bad idea, attach me to spawned TcpClient on TcpServer datasource instead");
                //}
            }
        }

        public virtual void Detach() {
            if (DataSource != null) {
                DataSource.DataReceived -= ForwardToBufferHandler;
                DataSource = null;
            }
        }

        public virtual void Dispose() { }
        public event EventHandler<LineTransmitEventArgs<T>> LineReceived;
        public event EventHandler<LineTransmitEventArgs<T>> LineSent;

        protected abstract void AddToBuffer(DataSource o, DataReceivedEventArgs e);

        /// <summary>
        ///     Dispatch current buffer contents
        /// </summary>
        /// <returns></returns>
        protected virtual void Dispatch() {
            if (Dispatch(_buffer))
                _buffer.Clear();
        }

        /// <summary>
        /// </summary>
        /// <param name="data"></param>
        /// <returns>whether internal buffer should be cleared</returns>
        protected virtual bool Dispatch(IEnumerable<byte> data) {
            var line = Activator.CreateInstance<T>();
            var bytes = data.ToList();
            if (line.Parse(bytes.ToList())) {
                if (_completionTest == null || _completionTest(bytes.ToList()))
                    OnLineReceived(line);
                else if (_completionTest != null)
                    return false;
            }
            else {
                OnBogusReceived(bytes.ToList());
            }

            return true;
        }

        /// <summary>
        ///     Forces an attempt to parse the internal buffer as Tline
        /// </summary>
        internal void ForceDispatch() {
            Dispatch(_buffer);
            _buffer.Clear();
        }

        protected void ForwardToBufferHandler(object sender, DataReceivedEventArgs e) {
            AddToBuffer(sender as DataSource, e);
        }

        public virtual bool Write(T line) {
            if (DataSource is WritableDataSource)
                if ((DataSource as WritableDataSource).Write(line.Serialize(true).ToArray())) {
                    OnLineSent(line);
                    return true;
                }

            return false;
        }

        public bool Write(IEnumerable<byte> data, bool parseValidate = true) {
            if (!(DataSource is WritableDataSource)) return false;

            (DataSource as WritableDataSource).Write(data.ToArray());

            if (parseValidate) {
                // see if line can be parsed
                var line = Activator.CreateInstance<T>();
                if (!line.Parse(data.ToList())) {
                    OnBogusSent(data);
                    return false;
                }

                OnLineSent(line);
            }
            else {
                OnBogusSent(data);
            }

            return true;
        }

        protected virtual void OnLineReceived(T line) {
            if (LineReceived != null)
                LineReceived(this, new LineTransmitEventArgs<T>(line));
        }

        protected virtual void OnLineSent(T line) {
            if (LineSent != null)
                LineSent(this, new LineTransmitEventArgs<T>(line));
        }

        protected virtual void OnBogusReceived(IEnumerable<byte> data) {
            if (BogusReceived != null)
                BogusReceived(this, new DataReceivedEventArgs(data.ToArray()));
        }

        protected virtual void OnBogusSent(IEnumerable<byte> data) {
            if (BogusSent != null)
                BogusSent(this, new DataReceivedEventArgs(data.ToArray()));
        }

        public T ExchangeLine(T msg, TimeSpan timeout) {
            var exchange = new SynchronizedMessageExchanger<T>(this);
            return exchange.ExchangeLine(msg, timeout);
        }

        public List<byte> ExchangeData(T msg, TimeSpan timeout, Func<List<byte>, bool> test) {
            var exchange = new SynchronizedMessageExchanger<T>(this);
            return exchange.ExchangeData(msg, timeout, test);
        }

        internal void Expect(Func<List<byte>, bool> test) {
            _completionTest = test;
        }

        #region bogus handling for crazy hacks, i.e. receiving a "FF FF FF" response from receiver FF FF in RPD proto

        public void ClearBogus() {
            _buffer.Clear();
        }

        private bool _bogusOnly;

        internal void BogusOnly() {
            _bogusOnly = true;
            DataSource.DataReceived -= ForwardToBufferHandler;
            DataSource.DataReceived -= BogusHandler;
            DataSource.DataReceived += BogusHandler;
        }

        internal void EndBogusOnly() {
            _bogusOnly = false;
            DataSource.DataReceived -= ForwardToBufferHandler;
            DataSource.DataReceived += ForwardToBufferHandler;
            DataSource.DataReceived -= BogusHandler;
        }

        private void BogusHandler(object o, DataReceivedEventArgs e) {
            if (_bogusOnly)
                OnBogusReceived(e.Data);
        }

        #endregion
    }
}