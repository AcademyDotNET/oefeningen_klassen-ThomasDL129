using System;
using System.Collections.Generic;
using System.Text;

namespace MapMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MapObject> allObjects = new List<MapObject>();
            Menu menu = new Menu();
            Point origin = new Point(8, 8);
            allObjects.AddRange(WallElement.MuurOpvullen(origin, 32, 12)); //testlijn
            allObjects.Add(new SalonElement(new Point(origin.X + 1, origin.Y + 1)));

            do
            {
                menu.ShowMenu();
                menu.GetInput(allObjects);
                Console.Clear();
                //Teken alle objecten
                for (int i = 0; i < allObjects.Count; i++)
                {
                    allObjects[i].Paint();
                }
            } while (true);


            //List<MapObject> allObjects = new List<MapObject>(); //lang leve polymorfisme

            ////Muurtje
            //for (int i = 0; i < 10; i++)
            //{
            //    Point tempLoc = new Point(2 + i, 3);
            //    WallElement tempWall = new WallElement(tempLoc, '=', 10.0);
            //    allObjects.Add(tempWall);
            //}

            ////Zetel
            //allObjects.Add(new ZetelElement(new Point(6, 8), 3));

            ////Teken alle objecten
            //for (int i = 0; i < allObjects.Count; i++)
            //{
            //    allObjects[i].Paint();
            //}
        }

        
    }
}
