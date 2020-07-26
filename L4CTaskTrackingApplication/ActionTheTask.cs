using System;
using System.Collections.Generic;
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
            }
        }

        public static void CompleteTheTask()
        {
            Console.WriteLine("complete the task here");
            Console.ReadLine();
        }

        public static void IncompleteTask()
        {
            Console.WriteLine("implement incomplete task here");
        }

    }
}
