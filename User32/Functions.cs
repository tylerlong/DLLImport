using System;
using System.Runtime.InteropServices;

namespace DLLImport
{
    public static partial class User32
    {
        [DllImport("User32.dll")]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);


        [DllImport("User32.dll")]
        public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);


        [DllImport("User32.dll")]
        public static extern long SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);


        [DllImport("User32.dll")]
        public static extern long SetWindowLongPtr(IntPtr hWnd, int nIndex, int dwNewLong);


        [DllImport("User32.dll")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int uFlags);


        [DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        [DllImport("User32.dll")]
        public static extern bool EnumWindows(WndEnumProc lpEnumFunc, IntPtr lParam);


        [DllImport("User32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);


        [DllImport("User32.dll")]
        public static extern IntPtr SetWinEventHook(int eventMin, int eventMax, IntPtr hmodWinEventProc,
            WinEventProc lpfnWinEventProc, int idProcess, int idThread, SetWinEventHookFlags dwflags);
    }
}
