using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Робот_Таракан
{
    class DirectionDown : DirectionState
    {
        public DirectionDown(Bitmap image)
        {
            base.image = image;
        }

        public override DirectionState ChangeTrend(string command)
        {
            Direction newtrend = Trends[command];
            switch (newtrend)
            {
                case Direction.Right:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return new DirectionRight(image);
                case Direction.Up:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return new DirectionUp(image);
                case Direction.Left:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return new DirectionLeft(image);
                default:
                    return new DirectionDown(image);
            }
        }

        public override void Step(ref int X, ref int Y, Size fieldSize)
        {
            if (Y + step <= fieldSize.Height + image.Height / 2)
                Y += step;
            else
                Y = fieldSize.Height + image.Height / 2;
        }

        public override Direction Trend
        {
            get
            {
                return Direction.Down;
            }
        }
    }
}
