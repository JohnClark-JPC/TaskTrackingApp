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
//                            1. Action the task                                             //
//                            2. Cross out task, Let's not do this now                       //
//                            3. Skip highlighted task for now                               //
//                            4. Add new task                                                //
//                            5. Exit                                                        //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void subMenuHeader()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
///////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                           //
//                                       ARMAGEDDON IT!                                      //
//                                                                                           //
//                            1. Mark task complete                                          //
//                            2. Mark task incomplete                                        //
//                            3. Add new task                                                //
//                            4. Exit program                                                //
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
