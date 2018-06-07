using System.Collections.Generic;
using System.Linq;

namespace Zektor.Shared.DataSources {
    public abstract class WritableDataSource : DataSource {
        public int LastDataSent { get; protected set; }

        public long TotalTransmitted { get; protected set; }

        /// <summary>
        ///     Write data to stream.
        /// </summary>
        public virtual bool Write(byte[] buffer, int offset, int count) {
            TotalTransmitted += count;
            return true;
        }

        public bool Write(byte[] buffer) {
            return Write(buffer, 0, buffer.Length);
        }

        public bool Write(IEnumerable<byte> buffer) {
            var b = buffer.ToArray();
            return Write(b, 0, b.Length);
        }

        public override void Stop() {
            base.Stop();
            TotalTransmitted = 0;
            ReconnectBehavior = ReconnectBehavior.Ignore;
        }
    }
}