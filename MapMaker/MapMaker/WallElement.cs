using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapMaker
{
    class WallElement : MapObject
    {
        public WallElement()
        {
            DrawChar = '#';
        }
        public WallElement(Point temploc, char drawchar = '#', double price = 10)
        {
            Location = temploc;
            DrawChar = drawchar;
            Price = price;
        }

        public override void Paint()
        {
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
        }

        //public static void UpdateWallChar(List<MapObject> lijst)
        //{
        //    for (int i = 0; i < lijst.Count; i++)
        //    {
        //        if(lijst[i] is WallElement)
        //        {
        //            if (lijst.Contains())
        //            {

        //            }
        //        }
        //    }
        //}

        public static List<MapObject> MuurOpvullen(Point origin, int breedte, int lengte)
        {
            var muur = new List<MapObject>();

            //build outer wall
            for (int i = 0; i < lengte; i++)
            {
                if (i == 0 || i == lengte - 1)
                {
                    for (int j = 0; j < breedte; j++)
                    {
                        muur.Add(new WallElement(new Point(origin.X + j, origin.Y + i)));
                    }
                }
                else
                {
                    muur.Add(new WallElement(new Point(origin.X, origin.Y + i)));
                    muur.Add(new WallElement(new Point(origin.X + breedte - 1, origin.Y + i)));
                }
            }

            //UpdateWallChar(muur);

            //assign aesthetic character
            for (int i = 0; i < muur.Count; i++)
            {
                if (muur[i].Location.Y == origin.Y || muur[i].Location.Y == origin.Y + lengte - 1)
                {
                    muur[i].DrawChar = '═';
                }
                if (muur[i].Location.X == origin.X && muur[i].Location.Y == origin.Y)
                {
                    muur[i].DrawChar = '╔';
                }
                else if (muur[i].Location.X == origin.X + breedte - 1 && muur[i].Location.Y == origin.Y)
                {
                    muur[i].DrawChar = '╗';
                }
                else if (muur[i].Location.X == origin.X && muur[i].Location.Y == origin.Y + lengte - 1)
                {
                    muur[i].DrawChar = '╚';
                }
                else if (muur[i].Location.X == origin.X + breedte - 1 && muur[i].Location.Y == origin.Y + lengte - 1)
                {
                    muur[i].DrawChar = '╝';
                }
                else if (muur[i].Location.Y != origin.Y && muur[i].Location.Y != origin.Y + lengte - 1)
                {
                    muur[i].DrawChar = '║';
                }
            }

            return muur;
        }
    }
}
