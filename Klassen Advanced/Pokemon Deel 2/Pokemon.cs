using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Deel_2
{
    class Pokemon
    {
        //statics
        private static int aantalLevelverhogingen = 0;
        private static int aantalBattles = 0;
        private static int aantalGelijkstanden = 0;
        private static int aantalGegenereerdePokemon = 0;
        public static bool NoLevellingAllowed = false;

        public static int AantalGegenereerdePokemon
        {
            get { return aantalGegenereerdePokemon; }
        }
        public static int AantalLevelverhogingen
        {
            get { return aantalLevelverhogingen; }
        }


        //general info
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int PokedexNumber { get; set; }

        //base stats
        private int hp_Base;
        private int attack_Base;
        private int defense_Base;
        private int specialAttack_Base;
        private int specialDefense_Base;
        private int speed_Base;

        public int HP_Base
        {
            get { return hp_Base; }
            set { hp_Base = value; }
        }
        public int Attack_Base
        {
            get { return attack_Base; }
            set { attack_Base = value; }
        }
        public int Defense_Base
        {
            get { return defense_Base; }
            set { defense_Base = value; }
        }
        public int SpecialAttack_Base
        {
            get { return specialAttack_Base; }
            set { specialAttack_Base = value; }
        }
        public int SpecialDefense_Base
        {
            get { return specialDefense_Base; }
            set { specialDefense_Base = value; }
        }
        public int Speed_Base
        {
            get { return speed_Base; }
            set { speed_Base = value; }
        }
        
        //full stats
        public int HP_Full
        {
            get { return (((HP_Base + 50) * Level) / 50) + 10; }
        }
        public int Attack_Full
        {
            get { return ((Attack_Base * Level) / 50) + 5; }
        }
        public int Defense_Full
        {
            get { return ((Defense_Base * Level) / 50) + 5; }
        }
        public int SpecialAttack_Full
        {
            get { return ((SpecialAttack_Base * Level) / 50) + 5; }
        }
        public int SpecialDefense_Full
        {
            get { return ((SpecialDefense_Base * Level) / 50) + 5; }
        }
        public int Speed_Full
        {
            get { return ((Speed_Base * Level) / 50) + 5; }
        }

        //extra strats
        private int level = 1;
        public int Level
        {
            get { return level; }
            private set { level = value; }
        }

        //berekeningen
        public double Average
        {
            get { return Math.Round((HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base) / 6.0, 2, MidpointRounding.AwayFromZero); }
        }
        public double Full_Average
        {
            get { return Math.Round((HP_Full + Attack_Full + Defense_Full + SpecialAttack_Full + SpecialDefense_Full + Speed_Full) / 6.0, 2, MidpointRounding.AwayFromZero); }
        }
        public int Total
        {
            get { return HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base; }
        }

        //constructors
        public Pokemon()
        {
            HP_Base = 10;
            Attack_Base = 10;
            Defense_Base = 10;
            SpecialAttack_Base = 10;
            SpecialDefense_Base = 10;
            Speed_Base = 10;
        }
        public Pokemon(int hp, int att, int def, int spAtt, int spDef, int spd)
        {
            HP_Base = hp;
            Attack_Base = att;
            Defense_Base = def;
            SpecialAttack_Base = spAtt;
            SpecialDefense_Base = spDef;
            Speed_Base = spd;
        }

        //methods
        public void StelIn(string naam, string type1, string type2, int pokedex, int hp, int att, int def, int spAtt, int spDef, int spd, int level = 1)
        {
            Name = naam;
            Type1 = type1;
            Type2 = type2;
            PokedexNumber = pokedex;
            Level = level;
            HP_Base = hp;
            Attack_Base = att;
            Defense_Base = def;
            SpecialAttack_Base = spAtt;
            SpecialDefense_Base = spDef;
            Speed_Base = spd;
        }

        public void VerhoogLevel(int times = 1)
        {
            if (!NoLevellingAllowed)
            {
                if (times > 0)
                {
                    for (int i = 0; i < times; i++)
                    {
                        Level++;
                        aantalLevelverhogingen++;
                        Console.WriteLine("\nLevel up!");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nLevelling is disabled.");
            }
        }

        public void ShowInfo(bool verkort = false)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n{Name} (level {Level})");
            Console.ResetColor();
            if (!verkort)
            {
                Console.WriteLine("Base stats:");
                Console.WriteLine($"\t* Health: {HP_Base}\n\t* Attack: {Attack_Base}\n\t* Defense: {Defense_Base}\n\t* Sp. Attack: {SpecialAttack_Base}\n\t* Sp. Defense: {SpecialDefense_Base}\n\t* Speed: {Speed_Base}");
            }
            Console.WriteLine("Full stats:");
            Console.WriteLine($"\t* Health: {HP_Full}\n\t* Attack: {Attack_Full}\n\t* Defense: {Defense_Full}\n\t* Sp. Attack: {SpecialAttack_Full}\n\t* Sp. Defense: {SpecialDefense_Full}\n\t* Speed: {Speed_Full}");

        }

        public static Pokemon GeneratorPokemon(int level = 0)
        {
            aantalGegenereerdePokemon++;

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
                gen.Level = level;
            }

            return gen;
        }

        public static int Battle(Pokemon poke1, Pokemon poke2)
        {
            aantalBattles++;
            PrintRound(poke1, poke2);

            Random rand = new Random();
            double verschil = poke1.Full_Average - poke2.Full_Average;

            if (poke1 != null && poke2 != null)
            {
                double roll = rand.NextDouble();    //roll = chance of success roll

                if (verschil >= 0)
                {
                    double contest = poke2.Full_Average / poke1.Full_Average;   //contest = hoe groot schaalt poke1 tegenover poke2

                    // 10% gelijkstand
                    if (roll < 0.1)     
                    {
                        aantalGelijkstanden++;
                        return 0;
                    }
                    // als roll kleiner is dan de schaal dan wint de pokemon met de grootste stats
                    else if (roll <= contest)   
                    {
                        return 1;
                    }
                    // roll is groter dan wint de zwakste pokemon
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    double contest = poke1.Full_Average / poke2.Full_Average;  //contest = hoe groot schaalt poke2 tegenover poke1

                    if (roll < 0.1)
                    {
                        aantalGelijkstanden++;
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
                aantalGelijkstanden++;
                return 0;
            }
        }

        private static void PrintRound(Pokemon poke1, Pokemon poke2)
        {
            Console.Clear();
            poke1.ShowInfo();
            poke2.ShowInfo();

            Console.WriteLine($"\nRonde {aantalBattles}:\n");
            Console.ReadLine();
        }

        public static void Info()
        {
            Console.WriteLine($"\n\nStatus info:\n");
            Console.WriteLine($"Aantal gegenereerde Pokemons: {aantalGegenereerdePokemon}");
            Console.WriteLine($"Aantal battles: {aantalBattles}");
            Console.WriteLine($"Aantal gelijkstanden: {aantalGelijkstanden}");
            Console.WriteLine($"Aantal level verhogingen: {aantalLevelverhogingen}");
            Console.WriteLine("------------------------------");
        }
    }
}
