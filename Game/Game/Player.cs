﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player : MapElement, IMoveable, IDestroyer
    {
        public Player(char drawchar = 'X') : base(drawchar)
        {
            Lives = 3;
        }


        public bool HasMoved { get; set; }


        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(drawChar);
            Console.ResetColor();
        }

        public void MoveDown()
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

        public void MoveLeft()
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

        public void MoveRight()
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

        public void MoveUp()
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
    }
}
