using System;

namespace Sportspeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Waterpolospeler joske = new Waterpolospeler();
            joske.StelIn("Jos", 5, false, true, Reeks.Tweedeklas);

            Waterpolospeler johnny = new Waterpolospeler();
            johnny.StelIn("Johnny", 9, true, false, Reeks.Eersteklas);

            joske.Watertrappen();
            johnny.Gooibal();

            joske.GeefSpelerWeer();
            johnny.GeefSpelerWeer();
        }
    }
}
