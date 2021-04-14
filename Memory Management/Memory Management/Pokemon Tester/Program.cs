using System;

namespace Pokemon_Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon ninetales = new Pokemon();
            ninetales.StelIn("Ninetales", "Fire", 38, 73, 76, 75, 81, 100, 100, 1);

            Pokemon gengar = new Pokemon();
            gengar.StelIn("Gengar", "Ghost", 94, 60, 65, 60, 130, 75, 110, 1);

            Console.WriteLine("Welke pokemon wil je testen?\n1.Ninetales\n2.Gengar");
            int input = UserInput();

            Pokemon test = new Pokemon();

            Console.WriteLine("Voer de base stats in dat je wilt:");

            switch (input)
            {
                case 1:
                    test = ninetales;
                    break;
                case 2:
                    test = gengar;
                    break;
            }

            BaseStatChanger(test);
            test.ShowInfo();

            Console.WriteLine("\nHoeveel keer wil je levellen?");
            test.VerhoogLevel(UserInput());

            test.ShowInfo();
        }

        private static void BaseStatChanger(Pokemon pokemon)
        {
            pokemon.HP_Base = UserInput();
            pokemon.Attack_Base = UserInput();
            pokemon.Defense_Base = UserInput();
            pokemon.SpecialAttack_Base = UserInput();
            pokemon.SpecialDefense_Base = UserInput();
            pokemon.Speed_Base = UserInput();
        }

        private static int UserInput()
        {
            bool validInput;
            int invoer;
            do
            {
                validInput = int.TryParse(Console.ReadLine(), out invoer);
            } while (!validInput);

            return invoer;
        }
    }
}
