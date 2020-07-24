using System;

namespace L4CTaskTrackingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SplashScreen.splashScreen();
                bool displayMenu = true;
                while (displayMenu)
                {
                    displayMenu = Menus.MainMenu();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Outro.signOff();
            }
        }
    }
}
