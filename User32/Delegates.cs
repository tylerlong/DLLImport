using System;

namespace DLLImport
{
    public static partial class User32
    {
        public delegate bool WndEnumProc(IntPtr hwnd, IntPtr lParam);

        public delegate void WinEventProc(IntPtr hWinEventHook, int iEvent, IntPtr hwnd, int idObject, int idChild, int dwEventThread, int dwmsEventTime);

        public delegate IntPtr WndProc(IntPtr hwnd, int uMsg, IntPtr wParam, IntPtr lParam);
    }
}
