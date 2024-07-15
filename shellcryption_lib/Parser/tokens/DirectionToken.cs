using prog_painer_lib.extensions;
using prog_painer_lib.Parser.interfaces;
using prog_painer_lib.Parser.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace prog_painer_lib.Parser.tokens
{
    public enum EDirection
    {
        Left,
        Right,
        Up,
        Down,
        Invalid
    }
    public class DirectionToken : IDirectionToken
    {
        EDirection direction = EDirection.Invalid;
        int step = 1;
        public Vector2 Evaluate()
        {
            int directionX = GetDirectionX() * step;
            int directionY = GetDirectionY() * step;

            return new(directionX, directionY);
        }

        public void Parse(Tokenizator input)
        {
            direction = input.GetNextToken().ToEDirection();
            step = int.Parse(input.GetNextToken());
        }

        private int GetDirectionX()
        {
            if(direction == EDirection.Left)
            {
                return -1;
            }
            else if(direction == EDirection.Right)
            {
                return 1;
            }

            return 0;
        }

        private int GetDirectionY()
        {
            if (direction == EDirection.Up)
            {
                return -1;
            }
            else if (direction == EDirection.Down)
            {
                return 1;
            }

            return 0;
        }
    }
}
