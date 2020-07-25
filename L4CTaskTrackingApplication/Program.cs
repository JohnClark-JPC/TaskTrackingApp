using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SplashScreen.splashScreen();
                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = MainMenu();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Outro.signOff();
            }
        }

        public static bool MainMenu()
        {
            Console.Clear();
            MenuHeader.menuHeader();
            DisplayTaskList();

            switch (Console.ReadLine())
            {
                case "1":
                    AddTask();
                    return true;
                case "2":
                    MarkTaskComplete();
                    return true;
                case "3":
                    MarkTaskPartiallyComplete();
                    return true;
                case "4":
                    SkipTask();
                    return true;
                case "5":
                    Outro.signOff();
                    return false;
                default:
                    return true;
            }
        }

        public static List<string> toDo = new List<string>();

        public static void DisplayTaskList()

        {
            if (toDo.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nYou don't have any tasks to do. Let's Get Rocked!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // how to pad left to center taskList string with // on either side?
            else
            {
                Console.Write("//");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string taskList = "Have You Every Needed Someone So Bad?";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(taskList.PadLeft(20));
                Console.WriteLine();
                foreach (string i in toDo)
                {
                    int taskNumber = toDo.IndexOf(i) + 1;
                    Console.WriteLine(taskNumber + ($".) {i}"));
                }
            }
        }

        private static void AddTask()
        {

            Console.WriteLine("Enter your new task:");
            toDo.Add(Console.ReadLine());
        }

        private static void MarkTaskComplete()
        {
            Console.WriteLine("MarkTaskComplete");
            Console.ReadLine();
        }

        private static void MarkTaskPartiallyComplete()
        {
            Console.WriteLine("MarkTaskPartiallyComplete");
            Console.ReadLine();
        }

        private static void SkipTask()
        {
            Console.WriteLine("SkipTask. Let It Go!");
            Console.ReadLine();
        }
    }
}
