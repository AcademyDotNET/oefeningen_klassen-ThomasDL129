using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    class ZetelElement : FurnitureElement
    {
        public ZetelElement()
        {
            Price = 100;
            DrawChar = '+';
            UnitSize = 2;
        }

        public ZetelElement(Point point, int size, char drawChar = '+')
        {
            Location = point;
            UnitSize = size;
            DrawChar = drawChar;
        }
    }
}
