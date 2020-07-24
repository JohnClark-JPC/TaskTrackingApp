using System;
using System.Collections.Generic;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class Outro
    {
        public static void signOff()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Alright, I got somethin to say");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("It's better to burn out");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Than fade away!");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
