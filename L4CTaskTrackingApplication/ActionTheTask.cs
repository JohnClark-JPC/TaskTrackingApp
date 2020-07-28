using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace L4CTaskTrackingApplication
{
    class ActionTheTask
    {
        public static void actionTheTask()
        {
            //Program.actionMenu = true;
            Console.Clear();
            MenuGraphics.subMenuHeader();
            Program.DisplayTaskList();

            switch (Console.ReadLine())
            {
                case "1":
                    Program.AddTask();
                    break;
                case "2":
                    Program.CompleteTheTask();
                    break;
                case "3":
                    Program.IncompleteTask();
                    break;
                case "4":
                    Program.MainMenu();
                    break;
                case "5":
                    Outro.signOff();
                    break;
            }
        } 
    }
}
