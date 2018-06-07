using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using NLog;
using Zektor.Shared.Protocol;
using Zektor.Shared.Utility;

namespace Zektor.Shared.DataSources {
    using TaskCompletionTest = Func<List<byte>, bool>;

    public class SynchronizedMessageExchanger<T> where T : DataLine {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        protected readonly DataProtocol<T> _proto;

        public SynchronizedMessageExchanger(DataProtocol<T> proto) {
            _proto = proto;
        }

        public T ExchangeLine(T msg, TimeSpan timeout, Func<List<byte>, bool> completionTest = null) {
            // prepare task
            var tcs = PrepareTask();

            // scope receiver variable and attach to ourselves
            var receivedLine = default(T);
            EventHandler<LineTransmitEventArgs<T>> handler = (sender, args) => {
                receivedLine = args.Line;
                // call this too so the waiting task has its result set
                OnDataReceived(sender, new DataReceivedEventArgs(args.Line.Serialize()));
                _dataReceivedTaskRefresher.Set();
            };
            _proto.LineReceived += handler;

            // we'll be done once the list is set in the handler above
            if (completionTest == null)
                completionTest = list => receivedLine != null;
            else
                _proto.Expect(completionTest);

            // write the message
            _proto.Write(msg);

            // wait for eventual replies
            var response = WaitForTaskCompletion(tcs, timeout, completionTest);

            _proto.Expect(null);

            // if no reply, try to obtain a line with the completionTest lifted
            if (response == null || response.Count == 0)
                _proto.ForceDispatch();

            _proto.LineReceived -= handler;
            return receivedLine;
        }

        public List<byte> ExchangeData(T msgToWrite, TimeSpan timeout, TaskCompletionTest readyTest) {
            // Debug.WriteLine("-------------------------------------------------");
            // prepare task
            var tcs = PrepareTask();

            _proto.BogusReceived += OnDataReceived;

            // write the message
            _proto.BogusOnly();
            _proto.ClearBogus();
            _proto.Write(msgToWrite);

            // wait for eventual replies
            var response = WaitForTaskCompletion(tcs, timeout, readyTest);
            _proto.EndBogusOnly();

            _proto.BogusReceived -= OnDataReceived;

            return response;
        }

        #region synchronized command exchange

        protected virtual void OnDataReceived(object o, DataReceivedEventArgs args) {
            var refreshTask = false;
            lock (_receivedTaskLock) {
                if (_dataReceivedTask != null) {
                    _dataReceivedTaskRefresher.Reset();
                    _dataReceivedTask.SetResult(args);
                    _dataReceivedTask = null;
                    refreshTask = true;
                    // Util.DebugLog("(Partial) task response: " + Util.ByteArrayToHexString(args.Data) + " - " + Encoding.Default.GetString(args.Data));
                }
            }

            // before requesting a task refresh we must give up its lock
            if (refreshTask) {
                // Util.DebugLog("Task consumed, waiting for refresh");
                _dataReceivedTaskRefresher.WaitOne(100);
                // lock (_receivedTaskLock)
                //     Util.DebugLog("Task refreshed: {0}", _dataReceivedTask != null ? "yes" : "no");
            }
        }

        protected TaskCompletionSource<DataReceivedEventArgs> _dataReceivedTask;
        protected readonly ManualResetEvent _dataReceivedTaskRefresher = new ManualResetEvent(false);
        protected readonly object _receivedTaskLock = new object();

        public TaskCompletionSource<DataReceivedEventArgs> PrepareTask() {
            // prepare a task to hold any replies
            var tcs = new TaskCompletionSource<DataReceivedEventArgs>();
            lock (_receivedTaskLock) {
                _dataReceivedTask = tcs;
            }

            _dataReceivedTaskRefresher.Set();
            return tcs;
        }

        public List<byte> WaitForTaskCompletion(TaskCompletionSource<DataReceivedEventArgs> tcs, TimeSpan timeout, TaskCompletionTest test) {
            // wait for eventual replies
            var sw = Stopwatch.StartNew();
            var response = new List<byte>();

            while (true) {
                bool taskSuccess = tcs.Task.Wait(timeout);
                if (!taskSuccess && sw.Elapsed >= timeout)
                    break;

                if (taskSuccess)
                    response.AddRange(tcs.Task.Result.Data);

                // test if we have all data we wanted (or any other test completion encoded in "test");
                if (test(response))
                    break;

                // we need more data, refresh task
                tcs = PrepareTask();
            }

            _logger.Trace("Task ran to completion; response: {0}", Util.ByteArrayToHexString(response));

            // signal the waiting receiver thread: it waits for us to 
            // decide whether or not we want more data
            lock (_receivedTaskLock) {
                _dataReceivedTask = null; // if it failed, make sure task isn't completed again
            }

            _dataReceivedTaskRefresher.Set();

            return response;
        }

        #endregion
    }
}