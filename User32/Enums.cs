namespace DLLImport
{
    public static partial class User32
    {
        // GetWindowLong
        public enum GWL
        {
            EXSTYLE = -20,
            HWNDPARENT = -8,
            STYLE = -16,
        }


        // Window Style
        public enum WS
        {
            CAPTION = 0x00C00000,
            SIZEBOX = 0x00040000,
        }


        // Window Style, Extended
        public enum WS_EX
        {
            APPWINDOW = 0x00040000,
            TOOLWINDOW = 0x00000080,
        }


        // HWND
        public enum HWND
        {
            NOTOPMOST = -2,
        }


        // SetWindowPos
        public enum SWP
        {
            NOACTIVATE = 0x0010,
            NOMOVE = 0x0002,
            NOSIZE = 0x0001,
            NOZORDER = 0x0004,
        }


        // Show Window
        public enum SW
        {
            HIDE = 0,
            RESTORE = 9,
            SHOW = 5,
        }


        // Win Event
        public enum WINEVENT
        {
            INCONTEXT = 4,
            OUTOFCONTEXT = 0,
            SKIPOWNPROCESS = 2,
            SKIPOWNTHREAD = 1,
        }


        // Event
        public enum EVENT
        {
            SYSTEM_MOVESIZEEND = 0x000B,
            SYSTEM_MOVESIZESTART = 0x000A,
        }
    }
}
