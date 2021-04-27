using System;
using System.Collections.Generic;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();

            manager.cards.AddRange(new List<Card>{ new Land(), new CreatureCard(), new Artifact(), new CreatureCard(), new SpellCard()});

            foreach (var item in manager.cards)
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}
