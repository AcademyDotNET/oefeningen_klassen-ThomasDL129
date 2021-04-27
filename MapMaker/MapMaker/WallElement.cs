using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    class WallElement : MapObject
    {
        public WallElement()
        {
            DrawChar = '#';
        }
        public WallElement(Point temploc, char drawchar, double price)
        {
            Location = temploc;
            DrawChar = drawchar;
            Price = price;
        }

        public override void Paint()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }
    }
}
