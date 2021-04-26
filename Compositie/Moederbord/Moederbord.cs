using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moederbord
{
    class Moederbord : Component
    {
        public RamSlot[] RamSlots { get; set; }
        public CpuSlot Cpu { get; set; }
        public GpuSlot Gpu { get; set; }

        public Moederbord(string naam, int aantalRamSlots) : base(naam)
        {
            RamSlots = new RamSlot[aantalRamSlots];
        }

        public void TestMoederbord()
        {
            Console.WriteLine($"Moederbord test:");
            if (Cpu == null)
            {
                Console.WriteLine("Cpu : null");
            }
            if (Gpu == null)
            {
                Console.WriteLine("Gpu : null");
            }
            if (RamSlots == null)
            {
                Console.WriteLine("RAM : null");
            }
            else
            {
                for (int i = 0; i < RamSlots.Length; i++)
                {
                    if (RamSlots[i] == null)
                    {
                        Console.WriteLine($"RAM #{i} : null");
                    }
                }
            }

            Console.WriteLine("Test ended.\n");
        }
    }
}
