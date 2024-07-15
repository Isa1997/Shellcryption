using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.parser
{
    public interface IPainterParser
    {
        bool IsValidVarName(string name);
        void AddVariable(string name);
    }
}
