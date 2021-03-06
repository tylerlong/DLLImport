using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DLLImport
{
    public static partial class User32
    {
        [DllImport("User32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);


        [DllImport("User32.dll")]
        public static extern long GetWindowLongPtr(IntPtr hWnd, GWL nIndex);


        [DllImport("User32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);


        [DllImport("User32.dll")]
        public static extern long SetWindowLongPtr(IntPtr hWnd, GWL nIndex, long dwNewLong);


        [DllImport("User32.dll")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, HWND hWndInsertAfter, int x, int Y, int cx, int cy, SWP uFlags);


        [DllImport("User32.dll")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int Y, int cx, int cy, SWP uFlags);


        [DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, SW nCmdShow);


        [DllImport("User32.dll")]
        public static extern bool EnumWindows(WndEnumProc lpEnumFunc, IntPtr lParam);


        [DllImport("User32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);


        [DllImport("User32.dll")]
        public static extern IntPtr SetWinEventHook(EVENT eventMin, EVENT eventMax, IntPtr hmodWinEventProc,
            WinEventProc lpfnWinEventProc, int idProcess, int idThread, WINEVENT dwflags);


        [DllImport("User32.dll")]
        public static extern bool UnhookWinEvent(IntPtr hWinEventHook);


        [DllImport("User32.dll")]
        public static extern IntPtr DefWindowProc(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);


        [DllImport("User32.dll")]
        public static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);


        [DllImport("User32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChind, IntPtr hWndNewParent);


        [DllImport("User32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);


        [DllImport("User32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);


        [DllImport("User32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);


        [DllImport("User32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);


        [DllImport("User32.dll")]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);


        [DllImport("User32.dll")]
        public static extern IntPtr WindowFromPoint(POINT point);


        [DllImport("User32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, WM Msg, int wParam, int lParam);


        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(WH idHook, Delegate lpfn, IntPtr hMod, int dwThreadId);


        [DllImport("user32.dll")]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);


        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);


        [DllImport("user32.dll")]
        public static extern IntPtr GetWindow(IntPtr hWnd, GW wCmd);


        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();


        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();


        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();


        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        [DllImport("user32.dll")]
        public static extern IntPtr SetFocus(IntPtr hWnd);
    }
}
