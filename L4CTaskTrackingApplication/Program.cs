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
        //TODO remove highlighted task should grey it out.  Then at end of list, check for previous action items.
        //TODO only display 15 tasks on the screen
        //TODO add error handling to read txt file
        //TODO if you x out of program, doesnt save state.
        //TODO implement modulus operator for end of list checking. Sample code in EndOfList()
        //TODO stretch add up/down arrow functionality to menu's


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

        public static List<string> toDo = System.IO.File.ReadLines(@"C:\Users\clark\source\repos\TaskTrackingApp\L4CTaskTrackingApplication\docs\savedData.txt").ToList();
        public static int listIndexValue = 0;
        public static bool actionMenu = false;
        public static string listString;

        public static bool MainMenu()
        {
            Console.Clear();

            if (toDo.Count > 0)
            {
                MenuGraphics.menuHeader();
                DisplayTaskList();

                switch (Console.ReadLine())
                {
                    case "1":
                        AddTask();
                        return true;
                    case "2":
                        ActionTheTask.actionTheTask();
                        return true;
                    case "3":
                        CrossOut();
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
            else
            {
                MenuGraphics.limitedMenuHeader();

                switch (Console.ReadLine())
                {
                    case "1":
                        AddTask();
                        return true;
                    case "2":
                        Outro.signOff();
                        return false;
                    default:
                        return true;
                }
            }
        }

        public static void DisplayTaskList()

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
                    string slashes = @"//";
                    Console.Write(slashes.PadLeft(listString.Length - (listString.Length - 75)));
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("//          ");
                    Console.Write(currentTaskNumber + ($".) {listString}"));
                    string slashes = @"//";
                    Console.Write(slashes.PadLeft(listString.Length - (listString.Length - 75)));
                    Console.WriteLine();
                }
            }

            if (!actionMenu)
            {
                MenuGraphics.menuFooter();
            }

            else
            {
                MenuGraphics.subMenuFooter();
            }
        }

        private static void CrossOut()
        {
            toDo.RemoveAt(listIndexValue);

            if (listIndexValue >= toDo.Count - 1)
            {
                EndOfTheList();
            }
            else
            {
                DisplayTaskList();
            }
        }

        private static void SkipTask()
        {

            if (listIndexValue == toDo.Count - 1)
            {
                EndOfTheList();
            }
            else
            {
                listIndexValue++;
                DisplayTaskList();
            }
        }

        public static void AddTask()
        {
            Console.Write("Enter new task: ");
            string newTask = Console.ReadLine();
            toDo.RemoveAll(u => u.Equals(newTask));
            toDo.Add(newTask);
            DisplayTaskList();
        }

        public static void CompleteTheTask()

        {   
            string current = toDo[listIndexValue];
            current += " *COMPLETE!*";
            toDo[listIndexValue] = current;
            listIndexValue++;
            DisplayTaskList();

            if(toDo.Count == listIndexValue)
            {
                EndOfTheList();
            }
        }

        public static void IncompleteTask()
        {
            string current = toDo[listIndexValue];
            current += " *In-Progress*";
            toDo[listIndexValue] = current;
            listIndexValue++;
            DisplayTaskList();

            if (toDo.Count == listIndexValue)
            {
                EndOfTheList();
            }
        }

        public static void EndOfTheList()
        {
            listIndexValue = 0;
            DisplayTaskList();
            //counter = ++counter % taskList.Count;
        }
    }
}

