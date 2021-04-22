using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballspel
{
    class GameStage
    {
        public int TimeBonus { get; set; }
        public bool StageOver { get; set; } = false;

        public GameStage(int timeBonus)
        {
            TimeBonus = timeBonus;
        }
    }
}
