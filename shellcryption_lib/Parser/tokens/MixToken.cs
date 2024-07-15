using prog_painer_lib.Canvas;
using prog_painer_lib.extensions;
using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.tokens
{
    public class MixToken : IColorProviderToken
    {
        IColorProviderToken first = null;
        IColorProviderToken second = null;

        VarToken varName = null;

        public Color Evaluate(ICanvasPainter painter)
        {
            return first.Evaluate(painter).Mix(second.Evaluate(painter));
        }

        public void Parse(Tokenizator input)
        {
            if(input.GetNextToken() == "mix")
            {
                first = TokenFactory.CreateColorProvider(input);
                second = TokenFactory.CreateColorProvider(input);
            }
        }
    }
}
