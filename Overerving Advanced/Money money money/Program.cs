using System;

namespace Money_money_money
{
    class Program
    {
        static void Main(string[] args)
        {
            BankRekening bankRekening = new BankRekening();
            bankRekening.VoegGeldToe(1000);
            Console.WriteLine(bankRekening.Saldo);

            ProRekening proRekening = new ProRekening();
            proRekening.VoegGeldToe(5000);
            Console.WriteLine(proRekening.BerekenRente());
            proRekening.HaalGeldAf(500);
            Console.WriteLine(proRekening.BerekenRente());

            bankRekening.HaalGeldAf(900);
            Console.WriteLine(bankRekening.BerekenRente());
        }
    }
}
