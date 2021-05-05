using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster : MapElement, IMoveable
    {
        public Monster(char drawchar = 'M') : base(drawchar)
        {
            Lives = 1;
        }

        public bool HasMoved { get; set; }
        public int MoveChance { get; set; } = 5;

        public override void Draw()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(drawChar);
            Console.ResetColor();
        }

        public virtual void MoveDown()
        {
            if (Location.Y != 19)
            {
                if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y + 1] is Player)
                {
                    Console.SetCursorPosition(Location.X, Location.Y + 1);
                    Animation.HitAnim();
                    GameManager.SubtractLife(GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y + 1]);
                }
                else if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y + 1] == null)
                {
                    Location.Y++;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y] = this;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y - 1] = null;
                }
            }
        }

        public virtual void MoveLeft()
        {
            if (Location.X != 0)
            {
                if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X - 1, Location.Y] is Player)
                {
                    Console.SetCursorPosition(Location.X - 1, Location.Y);
                    Animation.HitAnim();
                    GameManager.SubtractLife(GameManager.Stages[GameManager.CurrentStage].Map[Location.X - 1, Location.Y]);
                }
                else if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X - 1, Location.Y] == null)
                {
                    Location.X--;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y] = this;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X + 1, Location.Y] = null;
                }
            }
        }

        public virtual void MoveRight()
        {
            if (Location.X != 19)
            {
                if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X + 1, Location.Y] is Player)
                {
                    Console.SetCursorPosition(Location.X + 1, Location.Y);
                    Animation.HitAnim();
                    GameManager.SubtractLife(GameManager.Stages[GameManager.CurrentStage].Map[Location.X + 1, Location.Y]);
                }
                else if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X + 1, Location.Y] == null)
                {
                    Location.X++;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y] = this;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X - 1, Location.Y] = null;
                }
            }
        }

        public virtual void MoveUp()
        {
            if (Location.Y != 0)
            {
                if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y - 1] is Player)
                {
                    Console.SetCursorPosition(Location.X, Location.Y - 1);
                    Animation.HitAnim();
                    GameManager.SubtractLife(GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y - 1]);
                }
                else if (GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y - 1] == null)
                {
                    Location.Y--;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y] = this;
                    GameManager.Stages[GameManager.CurrentStage].Map[Location.X, Location.Y + 1] = null;
                }
            }

        }

        public void MoveLogic()
        {
            Random rand = new Random();
            int direction = rand.Next(0, MoveChance);

            if (!HasMoved)
            {
                HasMoved = true;

                switch (direction)
                {
                    case 1:
                        MoveUp();
                        break;
                    case 2:
                        MoveRight();
                        break;
                    case 3:
                        MoveDown();
                        break;
                    case 4:
                        MoveLeft();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
