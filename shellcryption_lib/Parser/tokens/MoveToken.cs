using prog_painer_lib.Canvas;
using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.tokens
{
    internal class MoveToken : IInstructionToken
    {
        IDirectionToken destination = null;
        public void Execute(ICanvasPainter painter)
        {
            Vector2 dest = destination.Evaluate();

            painter.SetCursorPosition(new Point((int)dest.X, (int)dest.Y));
        }

        public void Parse(Tokenizator input)
        {
            if (input.GetNextToken() == "move")
            {
                destination = TokenFactory.CreateDirectionToken(input);
            }
        }
    }
}
