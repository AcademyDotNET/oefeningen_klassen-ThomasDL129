using System;

namespace Pokemon_Battler
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon poke1 = GeneratorPokemon();
            Pokemon poke2 = GeneratorPokemon();

            poke1.Name = "Pokemon 1";
            poke2.Name = "Pokemon 2";
            
            BattleLoop(poke1, poke2);
            WinnerResult(poke1, poke2);
        }

        private static void WinnerResult(Pokemon poke1, Pokemon poke2)
        {
            Console.Clear();
            if (poke1.Level == 100)
            {
                Console.WriteLine($"{poke1.Name} is de grote winnaar!");
                poke1.ShowInfo();
            }
            else
            {
                Console.WriteLine($"{poke2.Name} is de grote winnaar!");
                poke2.ShowInfo();
            }
        }

        private static void BattleLoop(Pokemon poke1, Pokemon poke2)
        {
            int rondes = 0;
            int victories = 0;

            while (poke1.Level != 100 && poke2.Level != 100)
            {
                rondes++;
                PrintRound(poke1, poke2, rondes);

                int stand = Battle(poke1, poke2);
                BattleResult(poke1, poke2, stand);
                Console.ReadLine();

                if (stand == 1)
                {
                    victories++;
                    poke2 = GeneratorPokemon(poke1.Level);
                    poke2.Name = $"Pokemon {victories + 2}";
                }
                else if (stand == 2)
                {
                    victories++;
                    poke1 = GeneratorPokemon(poke2.Level);
                    poke1.Name = $"Pokemon {victories + 2}";
                }
            }
        }

        private static void PrintRound(Pokemon poke1, Pokemon poke2, int rondes)
        {
            Console.Clear();
            poke1.ShowInfo();
            poke2.ShowInfo();

            Console.WriteLine($"Ronde {rondes}:\n");
            Console.ReadLine();
        }

        private static void BattleResult(Pokemon poke1, Pokemon poke2, int stand)
        {
            switch (stand)
            {
                case 1:
                    Console.WriteLine($"{poke1.Name} wint.\nLevel up!\n");
                    poke1.VerhoogLevel();
                    poke1.ShowInfo(true);
                    break;
                case 2:
                    Console.WriteLine($"{poke2.Name} wint.\nLevel up!\n");
                    poke2.VerhoogLevel();
                    poke2.ShowInfo(true);
                    break;
                case 0:
                    Console.WriteLine($"Gelijkspel.\n");
                    break;
            }
        }

        static int Battle(Pokemon poke1, Pokemon poke2)
        {
            Random rand = new Random();
            double verschil = poke1.Full_Average - poke2.Full_Average;
            if (poke1 != null && poke2 != null)
            {
                if (verschil > 0)
                {
                    double contest = poke2.Full_Average / poke1.Full_Average;
                    double roll = rand.NextDouble();
                    if(roll < 0.1)
                    {
                        return 0;
                    }
                    else if(roll <= contest)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                if (verschil < 0)
                {
                    double contest = poke1.Full_Average / poke2.Full_Average;
                    double roll = rand.NextDouble();
                    if (roll < 0.1)
                    {
                        return 0;
                    }
                    else if (roll <= contest)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    if (rand.Next(1, 101) > 50)
                    {
                        if (rand.Next(1, 3) == 1)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else if (poke1 == null)
            {
                return 2;
            }
            else if (poke2 == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static Pokemon GeneratorPokemon(int level = 0)
        {
            Pokemon gen = new Pokemon();
            Random rand = new Random();

            gen.HP_Base = rand.Next(1, 256);
            gen.Attack_Base = rand.Next(5, 191);
            gen.Defense_Base = rand.Next(5, 231);
            gen.SpecialAttack_Base = rand.Next(10, 174);
            gen.SpecialDefense_Base = rand.Next(20, 231);
            gen.Speed_Base = rand.Next(5, 201);

            if (level > 0)
            {
                gen.VerhoogLevel(level - 1);
            }

            return gen;
        }
    }
}
