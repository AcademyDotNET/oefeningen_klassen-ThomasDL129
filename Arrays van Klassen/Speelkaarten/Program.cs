using System;
using System.Collections.Generic;

namespace Speelkaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            var pak = new List<Speelkaart>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    pak.Add(new Speelkaart(j + 1, (Kleur)i));
                }
            }


            var r = new Random();

            while (pak.Count != 0)
            {
                var kaart = r.Next(0, pak.Count);

                Console.WriteLine($"{pak[kaart].Getal} {pak[kaart].Suite}");

                pak.RemoveAt(kaart);
            }
        }
    }
}
