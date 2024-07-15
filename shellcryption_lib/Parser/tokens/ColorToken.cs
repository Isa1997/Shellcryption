﻿using prog_painer_lib.Canvas;
using prog_painer_lib.extensions;
using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.tokens
{
    public class ColorToken : IColorProviderToken
    {
        private string value = "";
        public Color Evaluate(ICanvasPainter painter)
        {
            return value.GetColorValue();
        }

        public void Parse(Tokenizator input)
        {
            value = input.GetNextToken();
        }
    }
}