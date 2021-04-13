using System;

namespace Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek1 = new Rechthoek();
            Rechthoek rechthoek2 = new Rechthoek();

            Driehoek driehoek1 = new Driehoek();
            Driehoek driehoek2 = new Driehoek();

            rechthoek1.Hoogte = 5;
            rechthoek1.Breedte = 3;

            rechthoek2.Hoogte = 9;
            rechthoek2.Breedte = 4;

            driehoek1.Basis = 8;
            driehoek1.Hoogte = 6;

            driehoek2.Basis = 4;
            driehoek2.Hoogte = 4;

            rechthoek1.ToonOppervlakte();
            rechthoek2.ToonOppervlakte();
            driehoek1.ToonOppervlakte();
            driehoek2.ToonOppervlakte();
        }
    }
}
