using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Canvas
{
    public interface ICanvasPainter
    {
        public Color GetColor(string name);
        public void SetColor(string name, Color color);

        public void Paint(Vector2 delta);
        public void SetCursorColor(Color color);

        public void SetCursorPosition(Point newPosition);
    }
}
