using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.interfaces
{
    public interface IDirectionToken : ITokenParser
    {
        Vector2 Evaluate();
    }
}
