using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaartGokker
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

        public override string ToString()
        {
            return $"{Suite} {Getal}";
        }

        public override bool Equals(object obj)
        {
            Speelkaart speelkaart = obj as Speelkaart;

            if (speelkaart != null)
            {
                if (Getal == speelkaart.Getal && Suite == speelkaart.Suite)
                {
                    return true;
                }
            }

            return false;
        }

        public static List<Speelkaart> GenerateDeck()
        {
            var pak = new List<Speelkaart>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    pak.Add(new Speelkaart(j + 1, (Kleur)i));
                }
            }

            return pak;
        }

        public static Stack<Speelkaart> ShuffleDeck(List<Speelkaart> pak)
        {
            Random r = new Random();
            var deckStack = new Stack<Speelkaart>();

            for (int i = pak.Count; i > 0; i--)
            {
                int index = r.Next(0, pak.Count);
                deckStack.Push(pak[index]);
                pak.RemoveAt(index);
            }

            return deckStack;
        }
    }
}
