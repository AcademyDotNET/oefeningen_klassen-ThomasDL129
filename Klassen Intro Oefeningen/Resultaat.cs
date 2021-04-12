using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Intro_Oefeningen
{
    class Resultaat
    {
        public int Percentage { get; set; } = 0;

        public void PrintGraad()
        {
            if(Percentage < 50)
            {
                Console.WriteLine("Niet Geslaagd.");
            }
            else if(Percentage >= 50 && Percentage < 68)
            {
                Console.WriteLine("Voldoende.");
            }
            else if (Percentage >= 68 && Percentage < 75)
            {
                Console.WriteLine("Onderscheiding.");
            }
            else if (Percentage >= 75 && Percentage < 85)
            {
                Console.WriteLine("Grote onderscheiding.");
            }
            else
            {
                Console.WriteLine("Grootste onderscheiding.");
            }
        }
    }
}
