using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.extensions
{
    public static class ColorExtension
    {
        public static bool IsColor(this string color) => color.StartsWith("#");
        public static Color GetColorValue(this string color) => Color.FromArgb(Convert.ToInt32(color.Replace("#", "FF"), 16));

        public static Color Mix(this Color baseColor, Color mixColor) => Color.Red;
    }
}
