using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_money_money
{
    class ProRekening : SpaarRekening
    {
        public override double BerekenRente()
        {
            double bonus = Convert.ToDouble(Math.Floor(Saldo / 1000)) * 0.01;
            return base.BerekenRente() + bonus;
        }
    }
}
