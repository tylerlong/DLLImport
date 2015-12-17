using System;

namespace DLLImport
{
    public static partial class User32
    {
        public delegate bool WndEnumProc(IntPtr hwnd, IntPtr lParam);

        public delegate void WinEventProc(IntPtr hWinEventHook, int iEvent, IntPtr hwnd, int idObject, int idChild, int dwEventThread, int dwmsEventTime);

        public delegate IntPtr WndProc(IntPtr hwnd, int uMsg, IntPtr wParam, IntPtr lParam);

        public delegate IntPtr KeyboardProc(int code, IntPtr wParam, IntPtr lParam);

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        public delegate IntPtr CallWndProc(int nCode, IntPtr wParam, IntPtr lParam);
    }
}
