using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_money_money
{
    abstract class Rekening
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
        }


        public void VoegGeldToe(decimal storting)
        {
            saldo += storting;
        }

        public void HaalGeldAf(decimal aftrekking)
        {
            saldo -= aftrekking;
        }

        public abstract double BerekenRente();
    }
}
