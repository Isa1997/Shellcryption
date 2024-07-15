using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using prog_painer_lib.Parser.tokens;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Canvas
{
    public class Canvass : ICanvasPainter, IDisposable
    {
        Dictionary<string, Color> colors = new Dictionary<string, Color>();

        private Point cursor = new(0, 0);
        private Color cursorColor = Color.Black;
        private int brushSize = 1;
        Graphics canvas = null;
        Bitmap bitmap = null;

        public void Initialize(string filename)
        {
            bitmap = new(200, 200);
            canvas = Graphics.FromImage(bitmap);
        }

        public void Dispose()
        {
            canvas.Dispose();
            bitmap.Dispose();

        }
        public void Execute(PainterParser compiler)
        {
            canvas.Clear(Color.White);

            foreach (IInstructionToken node in compiler.tokenParsers)
            {
                node.Execute(this);
            }

            canvas.Flush();

            bitmap.Save("generated.bmp", ImageFormat.Bmp);
        }

        public Color GetColor(string name)
        {
            if (colors.ContainsKey(name))
            {
                return colors[name];
            }

            return new Color();
        }

        public void SetColor(string name, Color color)
        {
            colors[name] = color;
        }
        public void Paint(Vector2 delta, Color color)
        {

        }
        private Point CreatePoint(Vector2 delta) => new Point(cursor.X + (int)delta.X, cursor.Y + (int)delta.Y);

        public void Paint(Vector2 delta)
        {
            Point newdestiation = CreatePoint(delta);
            canvas.DrawLine(new Pen(cursorColor, brushSize), cursor, newdestiation);
            cursor = newdestiation;
        }

        public void SetCursorColor(Color color)
        {
            cursorColor = color;
        }

        public void SetCursorPosition(Point newPosition)
        {
            cursor = newPosition;
        }
    }
}
