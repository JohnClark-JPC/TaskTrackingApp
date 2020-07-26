using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string noTasks = "You don't have any tasks to do. Let's Get Rocked!";
                Console.WriteLine();
                Console.WriteLine(noTasks.PadLeft(70));
                Console.ForegroundColor = ConsoleColor.White;
                MenuGraphics.menuFooter();
            }

            else
            {
                MenuGraphics.PrintTaskList();
                foreach (string i in toDo)
                {
                    int taskNumber = toDo.IndexOf(i) + 1;
                    if (listIndexValue == toDo.IndexOf(i))
                    {
                        Console.Write("//          ");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(taskNumber + ($".) {i}"));
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("//          ");
                        Console.Write(taskNumber + ($".) {i}"));
                        Console.WriteLine();
                    }
                }
                MenuGraphics.menuFooter();
            }
        }

        private static void CrossOut()
        {
                Console.WriteLine("Remove task from list");
                toDo.RemoveAt(listIndexValue);
                DisplayTaskList();
                //Console.ReadLine();
        }

        private static void SkipTask()
        {
            if(toDo.Count == 0)
            {
                DisplayTaskList();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Let It Go!");
                listIndexValue++;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("Press 'enter' to continue.");
                Console.ReadLine();
            }

        }

        public static void AddTask()
        {

            Console.Write("Enter new task: ");
            toDo.Add(Console.ReadLine());
            DisplayTaskList();
            //TODO if task already exists (cw == any list item), move task to the end of the list.
        }

        private static void CompleteTheTask()
        {
            Console.WriteLine("lets complete the task");
            Console.ReadLine();
            DisplayTaskList();
        }

        public static void CurrentTask()
        {
            //highlight the current task
            int currentTask = 0;
            Console.WriteLine("This is where item get highlighted.");
            Console.WriteLine(toDo[currentTask]);
            currentTask++;
            DisplayTaskList();
        }
    }
}

