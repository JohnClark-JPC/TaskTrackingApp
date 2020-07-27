using System;
using System.Collections.Generic;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class MenuGraphics
    {
        public static void menuHeader()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                                       ARMAGEDDON IT!                                      //
//                                                                                           //
//                            1. Update status of highlighted task                           //
//                            2. Remove highlighted task                                     //
//                            3. Skip highlighted task for now                               //
//                            4. Add new task                                                //
//                            5. Exit                                                        //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void subMenuHeader()
            //TODO add reference to what task is being updated
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                                       ROCK! ROCK!                                         //
//                                                                                           //
//                            1. Mark task complete                                          //
//                            2. Did some stuff, but it ain't done yet!                      //
//                            3. Add new task                                                //
//                            4. Return to main menu                                         //
//                            5. Exit program                                                //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void menuFooter()
        {
            Console.WriteLine("//                                                                                           //");
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write("Make a menu selection: ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void subMenuFooter()
            //TODO implement submenufooter in the submenu.
        {
            Console.WriteLine("//                                                                                           //");
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.Write("Please listen closely as our menu options have changed. Make a menu selection: ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintTaskList()
        {
            Console.WriteLine("//                                                                                           //");
            string taskList = "Have You Ever Needed Someone So Bad?";
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(taskList.PadLeft(63));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                            //");
            Console.WriteLine("//                                                                                           //");
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("//                                                                                           //");
            string taskListTitle = "TASK LIST";
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(taskListTitle.PadLeft(50));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                         //");
            Console.WriteLine("//                                                                                           //");
        }
    }
}
