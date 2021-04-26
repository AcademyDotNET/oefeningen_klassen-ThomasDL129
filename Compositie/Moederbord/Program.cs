using System;

namespace Moederbord
{
    class Program
    {
        static void Main(string[] args)
        {
            Moederbord asus= new Moederbord("PRIME-X570-P", 4);
            asus.TestMoederbord();

            asus.Gpu = new GpuSlot("GeForceRTX2080");
            asus.Cpu = new CpuSlot("IntelCorei9_9900K");

            asus.TestMoederbord();

            for (int i = 0; i < asus.RamSlots.Length; i++)
            {
                asus.RamSlots[i] = new RamSlot("G-Skill 16 GB");
            }

            asus.TestMoederbord();
        }
    }
}
