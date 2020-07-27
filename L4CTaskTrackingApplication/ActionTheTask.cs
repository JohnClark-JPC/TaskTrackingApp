using System;
using System.Collections.Generic;
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
            string current = Program.toDo[Program.listIndexValue];
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(current);
            Console.BackgroundColor = ConsoleColor.Black;
            Program.listIndexValue++;
            Console.ReadLine();
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
