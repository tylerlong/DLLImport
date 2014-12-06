using System;

namespace DLLImport
{
    public static partial class User32
    {
        public delegate bool WndEnumProc(IntPtr hwnd, IntPtr lParam);
    }
}
