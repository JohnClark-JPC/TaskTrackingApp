using System;
using System.Collections.Generic;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class MenuHeader
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
//                                1. Add a new task                                          //
//                                2. Mark task complete                                      //
//                                3. Mark task partially complete                            //
//                                4. Skip this task for now                                  //
//                                5. Exit                                                    //
//                                                                                           //
///////////////////////////////////////////////////////////////////////////////////////////////");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
