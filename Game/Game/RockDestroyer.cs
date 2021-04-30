using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class RockDestroyer : Monster, IDestroyer, IMoveable
    {
        public RockDestroyer(char drawchar = 'D') : base(drawchar)
        {
        }

        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(drawChar);
            Console.ResetColor();
        }

        public void Shoot(int direction)
        {
            switch (direction)
            {
                case 1:
                    for (int i = 1; i < 20 - (19 - Location.Y); i++)
                    {
                        Console.SetCursorPosition(Location.X, Location.Y - i);
                        if (GameManager.Map[Location.X, Location.Y - i] != null)
                        {
                            if (GameManager.Map[Location.X, Location.Y - i] is Player)
                            {
                                GameManager.GameOver = true;
                            }
                            GameManager.Map[Location.X, Location.Y - i] = null;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('+');
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(150);
                            return;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write('!');
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(50);
                    }
                    break;
                case 2:
                    for (int i = 1; i < 20 - Location.X; i++)
                    {
                        Console.SetCursorPosition(Location.X + i, Location.Y);
                        if (GameManager.Map[Location.X + i, Location.Y] != null)
                        {
                            if (GameManager.Map[Location.X + i, Location.Y] is Player)
                            {
                                GameManager.GameOver = true;
                            }
                            GameManager.Map[Location.X + i, Location.Y] = null;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('+');
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(150);
                            return;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write('-');
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(50);
                    }
                    break;
                case 3:
                    for (int i = 1; i < 20 - Location.Y; i++)
                    {
                        Console.SetCursorPosition(Location.X, Location.Y + i);
                        if (GameManager.Map[Location.X, Location.Y + i] != null)
                        {
                            if (GameManager.Map[Location.X, Location.Y + i] is Player)
                            {
                                GameManager.GameOver = true;
                            }
                            GameManager.Map[Location.X, Location.Y + i] = null;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('+');
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(150);
                            return;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write('!');
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(50);
                    }
                    break;
                case 4:
                    for (int i = 1; i < 20 - (19 - Location.X); i++)
                    {
                        Console.SetCursorPosition(Location.X - i, Location.Y);
                        if (GameManager.Map[Location.X - i, Location.Y] != null)
                        {
                            if (GameManager.Map[Location.X - i, Location.Y] is Player)
                            {
                                GameManager.GameOver = true;
                            }
                            GameManager.Map[Location.X - i, Location.Y] = null;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write('+');
                            Console.ResetColor();
                            System.Threading.Thread.Sleep(150);
                            return;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write('-');
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(50);
                    }
                    break;
                default:
                    break;
            }            
        }
        public override void MoveDown()
        {
            if (Location.Y != 19)
            {
                if (GameManager.Map[Location.X, Location.Y + 1] == null)
                {
                    Location.Y++;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X, Location.Y - 1] = null;
                }
            }
        }

        public override void MoveLeft()
        {
            if (Location.X != 0)
            {
                if (GameManager.Map[Location.X - 1, Location.Y] == null)
                {
                    Location.X--;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X + 1, Location.Y] = null;
                }
            }
        }

        public override void MoveRight()
        {
            if (Location.X != 19)
            {
                if (GameManager.Map[Location.X + 1, Location.Y] == null)
                {
                    Location.X++;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X - 1, Location.Y] = null;
                }
            }
        }

        public override void MoveUp()
        {
            if (Location.Y != 0)
            {
                if (GameManager.Map[Location.X, Location.Y - 1] == null)
                {
                    Location.Y--;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X, Location.Y + 1] = null;
                }
            }

        }
    }
}
