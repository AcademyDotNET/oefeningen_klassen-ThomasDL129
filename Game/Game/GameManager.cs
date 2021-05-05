using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameManager
    {
        public static Player Speler { get; set; }
        public static int CurrentStage { get; set; } = 0;
        public static bool GameOver { get; set; }
        public static List<Stage> Stages { get; set; }

        public GameManager()
        {
            Stages = new List<Stage>();
            Stages.Add(new Stage());

            Speler = new Player()
            {
                Location = new Point(0, 10)
            };
            Stages[CurrentStage].Map[0, 10] = Speler;
        }

        public void DrawMap()
        {
            for (int i = 0; i <= Stages[CurrentStage].Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Stages[CurrentStage].Map.GetUpperBound(1); j++)
                {
                    if (Stages[CurrentStage].Map[i, j] != null)
                    {
                        if (Stages[CurrentStage].Map[i, j].Lives <= 0)
                        {
                            Stages[CurrentStage].Map[i, j] = null;
                            Console.SetCursorPosition(i, j);
                            Console.Write(' ');
                        }
                        else
                        {
                            Stages[CurrentStage].Map[i, j].Draw();
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(' ');
                    }
                }
            }
        }

        public static void PrintUI()
        {
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Wat wil je doen? (ZQSD om te bewegen, IJKL om te schieten)");
            Console.WriteLine(">>>");
        }

        public void ResetTurns()
        {
            for (int i = 0; i <= Stages[CurrentStage].Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Stages[CurrentStage].Map.GetUpperBound(1); j++)
                {
                    if (Stages[CurrentStage].Map[i, j] is IMoveable)
                    {
                        var temp = Stages[CurrentStage].Map[i, j] as IMoveable;
                        temp.HasMoved = false;
                        //Map[i, j] = temp as MapElement;
                    }
                }
            }
        }

        public void EnemyMoves()
        {
            for (int i = 0; i <= Stages[CurrentStage].Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Stages[CurrentStage].Map.GetUpperBound(1); j++)
                {
                    if (Stages[CurrentStage].Map[i, j] is RockDestroyer)
                    {
                        RockDestroyer r = Stages[CurrentStage].Map[i, j] as RockDestroyer;

                        //als speler binnen de ShootDistance vakken naast destroyer staat gaat destroyer schieten
                        if (r.IsInShootingDistance(Speler))
                        {
                            r.ShootLogic(Speler);
                        }
                        else
                        {
                            r.MoveLogic();
                        }
                    }
                    else if (Stages[CurrentStage].Map[i, j] is Monster)
                    {
                        Monster m = Stages[CurrentStage].Map[i, j] as Monster;
                        m.MoveLogic();
                    }
                }
            }
        }

        public void UserInput()
        {
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.Z:
                    Speler.MoveUp();
                    break;
                case ConsoleKey.S:
                    Speler.MoveDown();
                    break;
                case ConsoleKey.Q:
                    Speler.MoveLeft();
                    break;
                case ConsoleKey.D:
                    Speler.MoveRight();
                    break;
                case ConsoleKey.I:
                    Speler.Shoot(Direction.North);
                    break;
                case ConsoleKey.L:
                    Speler.Shoot(Direction.East);
                    break;
                case ConsoleKey.K:
                    Speler.Shoot(Direction.South);
                    break;
                case ConsoleKey.J:
                    Speler.Shoot(Direction.West);
                    break;
                default:
                    break;
            }
        }

        public static void SubtractLife(MapElement element)
        {
            element.Lives--;
        }
    }
}
