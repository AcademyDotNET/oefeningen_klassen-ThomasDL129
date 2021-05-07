using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Pokemon
    {
        public int PokedexNumber { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; } = "N/A";
        public string Type2 { get; set; } = "";
        public bool IsLegendary { get; set; }
        public int Generation { get; set; }


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


        private int level = 1;
        public int Level
        {
            get { return level; }
            private set { level = value; }
        }


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


        public void StelIn(int pokedex, string naam, string type1, string type2, int hp, int att, int def, int spAtt, int spDef, int spd, int generation, bool legendary = false)
        {
            PokedexNumber = pokedex;
            Name = naam;
            Type1 = type1;
            Type2 = type2;
            HP_Base = hp;
            Attack_Base = att;
            Defense_Base = def;
            SpecialAttack_Base = spAtt;
            SpecialDefense_Base = spDef;
            Speed_Base = spd;
            Generation = generation;
            IsLegendary = legendary;
        }

        public void VerhoogLevel(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Level++;
            }
        }

        public void ShowInfo(bool verkort = false)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{Name} (level {Level})");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (!verkort)
            {
                Console.WriteLine("Base stats:");
                Console.WriteLine($"\t* Health: {HP_Base}\n\t* Attack: {Attack_Base}\n\t* Defense: {Defense_Base}\n\t* Sp. Attack: {SpecialAttack_Base}\n\t* Sp. Defense: {SpecialDefense_Base}\n\t* Speed: {Speed_Base}");
            }
            Console.WriteLine("Full stats:");
            Console.WriteLine($"\t* Health: {HP_Full}\n\t* Attack: {Attack_Full}\n\t* Defense: {Defense_Full}\n\t* Sp. Attack: {SpecialAttack_Full}\n\t* Sp. Defense: {SpecialDefense_Full}\n\t* Speed: {Speed_Full}\n");
        }
    }
}
