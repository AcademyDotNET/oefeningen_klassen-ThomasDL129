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
        public List<Ball> StageBalls { get; set; }
        public List<EnemyBall> StageEnemies { get; set; }

        public GameStage(int timeBonus)
        {
            TimeBonus = timeBonus;
            StageBalls = new List<Ball>();
            StageEnemies = new List<EnemyBall>();
        }

        public void FillBalls(int stage)
        {
            switch (stage)
            {
                case 1:
                    StageBalls.Add(new(4, 4, 1, 0));
                    StageBalls.Add(new(6, 8, 0, 1));
                    break;
                case 2:
                    StageBalls.Add(new(9, 0, -1, 1));
                    StageBalls.Add(new(12, 8, 0, 1));
                    StageBalls.Add(new(1, 15, 1, 1));
                    StageBalls.Add(new(22, 16, 1, 0));
                    break;
                case 3:
                    StageBalls.Add(new(12, 16, 1, -1));
                    StageBalls.Add(new(2, 2, 0, 1));
                    StageBalls.Add(new(1, 15, -1, 1));
                    StageBalls.Add(new(22, 16, 1, 0));
                    break;
                default:
                    break;
            }
        }

        public void FillEnemies(int stage)
        {
            switch (stage)
            {
                case 1:
                    StageEnemies.Add(new(12, 12, 1, 1));
                    break;
                case 2:
                    StageEnemies.Add(new(22, 5, 1, 1));
                    StageEnemies.Add(new(5, 16, -1, -1));
                    break;
                case 3:
                    StageEnemies.Add(new(1, 1, 1, 1));
                    StageEnemies.Add(new(28, 2, -1, 1));
                    StageEnemies.Add(new(28, 18, -1, -1));
                    break;
                default:
                    break;
            }
        }

        public void StageSplash(int stage)
        {
            Console.SetCursorPosition(11, 9);
            Console.Write($"Stage {stage}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
