using System;
using System.Collections.Generic;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class Menus
    {
        public static bool MainMenu()
        {
            Console.Clear();
            //call the heading graphic
            //call the list, for loop to iterate through list and print items.
            //check list if > 15 items. press enter to continue. reprint heading graphic, continue loop

            Console.WriteLine("Choose an option: ");
            Console.WriteLine("\r\n1) Calculate the circumference and area of a circle.");
            Console.WriteLine("2) Calculate the volume of a hemisphere.");
            Console.WriteLine("3) Calculate the area of a triangle");
            Console.WriteLine("4) Solve a quadratic equation given coefficients a, b, and c");
            Console.WriteLine("5) Exit");
            //Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    actionItem();
                    return true;
                case "2":
                    markComplete();
                    return true;
                case "3":
                    skipTask();
                    return true;
                case "4":
                    addNewTask();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }
    }
}
