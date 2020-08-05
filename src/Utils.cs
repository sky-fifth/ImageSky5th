using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SixLabors.ImageSharp.PixelFormats;

namespace ImageSky5th
{
    public static class Utils
    {
        public static string ToHex(this Rgb24 p)
        {
            return ((uint)(p.B | (p.G << 8) | (p.R << 16))).ToString("X6");
        }
    }
}
