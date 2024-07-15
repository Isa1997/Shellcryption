using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prog_painer_lib.Parser.parser;

namespace prog_painer_lib.Parser.interfaces
{
    public interface ITokenParser
    {
        public void Parse(Tokenizator input);
    }
}
