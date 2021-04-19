using System;

namespace Sport_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Waterpolospeler jos = new Waterpolospeler("Joske", 9, false, false, Reeks.Cadet);
            Waterpolospeler johnny = new Waterpolospeler("Johnny", 4, true, false, Reeks.Eersteklas);

            Waterpolospeler.SimuleerSpeler(jos);
            Waterpolospeler.SimuleerSpeler(johnny);

            Waterpolospeler.SimuleerWedstrijd(jos, johnny);


            Waterpolospeler best = Waterpolospeler.BesteSpeler(jos, johnny);
            best.GeefSpelerWeer();
            best.Gooibal();
            best.Watertrappen();
        }
    }
}
