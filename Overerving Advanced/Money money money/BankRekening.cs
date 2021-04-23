using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_money_money
{
    class BankRekening : Rekening
    {
        public override double BerekenRente()
        {
            if (Saldo > 100)
            {
                return 0.05;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
