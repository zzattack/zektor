using System;
using System.Linq;
using Zektor.Shared.USB;
using Zektor.Shared.Utility;

namespace Zektor.Shared.DataSources {
    public class SerialPortWatcher : IDisposable {
        private readonly string portName;
        private bool _lastPresenceCheckResult;

        public SerialPortWatcher(string portName) {
            this.portName = portName;
            UsbNotification.DeviceRemovalComplete += OnUsbNotificationOnDeviceRemovalComplete;
            _lastPresenceCheckResult = IsPresent();
        }

        public void Dispose() {
            UsbNotification.DeviceRemovalComplete -= OnUsbNotificationOnDeviceRemovalComplete;
        }

        public event EventHandler DeviceRemoved;

        private void OnUsbNotificationOnDeviceRemovalComplete(object sender, EventArgs args) {
            CheckPresent();
        }

        private bool IsPresent() {
            return !string.IsNullOrEmpty(portName) && SerialPortInfo.GetPorts().Any(p => p.Name == portName);
        }

        private void CheckPresent() {
            if (_lastPresenceCheckResult && !IsPresent()) {
                OnDeviceRemoved();
                _lastPresenceCheckResult = false;
            }
        }

        private void OnDeviceRemoved() {
            if (DeviceRemoved != null)
                DeviceRemoved(this, EventArgs.Empty);
        }
    }
}