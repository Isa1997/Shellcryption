using prog_painer_lib.Parser.parser;
using prog_painer_lib.Parser.tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.extensions
{
    public static class TokenExtension
    {
        public static EDirection ToEDirection(this string value)
        {
            switch (value)
            {
                case "down": return EDirection.Down;
                case "up": return EDirection.Up;
                case "right": return EDirection.Right;
                case "left": return EDirection.Left;
                default: return EDirection.Invalid;
            }
        }
    }
}
