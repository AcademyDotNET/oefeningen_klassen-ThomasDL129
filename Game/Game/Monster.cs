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
        }
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
                if (GameManager.Map[Location.X, Location.Y + 1] is Player)
                {
                    GameManager.GameOver = true;
                    Location.Y++;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X, Location.Y - 1] = null;
                }
                else if (GameManager.Map[Location.X, Location.Y + 1] == null)
                {
                    Location.Y++;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X, Location.Y - 1] = null;
                }
            }
        }

        public virtual void MoveLeft()
        {
            if (Location.X != 0)
            {
                if (GameManager.Map[Location.X - 1, Location.Y] is Player)
                {
                    GameManager.GameOver = true;
                    Location.X--;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X + 1, Location.Y] = null;
                }
                else if (GameManager.Map[Location.X - 1, Location.Y] == null)
                {
                    Location.X--;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X + 1, Location.Y] = null;
                }
            }
        }

        public virtual void MoveRight()
        {
            if (Location.X != 19)
            {
                if (GameManager.Map[Location.X + 1, Location.Y] is Player)
                {
                    GameManager.GameOver = true;
                    Location.X++;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X - 1, Location.Y] = null;
                }
                else if (GameManager.Map[Location.X + 1, Location.Y] == null)
                {
                    Location.X++;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X - 1, Location.Y] = null;
                }
            }
        }

        public virtual void MoveUp()
        {
            if (Location.Y != 0)
            {
                if (GameManager.Map[Location.X, Location.Y - 1] is Player)
                {
                    GameManager.GameOver = true;

                    Location.Y--;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X, Location.Y + 1] = null;
                }
                else if (GameManager.Map[Location.X, Location.Y - 1] == null)
                {
                    Location.Y--;
                    GameManager.Map[Location.X, Location.Y] = this;
                    GameManager.Map[Location.X, Location.Y + 1] = null;
                }
            }
            
        }
    }
}
