using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class ActionTheTask
    {
        public static void actionTheTask()
        {
            Console.Clear();
            MenuGraphics.subMenuHeader();
            Program.DisplayTaskList();
            MenuGraphics.subMenuFooter();

            switch (Console.ReadLine())
            {
                case "1":
                    CompleteTheTask();
                    break;
                case "2":
                    IncompleteTask();
                    break;
                case "3":
                    Program.AddTask();
                    break;
                case "4":
                    Program.MainMenu();
                    break;
                case "5":
                    Outro.signOff();
                    break;
            }
        }

        public static void CompleteTheTask()
        {
            //Console.WriteLine("Mark the task complete here");
            //cw append string with **COMPLETED** + turn text grey;
            //appends string to have a space at the end.
            string current = Program.toDo[Program.listIndexValue];
            current += " ** COMPLETE **";
            Program.toDo[Program.listIndexValue] = current;
            Program.listIndexValue++;
        }

        public static void IncompleteTask()
            //TODO turn this thing grey!
        {
            Console.WriteLine("Mark the task incomplete here");
            //cw append string with **Almost there, keep at it!** + turn text grey;
            //move task to the end of the list.
            Console.ReadLine();
            Program.MainMenu();
        }
    }
}
