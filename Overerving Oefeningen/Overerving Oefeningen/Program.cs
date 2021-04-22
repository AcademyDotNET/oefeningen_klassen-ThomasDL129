using System;
using System.Collections.Generic;

namespace Overerving_Oefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(6);
            Mammal mammal = new Mammal("Ros", 2);
            Reptile reptile = new Reptile(6000, 4);

            animal.ToonInfo();
            mammal.ToonInfo();
            reptile.ToonInfo();

            var lijst = new List<Animal>();

            lijst.Add(animal);
            lijst.Add(mammal);
            lijst.Add(reptile);

            foreach (var item in lijst)
            {
                item.ToonInfo();
            }

        }
    }
}
