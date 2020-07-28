using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace L4CTaskTrackingApplication
{
    class Outro
    {
        //TODO make these into def leppard font, 4 screens with delay.
        public static void signOff()
        {
            string fileName = @"C:\Users\clark\source\repos\TaskTrackingApp\L4CTaskTrackingApplication\docs\savedData.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string listString in Program.toDo)
                    {
                        writer.WriteLine(listString);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Graphics();
            }

        }
        public static void Graphics()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Alright, I got something to say");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("It's better to burn out");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Than fade away!");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
