using System;
using System.Collections.Generic;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class Outro
    {
        //TODO add write state to txt file
        //TODO make these into def leppard font, 4 screens with delay.
        public static void signOff()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Alright, I got something to say");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("It's better to burn out");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Than fade away!");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
