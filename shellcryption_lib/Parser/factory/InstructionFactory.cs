using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using prog_painer_lib.Parser.tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.factory
{
    public static class InstructionFactory
    {
        public static IInstructionToken CreateInstruction(Tokenizator input)
        {
            IInstructionToken instruction = null;

            switch (input.PreviewNextToken())
            {
                case "put":
                    {
                        instruction = new PutToken();

                        break;
                    }
                case "paint":
                    {
                        instruction = new PaintToken();
                        break;
                    }

                case "move":
                    {
                        instruction = new MoveToken();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            if (instruction != null)
            {
                instruction.Parse(input);
            }

            return instruction;
        }
    }
}
