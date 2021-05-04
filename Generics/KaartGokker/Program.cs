using System;
using System.Collections.Generic;

namespace KaartGokker
{
    class Program
    {
        static void Main(string[] args)
        {
            var pakkaarten = Speelkaart.GenerateDeck();
            Stack<Speelkaart> shuffledDeck = Speelkaart.ShuffleDeck(pakkaarten);

            for (int i = 0; i < 5; i++)
            {
                var playerPick = PlayerInput();
                var aiPick = shuffledDeck.Pop();

                if (playerPick.Equals(aiPick))
                {
                    Console.WriteLine("Goed geraden!");
                }
                else
                {
                    Console.WriteLine($"Spijtig. De kaart was {aiPick}");
                }
            }
        }

        private static Speelkaart PlayerInput()
        {
            Console.WriteLine("Gok een kaart:");
            Console.WriteLine("Kleur:");
            Kleur kleur = ConverteerKleur(Console.ReadLine().ToLower());
            Console.WriteLine("Getal:");
            int getal = Convert.ToInt32(Console.ReadLine());

            return new Speelkaart(getal, kleur);
        }

        private static Kleur ConverteerKleur(string v)
        {
            switch (v)
            {
                case "schoppen":
                    return Kleur.Schoppen;
                case "harten":
                    return Kleur.Harten;
                case "klaveren":
                    return Kleur.Klaveren;
                case "ruiten":
                    return Kleur.Ruiten;
                default:
                    return Kleur.Schoppen;
            }
        }
    }
}
