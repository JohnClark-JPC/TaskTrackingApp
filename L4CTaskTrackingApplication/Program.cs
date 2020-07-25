using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string noTasks = "You don't have any tasks to do. Let's Get Rocked!";
                Console.WriteLine();
                Console.WriteLine(noTasks.PadLeft(70));
                Console.ForegroundColor = ConsoleColor.White;
            }

            else
            {
                Console.WriteLine("//                                                                                           //");
                string taskList = "Have You Every Needed Someone So Bad?";
                Console.Write("//");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(taskList.PadLeft(65));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                          //");
                Console.WriteLine("//                                                                                           //");
                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
                foreach (string i in toDo)
                {
                    int taskNumber = toDo.IndexOf(i) + 1;
                    Console.WriteLine(taskNumber + ($".) {i}"));
                }
            }

            //highlight the current task
            int currentTask = toDo.First;
        }

        private static void AddTask()
        {

            Console.WriteLine("Enter your new task:");
            toDo.Add(Console.ReadLine());
            //TODO if task already exists (cw == any list item), move task to the end of the list.
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
