using System;
using System.Runtime.InteropServices;

namespace DLLImport
{
    public static partial class User32
    {
        [DllImport("User32.dll")]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, GWL nIndex);


        [DllImport("User32.dll")]
        public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, GWL nIndex);


        [DllImport("User32.dll")]
        public static extern long SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);


        [DllImport("User32.dll")]
        public static extern long SetWindowLongPtr(IntPtr hWnd, GWL nIndex, int dwNewLong);


        [DllImport("User32.dll")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, HWND hWndInsertAfter, int x, int Y, int cx, int cy, SWP uFlags);


        [DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, SW nCmdShow);


        [DllImport("User32.dll")]
        public static extern bool EnumWindows(WndEnumProc lpEnumFunc, IntPtr lParam);


        [DllImport("User32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);


        [DllImport("User32.dll")]
        public static extern IntPtr SetWinEventHook(EVENT eventMin, EVENT eventMax, IntPtr hmodWinEventProc,
            WinEventProc lpfnWinEventProc, int idProcess, int idThread, WINEVENT dwflags);
    }
}
