using System;
using System.Runtime.InteropServices;

namespace DLLImport
{
    public static class User32
    {
        public const int GWL_STYLE = -16;
        public const int GWL_EXSTYLE = -20;
        public const int GWL_HWNDPARENT = -8;
        public const int WS_CAPTION = 0x00C00000;
        public const int WS_SIZEBOX = 0x00040000;
        public const int WS_EX_TOOLWINDOW = 0x00000080;
        public const int WS_EX_APPWINDOW = 0x00040000;

        [DllImport("User32.dll")]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("User32.dll")]
        public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

        [DllImport("User32.dll")]
        public static extern long SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("User32.dll")]
        public static extern long SetWindowLongPtr(IntPtr hWnd, int nIndex, int dwNewLong);



        public const int HWND_NOTOPMOST = -2;
        public const int SWP_NOACTIVATE = 0x0010;
        public const int SWP_NOMOVE = 0x0002;
        public const int SWP_NOSIZE = 0x0001;
        public const int SWP_NOZORDER = 0x0004;

        [DllImport("User32.dll")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int handleInsertAfter, int x, int Y, int width, int height, int uFlags);


        public const int SW_HIDE = 0;
        public const int SW_SHOW = 5;
        public const int SW_RESTORE = 9;

        [DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        

        public delegate bool WndEnumProc(IntPtr hwnd, IntPtr lParam);
        [DllImport("User32.dll")]
        public static extern bool EnumWindows(WndEnumProc lpEnumFunc, IntPtr lParam);


        [DllImport("User32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);
    }
}
