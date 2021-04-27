using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    abstract class MapObject
    {
        private Point location;
        private double price;
        private char drawChar;

        public Point Location { get; set; }
        public double Price { get; set; }
        public char DrawChar { get; set; }

        public MapObject()
        {
            Location = new Point(1, 1);
            DrawChar = '*';
        }

        //Teken object in de console
        public abstract void Paint();
    }
}
