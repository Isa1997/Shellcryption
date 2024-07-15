using prog_painer_lib.Canvas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.interfaces
{
    public interface IColorProviderToken : ITokenParser
    {
        Color Evaluate(ICanvasPainter painter);
    }
}
