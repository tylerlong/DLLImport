using System.Runtime.InteropServices;

namespace DLLImport
{
    public static partial class Dwmapi
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public MARGINS(int v)
            {
                Left = v;
                Right = v;
                Top = v;
                Bottom = v;
            }
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
    }
}
