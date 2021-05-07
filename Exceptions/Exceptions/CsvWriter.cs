using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Exceptions
{
    class CsvWriter
    {
        /*   public static void writeCsvNoStreamWriter()
           {
               string filepath = @"C:\Users\delee\Desktop\DemoData.csv";
               StringBuilder output = new StringBuilder();
               output.AppendLine("1,2,3");
               output.AppendLine("4,5,6");

               File.WriteAllText(filepath, output.ToString());
               File.AppendAllText(filepath, output.ToString());
           }*/
        public static void writeCsvStreamWriter(Pokemon[] pokemons)
        {

            using (StreamWriter streamWriter = new StreamWriter($@"C:\Users\delee\source\repos\csv-ThomasDL129\StreamWriter_{DateTime.Now.ToString("yyyy MM dd- HH mm")}.txt"))
            {
                streamWriter.WriteLine("#,Name,Type 1,Type 2,Total,HP,Attack,Defense,Sp. Atk,Sp. Def,Speed,Generation,Legendary");
                for(int i = 0; i < pokemons.Length;i++)
                {
                    streamWriter.WriteLine($"{pokemons[i].PokedexNumber},{pokemons[i].Name},{pokemons[i].Type1},{pokemons[i].Type2},{pokemons[i].Total},{pokemons[i].HP_Base},{pokemons[i].Attack_Base},{pokemons[i].Defense_Base},{pokemons[i].SpecialAttack_Base},{pokemons[i].SpecialDefense_Base},{pokemons[i].Speed_Base},{pokemons[i].Generation},{pokemons[i].IsLegendary}");
                }
            }
        }
    }
}
