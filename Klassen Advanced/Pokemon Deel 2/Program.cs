using System;

namespace Pokemon_Deel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// TESTS
            //Pokemon def = new Pokemon();
            //Pokemon con = new Pokemon(45, 42, 50, 65, 34, 67);
            //Pokemon syn = new Pokemon() { PokedexNumber = 137, Name = "Porygon" };

            //def.ShowInfo();
            //con.ShowInfo();
            //syn.ShowInfo();


            //Pokemon.NoLevellingAllowed = true;
            BattleLoop();
        }

        private static void BattleLoop()
        {
            const int maxLevel = 20;
            const int minLevel = 1;

            Pokemon poke1 = null;
            Pokemon poke2 = null;
            bool gameOver = false;

            do
            {
                int stand;

                // Pokemon init or Check if a pokemon was purged
                if (poke1 == null)
                {
                    poke1 = Pokemon.GeneratorPokemon(Pokemon.AantalLevelverhogingen + minLevel);
                    poke1.Name = "Pokemon " + Pokemon.AantalGegenereerdePokemon;
                }
                if (poke2 == null)
                {
                    poke2 = Pokemon.GeneratorPokemon(Pokemon.AantalLevelverhogingen + minLevel);
                    poke2.Name = "Pokemon " + Pokemon.AantalGegenereerdePokemon;
                }

                // Battle happens
                stand = Pokemon.Battle(poke1, poke2);
                BattleResult(poke1, poke2, stand);

                // Game over condition
                if (poke1.Level >= maxLevel || poke2.Level >= maxLevel)
                {
                    gameOver = true;
                }

                // Loser gets purged
                if (stand == 1)
                {
                    poke2 = null;
                }
                else if (stand == 2)
                {
                    poke1 = null;
                }

                Console.ReadLine();

            } while (!gameOver);

            // Winner/Result screen
            if (poke1 != null)
            {
                WinnerResult(poke1);
            }
            else
            {
                WinnerResult(poke2);
            }
        }

        private static void BattleResult(Pokemon poke1, Pokemon poke2, int stand)
        {
            switch (stand)
            {
                case 1:
                    Console.WriteLine($"{poke1.Name} wint.\n");
                    poke1.VerhoogLevel();
                    poke1.ShowInfo(true);
                    break;
                case 2:
                    Console.WriteLine($"{poke2.Name} wint.\n");
                    poke2.VerhoogLevel();
                    poke2.ShowInfo(true);
                    break;
                case 0:
                    Console.WriteLine($"Gelijkspel.\n");
                    break;
            }
        }

        private static void WinnerResult(Pokemon poke)
        {
            Console.Clear();
            Console.WriteLine($"{poke.Name} is de grote winnaar!");

            poke.ShowInfo();
            Pokemon.Info();
        }
    }
}
