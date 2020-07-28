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
//                            1. Add new task                                                //
//                            2. Update status of highlighted task                           //
//                            3. Remove highlighted task                                     //
//                            4. Skip highlighted task for now                               //
//                            5. Exit                                                        //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void limitedMenuHeader()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                                       ARMAGEDDON IT!                                      //
//                                                                                           //
//                            1. Add new task                                                //
//                            2. Exit                                                        //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("//                                                                                           //");
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string noTasks = "You don't have any tasks to do. Let's Get Rocked!";
            Console.Write(noTasks.PadLeft(70));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                     //");
            MenuGraphics.menuFooter();
        }

        public static void subMenuHeader()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                                        ROCK! ROCK!                                        //
//                                                                                           //
//                            1. Add new task                                                //
//                            2. Mark task complete                                          //
//                            3. Did some stuff, but it ain't done yet!                      //
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
            string taskListTitle = "GET STUFF DONE!";
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(taskListTitle.PadLeft(53));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                      //");
            Console.WriteLine("//                                                                                           //");
        }
    }
}
