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
            MoveChance = 16;
            Lives = 2;
        }

        public int ShootDistance { get; set; } = 3;

        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(drawChar);
            Console.ResetColor();
        }

        public void Shoot(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    for (int i = 1; i < 20 - (19 - Location.Y); i++)
                    {
                        Console.SetCursorPosition(Location.X, Location.Y - i);
                        if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y - i] != null)
                        {
                            GameManager.SubtractLife(GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y - i]);
                            Animation.HitAnim();
                            return;
                        }
                        Animation.VertLaserAnim();
                    }
                    break;
                case Direction.East:
                    for (int i = 1; i < 20 - Location.X; i++)
                    {
                        Console.SetCursorPosition(Location.X + i, Location.Y);
                        if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X + i, Location.Y] != null)
                        {
                            GameManager.SubtractLife(GameManager.Stages[GameManager.CurrentStage].Map[Location.X + i, Location.Y]);
                            Animation.HitAnim();
                            return;
                        }
                        Animation.HoriLaserAnim();
                    }
                    break;
                case Direction.South:
                    for (int i = 1; i < 20 - Location.Y; i++)
                    {
                        Console.SetCursorPosition(Location.X, Location.Y + i);
                        if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y + i] != null)
                        {
                            GameManager.SubtractLife(GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y + i]);
                            Animation.HitAnim();
                            return;
                        }
                        Animation.VertLaserAnim();
                    }
                    break;
                case Direction.West:
                    for (int i = 1; i < 20 - (19 - Location.X); i++)
                    {
                        Console.SetCursorPosition(Location.X - i, Location.Y);
                        if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X - i, Location.Y] != null)
                        {
                            GameManager.SubtractLife(GameManager.Stages[GameManager.CurrentStage].Map[Location.X - i, Location.Y]);
                            Animation.HitAnim();
                            return;
                        }
                        Animation.HoriLaserAnim();
                    }
                    break;
                default:
                    break;
            }
        }

        public bool IsInShootingDistance(MapElement element)
        {
            if (element.Location.X == Location.X && Math.Abs(element.Location.Y - Location.Y) <= ShootDistance ||
               element.Location.Y == Location.Y && Math.Abs(element.Location.X - Location.X) <= ShootDistance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShootLogic(MapElement element)
        {
            if (element.Location.X == Location.X && element.Location.Y < Location.Y)
            {
                Shoot(Direction.North);
            }
            else if (element.Location.Y == Location.Y && element.Location.X > Location.X)
            {
                Shoot(Direction.East);
            }
            else if (element.Location.X == Location.X && element.Location.Y > Location.Y)
            {
                Shoot(Direction.South);
            }
            else if (element.Location.Y == Location.Y && element.Location.X < Location.X)
            {
                Shoot(Direction.West);
            }
        }

        public override void MoveDown()
        {
            if (Location.Y != 19)
            {
                if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y + 1] == null)
                {
                    Location.Y++;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y] = this;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y - 1] = null;
                }
            }
        }

        public override void MoveLeft()
        {
            if (Location.X != 0)
            {
                if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X - 1, Location.Y] == null)
                {
                    Location.X--;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y] = this;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X + 1, Location.Y] = null;
                }
            }
        }

        public override void MoveRight()
        {
            if (Location.X != 19)
            {
                if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X + 1, Location.Y] == null)
                {
                    Location.X++;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y] = this;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X - 1, Location.Y] = null;
                }
            }
        }

        public override void MoveUp()
        {
            if (Location.Y != 0)
            {
                if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y - 1] == null)
                {
                    Location.Y--;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y] = this;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y + 1] = null;
                }
            }

        }
    }
}
