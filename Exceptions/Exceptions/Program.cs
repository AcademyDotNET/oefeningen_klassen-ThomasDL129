using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Net.WebClient wc = new System.Net.WebClient();
            string csv = "";

            try
            {
                csv = wc.DownloadString("https://gist.githubusercontent.com/armgilles/194bcff35001e7eb53a2a8b441e8b2c6/raw/92200bc0a673d5ce2110aaad4544ed6c4010f687/pokemon.csv");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            string[] splitted = csv.Split('\n');

            Pokemon[] pokemons = new Pokemon[splitted.Length - 2];




            for (int i = 1; i < splitted.Length - 1; i++)
            {
                string[] lijnsplit = splitted[i].Split(',');

                pokemons[i - 1] = LoadPokemon(lijnsplit);

                //Console.WriteLine($"{pokemons[i-1].PokedexNumber}\t{pokemons[i-1].Name}");
            }

            try
            {
                CsvWriter.writeCsvStreamWriter(pokemons);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }

        static Pokemon LoadPokemon(string[] lijnsplit)
        {
            Pokemon pokemon = new Pokemon();

            pokemon.StelIn(Convert.ToInt32(lijnsplit[0]), lijnsplit[1], lijnsplit[2], lijnsplit[3], Convert.ToInt32(lijnsplit[5]), Convert.ToInt32(lijnsplit[6]), Convert.ToInt32(lijnsplit[7]), Convert.ToInt32(lijnsplit[8]), Convert.ToInt32(lijnsplit[9]), Convert.ToInt32(lijnsplit[10]), Convert.ToInt32(lijnsplit[11]), Convert.ToBoolean(lijnsplit[12]));

            return pokemon;
        }
    }
}
