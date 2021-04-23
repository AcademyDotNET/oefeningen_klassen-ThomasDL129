using System;

namespace Geometric_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek = new Rechthoek();
            rechthoek.Hoogte = 5;
            rechthoek.Breedte = 6;
            Console.WriteLine(rechthoek.BerekenOppervlakte());

            Vierkant vierkant = new Vierkant(4, 8);
            Console.WriteLine(vierkant.BerekenOppervlakte());

            Driehoek driehoek = new Driehoek();
            driehoek.Breedte = 6;
            driehoek.Hoogte = 4;
            Console.WriteLine(driehoek.BerekenOppervlakte());
        }
    }
}
