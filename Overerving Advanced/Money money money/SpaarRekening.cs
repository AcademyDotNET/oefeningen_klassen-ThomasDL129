using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_money_money
{
    class SpaarRekening : Rekening
    {
        public override double BerekenRente()
        {
            return 0.02;
        }
    }
}
