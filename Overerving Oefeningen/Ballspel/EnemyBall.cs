using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballspel
{
    class EnemyBall : Ball
    {
        public EnemyBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, vxin, vyin)
        {
            drawChar = 'E';
            drawColor = ConsoleColor.DarkMagenta;
        }        
    }
}
