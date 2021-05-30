using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Робот_Таракан
{
    class DirectionLeft : DirectionState
    {
        public DirectionLeft(Bitmap image)
        {
            base.image = image;
        }

        public override DirectionState ChangeTrend(string command)
        {
            Direction newtrend = Trends[command];
            switch (newtrend)
            {
                case Direction.Down:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    return new DirectionDown(image);
                case Direction.Up:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    return new DirectionUp(image);
                case Direction.Right:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    return new DirectionRight(image);
                default:
                    return new DirectionLeft(image);
            }
        }

        public override void Step(ref int X, ref int Y, Size fieldSize)
        {
            if (X - step >= -image.Width / 2)
                X -= step;
            else
                X = -image.Width / 2;
        }

        public override Direction Trend
        {
            get
            {
                return Direction.Left;
            }
        }
    }
}
