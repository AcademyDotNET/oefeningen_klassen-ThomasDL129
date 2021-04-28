using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    class Point
    {
        public Point(int inx, int iny)
        {
            x = inx;
            y = iny;
        }

        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override bool Equals(object obj)
        {
            Point point = obj as Point;

            if (point != null)
            {
                if (X == point.X && Y == point.Y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
