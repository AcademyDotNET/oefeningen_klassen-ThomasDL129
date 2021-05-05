using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Direction { North = 1, East, South, West}

    abstract class MapElement
    {
        protected char drawChar;

        public int Lives { get; set; } = 1;
        public Point Location { get; set; } = new Point();

        public MapElement(char drawchar)
        {
            drawChar = drawchar;
        }

        public abstract void Draw();
    }
}
