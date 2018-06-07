using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Zektor.Shared.Utility {
    public static class Util {
        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;
        private static Stopwatch sw = Stopwatch.StartNew();

        /// <summary> Converts an array of bytes into a formatted string of hex digits (ex: E4 CA B2)</summary>
        /// <param name="data"> The array of bytes to be translated into a string of hex digits. </param>
        /// <returns> Returns a well formatted string of hex digits with spacing. </returns>
        public static string ByteArrayToHexString(IEnumerable<byte> data) {
            var sb = new StringBuilder(data.Count() * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

        public static List<byte> HexStringToByteArray(string s) {
            return (from part in s.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                where part.ToLower().Trim().All(c => '0' <= c && c <= '9' || 'a' <= c && c <= 'f') && !string.IsNullOrEmpty(part.Trim())
                select Convert.ToByte(part.Trim(), 16)).ToList();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        ///     Scrolls the vertical scroll bar of a multi-line text box to the bottom.
        /// </summary>
        /// <param name="tb">The text box to scroll</param>
        public static void ScrollToBottom(TextBoxBase tb) {
            SendMessage(tb.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
        }

        /// <summary>Blends the specified colors together.</summary>
        /// <param name="color">Color to blend onto the background color.</param>
        /// <param name="backColor">Color to blend the other color onto.</param>
        /// <param name="amount">
        ///     How much of <paramref name="color" /> to keep,
        ///     “on top of” <paramref name="backColor" />.
        /// </param>
        /// <returns>The blended colors.</returns>
        public static Color Blend(this Color color, Color backColor, double amount) {
            var r = (byte)(color.R * amount + backColor.R * (1 - amount));
            var g = (byte)(color.G * amount + backColor.G * (1 - amount));
            var b = (byte)(color.B * amount + backColor.B * (1 - amount));
            return Color.FromArgb(r, g, b);
        }

        public static void PrintRegex(MatchCollection mc) {
            for (var i = 0; i < mc.Count; i++) {
                var spacer = "";
                Debug.WriteLine("");
                Debug.WriteLine(spacer + "Match[" + i + "]: " + mc[i].Value);
                Debug.WriteLine(spacer + "Printing groups for this match...");
                var gc = mc[i].Groups;
                for (var j = 0; j < gc.Count; j++) {
                    spacer = " ";
                    Debug.WriteLine(spacer + "Group[" + j + "]: " + gc[j].Value);
                    Debug.WriteLine(spacer + "Printing captures for this group...");
                    var cc = gc[j].Captures;
                    for (var k = 0; k < cc.Count; k++) {
                        spacer = "  ";
                        Debug.WriteLine(spacer + "Capture[" + k + "]: " + cc[k].Value);
                    }
                }
            }
        }

        /// <summary>
        ///     Splits an array into several smaller arrays.
        /// </summary>
        /// <typeparam name="T">The type of the array.</typeparam>
        /// <param name="array">The array to split.</param>
        /// <param name="size">The size of the smaller arrays.</param>
        /// <returns>An array containing smaller arrays.</returns>
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> sequence, int size) {
            var l = sequence.AsEnumerable();
            while (l.Any()) {
                yield return l.Take(size);
                l = l.Skip(size);
            }
        }

        public static byte TrimByte(byte min, byte val, int max) {
            return (byte)Math.Max(min, Math.Min(max, val));
        }
    }
}