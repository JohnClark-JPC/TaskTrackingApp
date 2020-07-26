using System;
using System.Collections.Generic;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class MenuFooter

    {
        public static void menuFooter()
        {
        Console.WriteLine("//                                                                                           //");
        Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.Write("Make a menu selection: ");
        Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
