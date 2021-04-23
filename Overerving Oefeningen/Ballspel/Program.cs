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


            while (!game.GameOver && game.Stage < 3)
            {
                var endOfStage = false;
                var player = new PlayerBall(10, 10, 0, 0);

                stages[game.Stage - 1].FillBalls(game.Stage);
                stages[game.Stage - 1].FillEnemies(game.Stage);
                stages[game.Stage - 1].StageSplash(game.Stage);

                while (!game.GameOver && !endOfStage)
                {
                    //Ball
                    foreach (var item in stages[game.Stage - 1].StageBalls)
                    {
                        item.Update();
                        item.Draw();
                    }

                    //EnemyBall
                    foreach (var item in stages[game.Stage - 1].StageEnemies)
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
                    for (int i = 0; i < stages[game.Stage - 1].StageBalls.Count; i++)
                    {
                        if (Ball.CheckHit(stages[game.Stage - 1].StageBalls[i], player))
                        {
                            game.Points += 1000;
                            stages[game.Stage - 1].StageBalls.RemoveAt(i);
                        }
                    }

                    //Check collisions with enemies
                    foreach (var item in stages[game.Stage - 1].StageEnemies)
                    {
                        if (Ball.CheckHit(item, player))
                        {
                            game.GameOver = true;
                        }
                    }

                    System.Threading.Thread.Sleep(100);
                    stages[game.Stage - 1].TimeBonus -= 10;

                    //Check if all balls are taken
                    if (stages[game.Stage - 1].StageBalls.Count == 0)
                    {
                        endOfStage = true;
                        game.Stage++;
                    }
                }

                if (!game.GameOver)
                {
                    ResultStage(game, stages[game.Stage - 2]);
                    game.Points += stages[game.Stage - 2].TimeBonus;
                }
                else
                {
                    GameOverScreen(game);
                }
            }

        }

        private static void GameOverScreen(Game game)
        {
            Console.Clear();
            Console.SetCursorPosition(11, 9);
            Console.WriteLine("Game Over");
            Console.SetCursorPosition(11, 11);
            Console.Write($"Score: \t{game.Points}");
            Console.ReadLine();
        }

        public static void ResultStage(Game game, GameStage stage)
        {
            Console.Clear();
            Console.SetCursorPosition(11, 9);
            Console.WriteLine("Winner!");
            Console.SetCursorPosition(11, 11);
            Console.Write($"Score: \t{game.Points}");
            Console.SetCursorPosition(11, 12);
            Console.Write($"Time Bonus:\t{stage.TimeBonus}");
        }
    }
}
