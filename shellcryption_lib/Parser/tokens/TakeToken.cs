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
    public class TakeToken : IInstructionToken
    {
        IColorProviderToken colorProvider = null;

        public void Execute(ICanvasPainter painter)
        {
            painter.SetCursorColor(colorProvider.Evaluate(painter));
        }

        public void Parse(Tokenizator input)
        {
            if (input.GetNextToken() == "take")
            {
                colorProvider = TokenFactory.CreateColorProvider(input);
            }
        }
    }
}
