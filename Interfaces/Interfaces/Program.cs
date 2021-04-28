using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var rechthoeken = new List<Rechthoek>();
            var rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                rechthoeken.Add(new Rechthoek(rand.Next(1, 11), rand.Next(1, 11)));
                rechthoeken[i].BerekenOppervlakte();
                Console.WriteLine(rechthoeken[i]);
            }

            rechthoeken.Sort();
            Console.WriteLine();
            foreach (var item in rechthoeken)
            {
                Console.WriteLine(item);
            }
        }
    }
}
