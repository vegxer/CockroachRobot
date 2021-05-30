using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Робот_Таракан
{
    class Cockroach
    {
        int x, y;
        Bitmap image;
        Size fieldSize;
        DirectionState direction;

        public Cockroach(Bitmap image, Size fieldSize)
        {
            this.image = image;
            this.fieldSize = fieldSize;
            direction = new DirectionUp(image);
        }

        public void Step()
        {
            direction.Step(ref x, ref y, fieldSize);
        }

        public void ChangeTrend(string command)
        {
            direction = direction.ChangeTrend(command);
        }

        public Direction Trend
        {
            get
            {
                return direction.Trend;
            }
        }

        public Bitmap Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                direction = new DirectionUp(image);
            }
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value >= -image.Width / 2 && value <= fieldSize.Width + image.Width / 2)
                    x = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= -image.Height / 2 && value <= fieldSize.Height + image.Height / 2)
                    y = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
