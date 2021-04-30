using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Rock : MapElement
    {
        public Rock(char drawchar = 'O') : base(drawchar)
        {
        }

        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(drawChar);
            Console.ResetColor();
        }
    }
}
