using System.Collections.Generic;
using System.Linq;

namespace Zektor.Shared.DataSources {
    public class NullDataSource : WritableDataSource {
        public override DataSourceType Type => DataSourceType.NullSource;

        public override bool ValidConfig => true;
        public override string DetailedConfig => "NullDataSource/no config";

        public override bool Write(byte[] buffer, int offset, int count) {
            // note: you want to use Dispatch instead because that actually dose something
            return true;
        }

        public override bool Start(bool failSilently = false) {
            OnConnected();
            return true;
        }

        public void Dispatch(IEnumerable<byte> data) {
            OnDataReceived(data.ToArray());
        }
    }
}