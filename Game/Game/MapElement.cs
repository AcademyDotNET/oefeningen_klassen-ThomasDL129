using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class MapElement
    {
        protected char drawChar;

        public Point Location { get; set; } = new Point();

        public MapElement(char drawchar)
        {
            drawChar = drawchar;
        }

        public abstract void Draw();
    }
}
