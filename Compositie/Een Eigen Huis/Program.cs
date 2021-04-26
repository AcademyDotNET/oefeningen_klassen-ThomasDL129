using System;

namespace Een_Eigen_Huis
{
    class Program
    {
        static void Main(string[] args)
        {
            var huis = new Huis();

            huis.Kamers.Add(new Badkamer("badkamer 1", 6));
            huis.Kamers.Add(new Gang("ne gang", 10));
            huis.Kamers.Add(new Slaapkamer("slaapkamer 1", 20));
            huis.Kamers.Add(new Salon("salon 1", 24, true));

            Console.WriteLine(huis.BerekenPrijs());
        }
    }
}
