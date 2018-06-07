using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace Zektor.Shared.DataSources {
    using TaskCompletionTest = Func<List<byte>, bool>;

    public static class TaskCompletionTests {
        public static Func<List<byte>, bool> MakeTimeoutTest(int timeout) {
            var sw = Stopwatch.StartNew();
            return rcvd => sw.ElapsedMilliseconds >= timeout;
        }

        public static Func<List<byte>, bool> MakeSubstringTest(string expectedSubstring) {
            return rcvd => Encoding.Default.GetString(rcvd.ToArray()).Contains(expectedSubstring);
        }

        public static Func<List<byte>, bool> MakeNumBytesExpectedTest(int numBytesExpected) {
            return rcvd => rcvd.Count >= numBytesExpected;
        }

        public static Func<List<byte>, bool> MakeRegexTest(Regex r) {
            return rcvd => r.IsMatch(Encoding.Default.GetString(rcvd.ToArray()));
        }

        public static Func<List<byte>, bool> MakeSilenceTimeTest(int silenceTime) {
            var sw = Stopwatch.StartNew();
            var receivedAny = false;

            return rcvd => {
                // received anything, and after some milliseconds later we haven't received an extra chunk
                if (receivedAny && sw.ElapsedMilliseconds > silenceTime)
                    return true;
                receivedAny = true;
                sw.Restart();
                return false;
            };
        }

        public static Func<List<byte>, bool> CombineLogicalAnd(TaskCompletionTest test1, TaskCompletionTest test2) {
            return rcvd => test1(rcvd) && test2(rcvd);
        }

        public static Func<List<byte>, bool> CombineLogicalOr(TaskCompletionTest test1, TaskCompletionTest test2) {
            return rcvd => test1(rcvd) || test2(rcvd);
        }
    }
}