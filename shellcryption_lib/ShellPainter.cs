using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prog_painer_lib.Canvas;
using prog_painer_lib.Parser.parser;

namespace prog_painer_lib
{
    public class ShellPainter
    {
        public static void Paint(string fileName)
        {
            string input =  File.ReadAllText(fileName, Encoding.UTF8);

            PainterParser painter = new PainterParser();
            if(painter.Initialize(input))
            {
                using (Canvass canvasPainter = new Canvass())
                {
                    canvasPainter.Initialize(fileName);
                    canvasPainter.Execute(painter);
                }
            }
        }
    }
}
