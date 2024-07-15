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
    public class PaintToken : IInstructionToken
    {
        IDirectionToken direction = null;
        IColorProviderToken colorProvider = null;
        public void Parse(Tokenizator input)
        {
            if (input.GetNextToken() == "paint")
            {
                direction = TokenFactory.CreateDirectionToken(input);

                if (input.GetNextToken() == "with")
                {
                    colorProvider = TokenFactory.CreateColorProvider(input);
                }
            }
        }
        public void Execute(ICanvasPainter painter)
        {
            if(colorProvider != null)
            {
                painter.SetCursorColor(colorProvider.Evaluate(painter));
            }

            painter.Paint(direction.Evaluate());
        }


    }
}
