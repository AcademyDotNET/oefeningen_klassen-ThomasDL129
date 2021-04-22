using System;
using System.Collections.Generic;

namespace Ballspel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WindowHeight = 20;
            Console.WindowWidth = 30;

            var game = new Game();
            var stages = new GameStage[] { new GameStage(10000), new GameStage(10000), new GameStage(15000) };

            var stageBalls = new List<Ball>();
            stageBalls.Add(new(4, 4, 1, 0));
            stageBalls.Add(new(6, 8, 0, 1));

            var stageEnemies = new List<EnemyBall>();
            stageEnemies.Add(new(12, 12, 1, 1));

            var player = new PlayerBall(10, 10, 0, 0);

            while (!game.GameOver)
            {                
                StageSplash(game.Stage);

                while (!game.GameOver && !stages[game.Stage - 1].StageOver)
                {
                    //Ball
                    foreach (var item in stageBalls)
                    {
                        item.Update();
                        item.Draw();
                    }

                    //EnemyBall
                    foreach (var item in stageEnemies)
                    {
                        item.Update();
                        item.Draw();
                    }

                    //SpelerBall
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey();
                        player.ChangeVelocity(key);
                    }

                    player.Update();
                    player.Draw();

                    //Check collisions
                    for (int i = 0; i < stageBalls.Count; i++)
                    {
                        if (Ball.CheckHit(stageBalls[i], player))
                        {
                            game.Points += 1000;
                            stageBalls.RemoveAt(i);
                        }
                    }

                    foreach (var item in stageEnemies)
                    {
                        if (Ball.CheckHit(item, player))
                        {
                            game.GameOver = true;
                        }
                    }

                    if (stageBalls.Count == 0)
                    {
                        stages[game.Stage - 1].StageOver = true;
                        game.Stage++;
                    }
                    System.Threading.Thread.Sleep(100);
                    stages[game.Stage - 1].TimeBonus -= 10;
                }
            }

        }

        private static void StageSplash(int stage)
        {
            Console.SetCursorPosition(11, 9);
            Console.Write($"Stage {stage}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
