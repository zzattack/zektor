using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Zektor.Shared.USB {
    public static class UsbNotification {
        private const int DbtDevtypDeviceinterface = 5;
        private static readonly Guid GuidUsbDevices = new Guid("A5DCBF10-6530-11D2-901F-00C04FB951ED"); // USB devices
        private static IntPtr _notificationHandle;
        private static readonly UsbDeviceNotificationListenerWindow _window;

        static UsbNotification() {
            _window = new UsbDeviceNotificationListenerWindow();
            RegisterUsbDeviceNotification(_window.Handle);
            Application.ApplicationExit += (sender, args) => {
                UnregisterUsbDeviceNotification();
                _window.Dispose();
            };
        }

        public static event EventHandler<UsbNotificationEventArgs> DeviceArrival;
        public static event EventHandler<UsbNotificationEventArgs> DeviceRemovalComplete;

        private static void OnDeviceArrival(UsbNotificationEventArgs args) {
            if (DeviceArrival != null)
                DeviceArrival(null, args);
        }

        private static void OnDeviceRemoveComplete(UsbNotificationEventArgs args) {
            if (DeviceRemovalComplete != null)
                DeviceRemovalComplete(null, args);
        }

        /// <summary>
        ///     Registers a window to receive notifications when USB devices are plugged or unplugged.
        /// </summary>
        /// <param name="windowHandle">Handle to the window receiving notifications.</param>
        private static void RegisterUsbDeviceNotification(IntPtr windowHandle) {
            var dbi = new DevBroadcastDeviceinterface {
                DeviceType = DbtDevtypDeviceinterface,
                Reserved = 0,
                ClassGuid = GuidUsbDevices,
                Name = 0
            };

            dbi.Size = Marshal.SizeOf(dbi);
            var buffer = Marshal.AllocHGlobal(dbi.Size);
            Marshal.StructureToPtr(dbi, buffer, true);

            _notificationHandle = RegisterDeviceNotification(windowHandle, buffer, 0);
        }

        /// <summary>
        ///     Unregisters the window for USB device notifications
        /// </summary>
        private static void UnregisterUsbDeviceNotification() {
            UnregisterDeviceNotification(_notificationHandle);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr RegisterDeviceNotification(IntPtr recipient, IntPtr notificationFilter, int flags);

        [DllImport("user32.dll")]
        private static extern bool UnregisterDeviceNotification(IntPtr handle);

        [StructLayout(LayoutKind.Sequential)]
        private struct DevBroadcastDeviceinterface {
            internal int Size;
            internal int DeviceType;
            internal int Reserved;
            internal Guid ClassGuid;
            internal short Name;
        }


        /// <summary>
        ///     Represents the window that is used internally to get the messages.
        /// </summary>
        private sealed class UsbDeviceNotificationListenerWindow : NativeWindow, IDisposable {
            private const int DbtDeviceArrival = 0x8000; // system detected a new device        
            private const int DbtDeviceRemoveComplete = 0x8004; // device is gone      
            private const int WmDevicechange = 0x0219; // device change event      

            public UsbDeviceNotificationListenerWindow() {
                // create the handle for the window.
                CreateHandle(new CreateParams());
            }

            public void Dispose() {
                DestroyHandle();
            }

            protected override void WndProc(ref Message m) {
                base.WndProc(ref m);
                if (m.Msg == WmDevicechange) {
                    if ((int)m.WParam != DbtDeviceArrival && (int)m.WParam != DbtDeviceRemoveComplete)
                        return;

                    string name = null;

                    var hdr = (DeviceBroadcastHeader)Marshal.PtrToStructure(m.LParam, typeof(DeviceBroadcastHeader));
                    var type = hdr.dbcc_devicetype;
                    if (type == DeviceType.DBT_DEVTYP_PORT) {
                        var prt = (DEV_BROADCAST_PORT)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_PORT));
                        name = new string(prt.dbcp_name);
                    }
                    else if (type == DeviceType.DBT_DEVTYP_DEVICEINTERFACE) {
                        var dev = (DEV_BROADCAST_DEVICEINTERFACE)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_DEVICEINTERFACE));
                        name = new string(dev.dbcc_name);
                    }

                    if (type == null) return;
                    if (name != null) name = name.Substring(0, name.IndexOf('\0'));

                    var args = new UsbNotificationEventArgs(type, name);
                    switch ((int)m.WParam) {
                        case DbtDeviceRemoveComplete:
                            OnDeviceRemoveComplete(args); //
                            break;
                        case DbtDeviceArrival:
                            OnDeviceArrival(args);
                            break;
                    }
                }
            }
        }
    }

    public class UsbNotificationEventArgs : EventArgs {
        public UsbNotificationEventArgs(DeviceType type, string name) {
            DeviceType = type;
            Name = name;
        }

        public DeviceType DeviceType { get; }
        public string Name { get; }
    }

    public enum DeviceType {
        DBT_DEVTYP_OEM = 0x00000000, //OEM-defined device type
        DBT_DEVTYP_DEVNODE = 0x00000001, //Devnode number
        DBT_DEVTYP_VOLUME = 0x00000002, //Logical volume
        DBT_DEVTYP_PORT = 0x00000003, //Serial, parallel
        DBT_DEVTYP_NET = 0x00000004, //Network resource
        DBT_DEVTYP_DEVICEINTERFACE = 0x00000005, //Device interface class
        DBT_DEVTYP_HANDLE = 0x00000006 //File system handle
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct DeviceBroadcastHeader {
        public int dbcc_size;
        public DeviceType dbcc_devicetype;
        public int dbcc_reserved;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DEV_BROADCAST_DEVICEINTERFACE {
        public int dbcc_size;
        public int dbcc_devicetype;
        public int dbcc_reserved;

        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 16)]
        public byte[] dbcc_classguid;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public char[] dbcc_name;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEV_BROADCAST_VOLUME {
        public int dbcv_size;
        public int dbcv_devicetype;
        public int dbcv_reserved;
        public int dbcv_unitmask;
        public short dbcv_flags;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DEV_BROADCAST_PORT {
        public int dbcp_size;
        public int dbcp_devicetype;
        public int dbcp_reserved;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public char[] dbcp_name;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEV_BROADCAST_OEM {
        public int dbco_size;
        public int dbco_devicetype;
        public int dbco_reserved;
        public int dbco_identifier;
        public int dbco_suppfunc;
    }
}