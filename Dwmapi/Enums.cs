namespace DLLImport
{
    public static partial class Dwmapi
    {
        // DWM Window Attribute
        public enum DWMWA
        {
            EXTENDED_FRAME_BOUNDS = 9,
            NCRENDERING_POLICY = 2,
        }


        // DWM Non-Client Rendering Policy
        public enum DWMNCRP 
        {
            DISABLED = 2,
            ENABLED = 3,
        }
    }
}
