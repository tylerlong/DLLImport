using System;

namespace DLLImport
{
    public static partial class User32
    {
        // Event
        public enum EVENT
        {
            MAX = 0x7FFFFFFF,
            MIN = 0x00000001,
            OBJECT_DESTROY = 0x8001,
            OBJECT_FOCUS = 0x8005,
            OBJECT_HIDE = 0x8003,
            SYSTEM_DRAGDROPEND = 0x000F,
            SYSTEM_DRAGDROPSTART = 0x000E,
            SYSTEM_FOREGROUND = 0x0003,
            SYSTEM_MINIMIZEEND = 0x0017,
            SYSTEM_MINIMIZESTART = 0x0016,
            SYSTEM_MOVESIZEEND = 0x000B,
            SYSTEM_MOVESIZESTART = 0x000A,
        }


        // Get Window
        public enum GW
        { 
            HWNDNEXT = 2,
            HWNDPREV = 3,
        }


        // GetWindowLong
        public enum GWL
        {
            EXSTYLE = -20,
            HWNDPARENT = -8,
            STYLE = -16,
            WNDPROC = -4,
        }


        // HWND
        public enum HWND
        {
            BOTTOM = 1,
            NOTOPMOST = -2,
            TOP = 0,
            TOPMOST = -1,
        }


        // Object Identifier
        public enum OBJID 
        {
            SELF = 0x00000000,
            WINDOW = 0x00000000,
        }


        // System Command
        public enum SC
        {
            MOVE = 0xF010,
        }


        // Show Window
        public enum SW
        {
            HIDE = 0,
            MAXIMIZE = 3,
            MINIMIZE = 6,
            RESTORE = 9,
            SHOW = 5,
        }


        // SetWindowPos
        public enum SWP
        {
            DEFERERASE = 0x2000,
            FRAMECHANGED = 0x0020,
            NOACTIVATE = 0x0010,
            NOMOVE = 0x0002,
            NOREDRAW = 0x0008,
            NOSIZE = 0x0001,
            NOSENDCHANGING = 0x0400,
            NOZORDER = 0x0004,
            SHOWWINDOW = 0x0040,
        }


        // Windows Hook
        public enum WH
        {
            KEYBOARD = 2,
            KEYBOARD_LL = 13,
        }


        // Win Event
        public enum WINEVENT
        {
            INCONTEXT = 4,
            OUTOFCONTEXT = 0,
            SKIPOWNPROCESS = 2,
            SKIPOWNTHREAD = 1,
        }


        // Window Message
        public enum WM
        {
            CLOSE = 0x0010,
            GETMINMAXINFO = 0x0024,
            KEYDOWN = 0x0100,
            KEYUP = 0x0101,
            MOVING = 0x0216,
            SIZE = 0x0005,
            SIZING = 0x0214,
        }


        // Window Style
        [Flags]
        public enum WS : long
        {
            CAPTION = 0x00C00000,
            DLGFRAME = 0x00400000,
            MAXIMIZE = 0x01000000,
            MAXIMIZEBOX = 0x00010000,
            MINIMIZEBOX = 0x00020000,
            SIZEBOX = 0x00040000,
            SYSMENU = 0x00080000,
            THICKFRAME = 0x00040000,
        }


        // Window Style, Extended
        [Flags]
        public enum WS_EX : long
        {
            APPWINDOW = 0x00040000,
            TOOLWINDOW = 0x00000080,
        }
    }
}
