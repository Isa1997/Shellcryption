using prog_painer_lib.extensions;
using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using prog_painer_lib.Parser.tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser
{
    public static class TokenFactory
    {
        public static IColorProviderToken CreateColorProvider(Tokenizator input)
        {
            IColorProviderToken iToken = null;
            string previewFirst = input.PreviewNextToken();

            if (previewFirst.IsColor())
            {
                iToken = new ColorToken();
                iToken.Parse(input);
            }
            else if (previewFirst == "mix")
            {
                iToken = new MixToken();
                iToken.Parse(input);
            }
            else
            {
                iToken = new VarToken();
                iToken.Parse(input);
            }

            return iToken;
        }

        public static IDirectionToken CreateDirectionToken(Tokenizator input)
        {
            IDirectionToken iToken = null;
            string previewFirst = input.PreviewNextToken();

            if (previewFirst.ToEDirection() != EDirection.Invalid)
            {
                iToken = new DirectionToken();
                iToken.Parse(input);
            }

            return iToken;
        }
    }
}
