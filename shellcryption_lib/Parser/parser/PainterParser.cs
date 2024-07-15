using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prog_painer_lib.Parser.factory;
using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.tokens;

namespace prog_painer_lib.Parser.parser
{
    public class PainterParser : IPainterParser
    {
        public readonly List<IInstructionToken> tokenParsers = new();

        public void AddVariable(string name)
        {
            
        }

        public bool Initialize(string input)
        {
            var lines = input.Split(";");

            foreach (var line in lines)
            {
                Tokenizator tokenizator = new Tokenizator();
                tokenizator.Init(this, line);

                IInstructionToken token = InstructionFactory.CreateInstruction(tokenizator);
                if (token == null)
                    continue;

                tokenParsers.Add(token);
            }

            return true;
        }

        public bool IsValidVarName(string name)
        {
            return true;
        }
    }
}
