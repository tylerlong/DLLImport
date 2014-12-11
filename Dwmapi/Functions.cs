using System;
using System.Runtime.InteropServices;

namespace Dwmapi
{
    public static partial class Dwmapi
    {
        [DllImport("Dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);
    }
}
