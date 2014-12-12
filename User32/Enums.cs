namespace DLLImport
{
    public static partial class User32
    {
        // Event
        public enum EVENT
        {
            MAX = 0x7FFFFFFF,
            MIN = 0x00000001,
            SYSTEM_DRAGDROPEND = 0x000F,
            SYSTEM_DRAGDROPSTART = 0x000E,
            SYSTEM_MOVESIZEEND = 0x000B,
            SYSTEM_MOVESIZESTART = 0x000A,
        }


        // GetWindowLong
        public enum GWL
        {
            EXSTYLE = -20,
            HWNDPARENT = -8,
            STYLE = -16,
        }


        // HWND
        public enum HWND
        {
            NOTOPMOST = -2,
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
            DEFERERASE= 0x2000,
            FRAMECHANGED = 0x0020,
            NOACTIVATE = 0x0010,
            NOMOVE = 0x0002,
            NOREDRAW = 0x0008,
            NOSIZE = 0x0001,
            NOSENDCHANGING = 0x0400,
            NOZORDER = 0x0004,
        }


        // Win Event
        public enum WINEVENT
        {
            INCONTEXT = 4,
            OUTOFCONTEXT = 0,
            SKIPOWNPROCESS = 2,
            SKIPOWNTHREAD = 1,
        }


        // Window Style
        public enum WS
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
        public enum WS_EX
        {
            APPWINDOW = 0x00040000,
            TOOLWINDOW = 0x00000080,
        }
    }
}
