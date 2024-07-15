using prog_painer_lib.Canvas;
using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.tokens
{
    public class VarToken : IColorProviderToken
    {
        public string name = "";

        public Color Evaluate(ICanvasPainter painter)
        {
            return painter.GetColor(name);
        }

        public void Parse(Tokenizator input)
        {
            name = input.GetNextToken();
            if(!input.parser.IsValidVarName(name))
            {

            }
        }
    }
}
