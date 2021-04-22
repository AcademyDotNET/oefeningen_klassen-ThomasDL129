using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziekenhuis
{
    class VerzekerdePatient : Patient
    {
        public VerzekerdePatient(string naam, int aantUren) : base(naam, aantUren)
        {

        }

        public override int BerekenKost()
        {
            return base.BerekenKost() / 10 * 9;
        }
    }
}
