using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speelkaarten
{
    public enum Kleur { Schoppen, Harten, Klaveren, Ruiten}
    class Speelkaart
    {
        public int Getal { get; set; }
        public Kleur Suite { get; set; }

        public Speelkaart(int getal, Kleur kleur)
        {
            Getal = getal;
            Suite = kleur;
        }
    }
}
