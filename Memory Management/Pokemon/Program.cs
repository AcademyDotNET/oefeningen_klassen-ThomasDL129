using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon ninetales = new Pokemon();
            ninetales.StelIn("Ninetales", "Fire", 38, 73, 76, 75, 81, 100, 100, 1);

            Pokemon gengar = new Pokemon();
            gengar.StelIn("Gengar", "Ghost", 94, 60, 65, 60, 130, 75, 110, 1);


            Console.WriteLine(ninetales.Average);
            Console.WriteLine(ninetales.Total);
            Console.WriteLine(gengar.Average);
            Console.WriteLine(gengar.Total);

            LevelupTester(ninetales);
            ninetales.ShowInfo();
        }

        private static void LevelupTester(Pokemon pokemon)
        {
            while(pokemon.Level != 100)
            {
                pokemon.VerhoogLevel();
            }
        }
    }
}
