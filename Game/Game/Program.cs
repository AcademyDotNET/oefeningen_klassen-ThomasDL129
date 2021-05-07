using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GameManager game = new GameManager();

            GameManager.Stages[GameManager.CurrentStage].GenerateMapElements();
            game.DrawMap();            

            do
            {
                GameManager.PrintUI();
                game.ResetTurns();
                                
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(false);
                }

                //player actions
                game.UserInput();
                game.DrawMap();

                //monster actions
                game.EnemyMoves();
                game.DrawMap();

                if (GameManager.Speler.Lives <= 0)
                {
                    GameOverScreen();
                }                

                
                if (GameManager.Speler.Location.X == 19)//kan beter
                {
                    WinScreen();
                }
            } while (true);
        }

        private static void GameOverScreen()
        {
            Console.Clear();
            Console.WriteLine("Game Over.");
            Console.ReadLine();
            Environment.Exit(0);
        }

        private static void WinScreen()
        {
            Console.Clear();
            Console.WriteLine("Gewonnen!");
            Console.ReadLine(); 
            Environment.Exit(0);
        }
    }
}
