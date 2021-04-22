using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballspel
{
    class PlayerBall : Ball
    {
        private int maxVelocity = 2;

        public PlayerBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, vxin, vyin)
        {
            drawChar = 'X';
            drawColor = ConsoleColor.Green;
        }

        public void ChangeVelocity(ConsoleKeyInfo richting)
        {
            switch (richting.Key)
            {
                case ConsoleKey.UpArrow:
                    if (vy > -maxVelocity)
                    {
                        vy--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (vy < maxVelocity)
                    {
                        vy++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (vx > -maxVelocity)
                    {
                        vx--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (vx < maxVelocity)
                    {
                        vx++;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
