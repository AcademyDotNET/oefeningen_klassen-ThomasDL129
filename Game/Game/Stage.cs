using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Stage
    {
        public Stage()
        {
            Map = new MapElement[20, 20];
        }


        private int aantalRocks = 20;
        private int aantalMonsters = 12;
        private int aantalDestroyers = 15;

        public MapElement[,] Map { get; set; }

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
    }
}
