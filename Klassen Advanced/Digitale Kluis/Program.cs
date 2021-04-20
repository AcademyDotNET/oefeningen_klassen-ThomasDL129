using System;

namespace Digitale_Kluis
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitaleKluis kluis1 = new DigitaleKluis(1234);
            DigitaleKluis kluis2 = new DigitaleKluis(6543);
            DigitaleKluis kluis3 = new DigitaleKluis(4123);

            GuessCode(kluis1);
            GuessCode(kluis2);
            GuessCode(kluis3);
        }

        private static void GuessCode(DigitaleKluis kluis)
        {
            bool guessed;

            do
            {
                Console.WriteLine("Invoer:");
                int trialcode = Convert.ToInt32(Console.ReadLine());
                guessed = kluis.TryCode(trialcode);
            } while (!guessed);
        }
    }
}
