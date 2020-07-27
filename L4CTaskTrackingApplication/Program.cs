using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace L4CTaskTrackingApplication
{
    class Program
    {
        //TODO selecting 1. with no task does weird stuff.
        //TODO selecting 2. with no task exits program
        //TODO selecting 3. with no task writes the cw line
        //do any of these before adding a task and nothing gets highlighted
        //TODO add some kind of checking for 1, 2, 3 if list.count == 0;

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

        public static List<string> toDo = new List<string>();
        public static int listIndexValue = 0;

        public static bool MainMenu()
        {
            Console.Clear();
            MenuGraphics.menuHeader();
            DisplayTaskList();

            switch (Console.ReadLine())
            {
                case "1":
                    ActionTheTask.actionTheTask();
                    return true;
                case "2":
                    CrossOut();
                    return true;
                case "3":
                    SkipTask();
                    return true;
                case "4":
                    AddTask();
                    return true;
                case "5":
                    Outro.signOff();
                    return false;
                default:
                    return true;
            }
        }

        public static void DisplayTaskList()

        {
            if (toDo.Count == 0)
            {
                Console.WriteLine("//                                                                                           //");
                Console.Write("//");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string noTasks = "You don't have any tasks to do. Let's Get Rocked!";
                Console.Write(noTasks.PadLeft(70));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                     //");
                MenuGraphics.menuFooter();
            }

            else
            {
                MenuGraphics.PrintTaskList();
                foreach (string listString in toDo)
                {
                    int currentTaskNumber = toDo.IndexOf(listString) + 1;

                    if (listIndexValue == toDo.IndexOf(listString))
                    {
                        Console.Write("//          ");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(currentTaskNumber + ($".) {listString}"));
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("//          ");
                        Console.Write(currentTaskNumber + ($".) {listString}"));
                        Console.WriteLine();
                    }

                }
                MenuGraphics.menuFooter();
            }
        }

        private static void CrossOut()
        {
            toDo.RemoveAt(listIndexValue);
            DisplayTaskList();
        }

        private static void SkipTask()
        {
            Console.WriteLine();
            Console.WriteLine("Let It Go!");
            if (listIndexValue == toDo.Count -1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Press 'any key' to continue.");
                Console.ReadLine();
                EndOfTheList();
            }
            else
            {
                listIndexValue++;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Press 'any key' to continue.");
                Console.ReadLine();
                DisplayTaskList();
            }
        }

        public static void AddTask()
        {
            Console.Write("Enter new task: ");
            string newTask = Console.ReadLine();
            toDo.RemoveAll(u => u.Contains(newTask));
            toDo.Add(newTask);
            DisplayTaskList();
        }

        public static void EndOfTheList()
            //TODO check list for items marked in CompleteTheTask. If no unactioned items before it, remove from list.
            //TODO check list for items marked 
        {
            listIndexValue = 0;
            DisplayTaskList();
        }
    }
}

