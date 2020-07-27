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
            Program.actionMenu = true;
            Console.Clear();
            MenuGraphics.subMenuHeader();
            Program.DisplayTaskList();

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
            string current = Program.toDo[Program.listIndexValue];
            current += " *COMPLETE!*";
            Program.toDo[Program.listIndexValue] = current;
            Program.listIndexValue++;
            Program.actionMenu = false;
            actionTheTask();
        }

        public static void IncompleteTask()
        {
            string current = Program.toDo[Program.listIndexValue];
            current += " *In-Progress*";
            Program.toDo[Program.listIndexValue] = current;
            Program.listIndexValue++;
            Program.actionMenu = false;
            actionTheTask();
        }
    }
}
