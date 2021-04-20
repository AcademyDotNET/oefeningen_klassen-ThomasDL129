using System;

namespace Klassen_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Meetlat meetlat = new Meetlat(52);

            Console.WriteLine($"{meetlat.LengteInVoet}");
            Console.WriteLine($"{meetlat.LengteInKm}");
            Console.WriteLine($"{meetlat.LengteInCm}");
        }
    }
}
