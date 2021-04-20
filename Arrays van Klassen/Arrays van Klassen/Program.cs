using System;

namespace Arrays_van_Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var array = new double[20];
            var totaal = 0.0;

            Console.WriteLine("Geef 20 waarden in");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = CheckDoubleInput();
            }

            Console.WriteLine("\nElementen die hoger zijn dan € 5,00:");
            foreach (var item in array)
            {
                totaal += item;
                if (item >= 5)
                {
                    Console.WriteLine($"{item:C}");
                }
            }

            Console.WriteLine($"\nGemiddelde prijs:\n{(totaal/array.Length):C}");
            
        }

        private static double CheckDoubleInput()
        {
            bool validinput;
            double waarde;

            do
            {
                validinput = double.TryParse(Console.ReadLine(), out waarde);
            } while (!validinput);

            return waarde;
        }
    }
}
