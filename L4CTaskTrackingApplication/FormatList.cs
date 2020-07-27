using System;
using System.Collections.Generic;
using System.Text;
using L4CTaskTrackingApplication;

namespace L4CTaskTrackingApplication
{
    public static class FormatList
    {
        public static void formatList()
        {

            MenuGraphics.PrintTaskList();
            foreach (string listString in Program.toDo)
            {
                int currentTaskNumber = Program.toDo.IndexOf(listString) + 1;
                //switch? on liststring. 
                // 1. if contains complete, text dark grey, then delete it. 
                // 2. if contains in progress highlight it grey.
                // 3. if listindex value = todo list index, highlight it yellow.
                //if liststring contains *complete!*  color it grey, then currenttasknumber++

                if (Program.listIndexValue == Program.toDo.IndexOf(listString))
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

            if (!Program.actionMenu)
            {
                MenuGraphics.menuFooter();
            }

            else
            {
                MenuGraphics.subMenuFooter();
            }
        }
        
    }
}
