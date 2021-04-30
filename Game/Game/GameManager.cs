using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameManager
    {
        public static MapElement[,] Map { get; set; }
        public static Player Speler { get; set; }
        public static bool GameOver { get; set; }

        private int aantalRocks = 20;
        private int aantalMonsters = 12;
        private int aantalDestroyers = 15;


        public GameManager()
        {
            Map = new MapElement[20, 20];
            Speler = new Player()
            {
                Location = new Point(0, 10)
            };
            Map[0, 10] = Speler;
        }

        public void DrawMap()
        {
            for (int i = 0; i <= Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Map.GetUpperBound(1); j++)
                {
                    if (Map[i, j] != null)
                    {
                        Map[i, j].Draw();
                    }
                    else
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(' ');
                    }
                }
            }
        }

        public void PrintUI()
        {
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Wat wil je doen? (Pijltjestoetsen om te bewegen, Spatiebalk om te schieten)");
            Console.WriteLine(">>>");
        }

        public void GenerateMapElements()
        {
            Random r = new Random();

            for (int i = 0; i < aantalRocks;)
            {
                int x = r.Next(1, 20);
                int y = r.Next(0, 20);

                if (Map[x, y] == null)
                {
                    Map[x, y] = new Rock()
                    {
                        Location = new Point(x, y)
                    };
                    i++;
                }
            }

            for (int i = 0; i < aantalMonsters;)
            {
                int x = r.Next(1, 20);
                int y = r.Next(0, 20);

                if (Map[x, y] == null)
                {
                    Map[x, y] = new Monster()
                    {
                        Location = new Point(x, y)
                    };
                    i++;
                }
            }

            for (int i = 0; i < aantalDestroyers;)
            {
                int x = r.Next(1, 20);
                int y = r.Next(0, 20);

                if (Map[x, y] == null)
                {
                    Map[x, y] = new RockDestroyer()
                    {
                        Location = new Point(x, y)
                    };
                    i++;
                }
            }
        }

        public void EnemyMoves()
        {
            Random rand = new Random();

            for (int i = 0; i <= Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Map.GetUpperBound(1); j++)
                {
                    if (Map[i, j] is RockDestroyer)
                    {
                        RockDestroyer r = Map[i, j] as RockDestroyer;

                        //als speler binnen de 6 vakken naast destroyer staat gaat destroyer schieten
                        if (Speler.Location.X == r.Location.X && Math.Abs(Speler.Location.Y - r.Location.Y) <= 5 || 
                            Speler.Location.Y == r.Location.Y && Math.Abs(Speler.Location.X - r.Location.X) <= 5)
                        {
                            if (Speler.Location.X == r.Location.X && Speler.Location.Y < r.Location.Y)
                            {
                                r.Shoot(1);
                            }
                            else if (Speler.Location.Y == r.Location.Y && Speler.Location.X > r.Location.X)
                            {
                                r.Shoot(2);
                            }
                            else if (Speler.Location.X == r.Location.X && Speler.Location.Y > r.Location.Y)
                            {
                                r.Shoot(3);
                            }
                            else if (Speler.Location.Y == r.Location.Y && Speler.Location.X < r.Location.X)
                            {
                                r.Shoot(4);
                            }
                        }
                        else
                        {
                            int direction = 1;// rand.Next(0, 16);
                            switch (direction)
                            {
                                case 1:
                                    r.MoveUp();
                                    break;
                                case 2:
                                    r.MoveRight();
                                    break;
                                case 3:
                                    r.MoveDown();
                                    break;
                                case 4:
                                    r.MoveLeft();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else if (Map[i, j] is Monster)
                    {
                        Monster m = Map[i, j] as Monster;

                        int direction = rand.Next(0, 5);
                        switch (direction)
                        {
                            case 1:
                                m.MoveUp();
                                break;
                            case 2:
                                m.MoveRight();
                                break;
                            case 3:
                                m.MoveDown();
                                break;
                            case 4:
                                m.MoveLeft();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    
        public void UserInput()
        {            
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    Speler.MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    Speler.MoveDown();
                    break;
                case ConsoleKey.LeftArrow:
                    Speler.MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    Speler.MoveRight();
                    break;
                case ConsoleKey.Spacebar:
                    Speler.Shoot(2);
                    break;
                default:
                    break;
            }
        }
    }
}
