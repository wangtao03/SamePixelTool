using System.Runtime.InteropServices;

namespace SamePixelTool
{
    [StructLayout(LayoutKind.Explicit)]
    public class RGB
    {
        [FieldOffset(0)]
        public byte red;

        [FieldOffset(1)]
        public byte green;

        [FieldOffset(2)]
        public byte blue;
    }

    [StructLayout(LayoutKind.Explicit)]
    public class ARGB : RGB
    {
        [FieldOffset(0)]
        public byte alpha;
    }

    [StructLayout(LayoutKind.Explicit)]
    public class RGB32 : ARGB
    {
    }
}