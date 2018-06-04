using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SPAA05.Shared.DataSources;
using SPAA05.Shared.Protocol;

namespace Zektor.Control {
    public class ZektorProtocol : DataProtocol<ZektorCommand> {
        public const byte STX = (byte) '^';
        public const byte ETX = (byte) '$';

        private bool _lineReceiving;

        protected override void AddToBuffer(DataSource o, DataReceivedEventArgs e) {
            foreach (byte b in e.Data) {
                if (b == STX) {
                    _buffer.Clear();
                    _lineReceiving = true;
                }
                else if (_lineReceiving) {
                    if (b == ETX) {
                        Dispatch();
                        _lineReceiving = false;
                        _buffer.Clear();
                    }
                    else {
                        _buffer.Add(b);
                    }
                }
            }
        }

        private static readonly List<string> Types = new List<string>();
        private Assembly typesAssembly = null;
        protected override bool Dispatch(IEnumerable<byte> data) {
            if (typesAssembly == null) {
                // gather types implementing ZektorCommand
                typesAssembly = Assembly.GetAssembly(typeof(ZektorProtocol));
                foreach (var type in typesAssembly.GetTypes().Where(t => t.IsSubclassOf(typeof(ZektorCommand)) && !t.IsAbstract)) {
                    Types.Add(type.FullName);
                }
            }

            foreach (var t in Types) {
                var type = (ZektorCommand)typesAssembly.CreateInstance(t);

                try {
                    if (type.Parse(data.ToList())) {
                        OnLineReceived(type);
                        return true;
                    }
                }
                catch (FormatException) { }
                catch (ArgumentOutOfRangeException) { }
            }

            return false;
        }
    }
}