using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballspel
{
    class Game
    {
        public int Points { get; set; }
        public int Stage { get; set; }
        public bool GameOver { get; set; }

        public Game()
        {
            Points = 0;
            Stage = 1;
            GameOver = false;
        }
    }
}
