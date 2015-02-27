using System;
using System.Runtime.InteropServices;

namespace DLLImport
{
    public static partial class Shell32
    {
        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, SHGFI uFlags);
    }
}
