using System;
using System.Runtime.InteropServices;

namespace DLLImport
{
    public static partial class Shell32
    {
        [DllImport("Shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);
    }
}
