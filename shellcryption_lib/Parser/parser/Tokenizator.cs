using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.parser
{
    public class Tokenizator
    {
        private int currentTokenCapacity = 0;
        private int currentPositionIndex = 0;

        public IPainterParser parser = null;

        private List<string> tokens = new();
        public void Init(IPainterParser parser, string line)
        {
            this.parser = parser;

            var parts = line.Split(' ');
            foreach (var part in parts)
            {
                var trimmedPart = part.Trim();
                if (part.Length == 0)
                    continue;

                tokens.Add(trimmedPart);
            }

            currentPositionIndex = 0;
            currentTokenCapacity = tokens.Count;
        }

        public string GetNextToken()
        {
            if (currentTokenCapacity == currentPositionIndex)
            {
                return null;
            }

            currentPositionIndex++;
            return tokens[currentPositionIndex - 1];
        }

        public string PreviewNextToken()
        {
            if (currentTokenCapacity == currentPositionIndex)
            {
                return null;
            }

            return tokens[currentPositionIndex];
        }
    }
}
