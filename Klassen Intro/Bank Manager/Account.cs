using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Manager
{
    public enum AccountState { Geldig, Geblokkeerd }
    class Account
    {
        private string naam;
        private int bedrag;
        private string rekeningnummer;

        public string Naam
        {
            get { return naam; }
            set
            {
                if (value != string.Empty)
                {
                    naam = value;
                }
            }
        }
        public int Bedrag
        {
            get { return bedrag; }
            set
            {
                if (value >= 0)
                {
                    bedrag = value;
                }
            }
        }
        public string Rekeningnummer
        {
            get { return rekeningnummer; }
            set
            {
                if (value != string.Empty) 
                {
                    rekeningnummer = value;
                }
            }
        }
        public AccountState AccountState { get; set; } = AccountState.Geldig;

        public void StelIn(string naam, int bedrag, string rekeningnummer, AccountState accountState = AccountState.Geldig)
        {
            Naam = naam;
            Bedrag = bedrag;
            Rekeningnummer = rekeningnummer;
            AccountState = accountState;
        }

        public int WithdrawFunds(int withdrawal)
        {
            if(AccountState == AccountState.Geldig)
            {
                if (Bedrag - withdrawal < 0)
                {
                    Console.Write("\nHet ingevoerde bedrag kon niet helemaal uitgegeven worden. Reden: saldo te laag.");
                    withdrawal -= (withdrawal - Bedrag);
                    Bedrag = 0;
                }
                else
                {
                    Bedrag -= withdrawal;
                }
                Console.WriteLine($"\nHet bedrag van {withdrawal} werd succesvol van bankrekening van {Naam} afgenomen.");
            }
            else
            {
                withdrawal = 0;
                Console.WriteLine($"\nKan actie niet uitvoeren. {Rekeningnummer} is geblokkeerd.");
            }   

            return withdrawal;
        }

        public void PayInFunds(int bedrag)
        {
            if(AccountState == AccountState.Geldig)
            {
                Bedrag += bedrag;
                Console.WriteLine($"\nHet bedrag van {bedrag} werd succesvol op {Naam}'s bankrekening gestort.");
            }
            else
            {
                Console.WriteLine($"\nKan actie niet uitvoeren. {Rekeningnummer} is geblokkeerd.");
            }
        }

        public void GetBalance()
        {
            Console.WriteLine($"\nRekening {Rekeningnummer} saldo: {Bedrag}");
        }

        public void ChangeState()
        {
            if(AccountState == AccountState.Geldig)
            {
                AccountState = AccountState.Geblokkeerd;
                Console.WriteLine($"\nAccount van {Naam} werd geblokkeerd.");
            }
            else
            {
                AccountState = AccountState.Geldig;
                Console.WriteLine($"\nAccount van {Naam} werd geldig gemaakt.");
            }
        }

        public void GeefAccountWeer()
        {
            Console.WriteLine($"\nNaam: {Naam}\nRekeningnummer: {Rekeningnummer}\nSaldo: {Bedrag}\nStatus: {AccountState}");
        }
    }
}
