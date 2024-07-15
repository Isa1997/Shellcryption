using prog_painer_lib.Canvas;
using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.tokens
{
    public class PutToken : IInstructionToken
    {
        IColorProviderToken color;
        VarToken pot = null;

        public void Execute(ICanvasPainter painter)
        {
            painter.SetColor(pot.name, color.Evaluate(painter));
        }

        public void Parse(Tokenizator input)
        {
            if(input.GetNextToken() == "put")
            {
                color = TokenFactory.CreateColorProvider(input);

                if(input.GetNextToken() == "into")
                {
                    pot = new VarToken();
                    pot.Parse(input);
                }
            }
        }
    }
}
