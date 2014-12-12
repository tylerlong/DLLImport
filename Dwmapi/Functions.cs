using System;
using System.Runtime.InteropServices;

namespace DLLImport
{
    public static partial class Dwmapi
    {
        [DllImport(@"C:\Windows\System32\dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);


        [DllImport(@"C:\Windows\System32\dwmapi.dll")]
        public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out RECT pvAttribute, int cbAttribute);


        [DllImport(@"C:\Windows\System32\dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
    }
}
