using System;

namespace Zektor.Shared.DataSources {
    public enum ConnectionState {
        Disconnected = 0,
        Connecting = 1,
        Connected = 2
    }

    public interface IConnectable {
        ConnectionState State { get; }
        event EventHandler Connected;
        event EventHandler Connecting;
        event EventHandler Disconnected;
        void OnConnected();
        void OnConnecting();
        void OnDisconnected();
    }

    public abstract class BaseConnectable : IConnectable {
        private readonly object _stateLock = new object();
        public virtual ConnectionState State { get; protected set; }
        public event EventHandler Connected;
        public event EventHandler Connecting;
        public event EventHandler Disconnected;

        public virtual void OnConnected() {
            lock (_stateLock) {
                State = ConnectionState.Connected;
            }

            Connected?.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnConnecting() {
            lock (_stateLock) {
                State = ConnectionState.Connecting;
            }

            Connecting?.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnDisconnected() {
            lock (_stateLock) {
                State = ConnectionState.Disconnected;
            }

            Disconnected?.Invoke(this, EventArgs.Empty);
        }
    }

    public static class ExtensionMethods {
        public static void ReceiveConnectionStateEvents(this IConnectable to, IConnectable from) {
            from.Connected += (sender, args) => to.OnConnected();
            from.Connecting += (sender, args) => to.OnConnecting();
            from.Disconnected += (sender, args) => to.OnDisconnected();
        }
    }
}