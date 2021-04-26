using System;
using System.Collections.Generic;

namespace Politiek
{
    class Program
    {
        static void Main(string[] args)
        {
            var tropico = new Land();

            var elpresident = new President("El Presidente");

            var ministerie = new List<Minister>();
            ministerie.Add(new Minister("Penultimo"));
            ministerie.Add(new Minister("Antonio Lopez"));
            ministerie.Add(new Minister("Comrade Vasquez"));
            ministerie.Add(new Minister("Reverand Esteban"));
            ministerie.Add(new Minister("General Rodriguez"));

            tropico.MaakRegering(elpresident, ministerie);

            tropico.JaarVerder();
            tropico.MaakRegering(elpresident, ministerie);
            tropico.JaarVerder();
            tropico.JaarVerder();
            tropico.JaarVerder();
        }
    }
}
