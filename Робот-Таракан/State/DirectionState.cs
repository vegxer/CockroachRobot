using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Робот_Таракан
{
    abstract class DirectionState
    {
        protected Dictionary<string, Direction> Trends = new Dictionary<string, Direction>()
        {
            {"Up", Direction.Up },
            {"Down", Direction.Down },
            {"Left", Direction.Left },
            {"Right", Direction.Right }
        };
        protected const int step = 30;
        protected Bitmap image;

        public abstract void Step(ref int X, ref int Y, Size fieldSize);
        public abstract DirectionState ChangeTrend(string command);
        public abstract Direction Trend { get; }
    }
}
