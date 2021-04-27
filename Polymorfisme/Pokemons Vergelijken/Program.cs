using System;

namespace Pokemons_Vergelijken
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon poke1 = new Pokemon(5, 5, 5, 5, 5, 5);
            Pokemon poke2 = null;

            poke1.Name = "Pikachu";
            poke1.VerhoogLevel(24);

            Console.WriteLine(poke1.Equals(poke2));

            Dier dier = new Dier();
            Console.WriteLine(poke1.Equals(dier));

            poke2 = new Pokemon(5, 5, 5, 5, 5, 5);
            poke2.Name = "Pikachu";
            poke2.VerhoogLevel(24);

            Console.WriteLine(poke2.Equals(poke1));
        }
    }
}
