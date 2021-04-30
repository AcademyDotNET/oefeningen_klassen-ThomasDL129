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

            game.GenerateMapElements();
            game.DrawMap();

            do
            {
                game.PrintUI();

                //player actions
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(false);
                }
                game.UserInput();
                game.DrawMap();

                //monster actions
                game.EnemyMoves(); 
                
                if (GameManager.GameOver)
                {
                    GameOverScreen();
                }
                game.DrawMap();

                
                if (GameManager.Speler.Location.X == 19)//kan beter
                {
                    WinScreen();
                }
            } while (true);
        }

        private static void GameOverScreen()
        {
            throw new NotImplementedException();
        }

        private static void WinScreen()
        {
            throw new NotImplementedException();
        }
    }
}
