using System;
using System.Runtime.InteropServices;

namespace Zektor.Shared.USB {
    // Hid.dll definitions
    public static class Hid {
        #region Structures

        public struct DeviceAttributes {
            public int Size;
            public ushort VendorId;
            public ushort ProductId;
            public ushort VersionNumber;
        }

        public struct Caps {
            public ushort Usage;
            public ushort UsagePage;
            public ushort InputReportByteLength;
            public ushort OutputReportByteLength;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
            public ushort[] Reserved;

            public ushort NumberLinkCollectionNodes;
            public ushort NumberInputButtonCaps;
            public ushort NumberInputValueCaps;
            public ushort NumberInputDataIndices;
            public ushort NumberOutputButtonCaps;
            public ushort NumberOutputValueCaps;
            public ushort NumberOutputDataIndices;
            public ushort NumberFeatureButtonCaps;
            public ushort NumberFeatureValueCaps;
            public ushort NumberFeatureDataIndices;
        }

        #endregion

        #region Functions

        [DllImport("hid.dll")]
        public static extern void HidD_GetHidGuid(
            out Guid hidGuid);

        [DllImport("hid.dll")]
        public static extern bool HidD_GetAttributes(
            SafeHandle hidDeviceObject,
            out DeviceAttributes attributes);

        [DllImport("hid.dll")]
        public static extern bool HidD_SetFeature(
            SafeHandle hidDeviceObject,
            byte[] reportBuffer,
            int reportBufferLength);

        [DllImport("hid.dll")]
        public static extern bool HidD_GetFeature(
            SafeHandle hidDeviceObject,
            byte[] reportBuffer,
            int reportBufferLength);

        [DllImport("hid.dll")]
        public static extern bool HidD_GetPreparsedData(
            SafeHandle hidDeviceObject,
            out IntPtr preparsedData);

        [DllImport("hid.dll")]
        public static extern bool HidD_FreePreparsedData(IntPtr preparsedData);

        [DllImport("hid.dll")]
        public static extern int HidP_GetCaps(IntPtr preparsedData, out Caps caps);

        [DllImport("hid.dll")]
        public static extern bool HidD_GetInputReport(
            SafeHandle hidDeviceObject,
            byte[] reportBuffer,
            int reportBufferLength);

        [DllImport("hid.dll")]
        public static extern bool HidD_SetOutputReport(
            SafeHandle hidDeviceObject,
            byte[] reportBuffer,
            int reportBufferLength);

        #endregion
    }
}