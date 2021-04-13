using System;

namespace Bank_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            Account account2 = new Account();

            account1.StelIn("Joske", 60, "BE69 1337 420");
            account2.StelIn("Pepe", 80, "KEKW 8264 397");

            account1.GeefAccountWeer();
            account2.GeefAccountWeer();

            account2.PayInFunds(50);
            account1.WithdrawFunds(70);
            account1.PayInFunds(60);

            account2.PayInFunds(account1.WithdrawFunds(70));
            account2.ChangeState();
            account1.PayInFunds(account2.WithdrawFunds(100));

            account1.GeefAccountWeer();
            account2.GeefAccountWeer();
        }
    }
}
