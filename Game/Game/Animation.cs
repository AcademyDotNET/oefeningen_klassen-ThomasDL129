using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Animation
    {
        public static void HitAnim()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('+');
            Console.ResetColor();
            System.Threading.Thread.Sleep(150);
        }

        public static void VertLaserAnim()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write('!');
            Console.ResetColor();
            System.Threading.Thread.Sleep(50);
        }

        public static void HoriLaserAnim()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write('-');
            Console.ResetColor();
            System.Threading.Thread.Sleep(50);
        }
    }
}
