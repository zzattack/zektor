using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Zektor.Shared.DataSources;
using Zektor.Shared.Protocol;

namespace Zektor.Protocol {
    public class ZektorProtocol : DataProtocol<ZektorCommand> {
        public const byte STX = (byte) '^';
        public const byte ETX = (byte) '$';

        private bool _lineReceiving;

        protected override void AddToBuffer(DataSource o, DataReceivedEventArgs e) {
            foreach (byte b in e.Data) {
                if (b == STX) {
                    if (_buffer.Any())
                        OnBogusReceived(_buffer);

                    _buffer.Clear();
                    _lineReceiving = true;
                }
                else {
                    if (_lineReceiving && b == ETX) {
                        if (!Dispatch(_buffer))
                            OnBogusReceived(_buffer);
                        
                        _lineReceiving = false;
                        _buffer.Clear();
                    }
                    else {
                        _buffer.Add(b);
                    }
                }

            }
        }

        public DeviceState DeviceState { get; set; }
        public override bool Write(ZektorCommand line) {
            // if DeviceState is kept, match checksum preference
            if (DeviceState != null && DeviceState.XS.HasValue && (DeviceState.XS & ExtendedSettings.CSE) != 0)
                line.HasChecksum = true;
            return base.Write(line);
        }

        protected override void OnBogusReceived(IEnumerable<byte> bs) {
            var data = bs.ToList();

            // trim whitespace
            int front = 0, rear = data.Count - 1;
            while (front < data.Count && char.IsWhiteSpace((char)data[front]))
                front++;
            while (rear > front && char.IsWhiteSpace((char)data[rear]))
                rear--;
            if (front < rear)
                base.OnBogusReceived(data.GetRange(front, rear - front));
        }

        private static readonly List<string> Types = new List<string>();
        private Assembly typesAssembly;
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