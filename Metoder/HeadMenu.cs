using System;
using LighterGrp3.Metoder;
using LighterGrp3.Klass;

namespace LighterGrp3
{
    public class HeadMenu
    {

        public static void MainMenu()
        {
            int userInput = 0;
            do
            {
                Console.WriteLine("Main menu:\n");
                Console.WriteLine("1. Find active marchals in your area");
                Console.WriteLine("2. Show list with active marshals");
                Console.WriteLine("3. Add new marshal to list");
                Console.WriteLine("4. Add Existing marshal");
                Console.WriteLine("5. Lost lighter counter");
                Console.WriteLine("6. Show User profile");
                Console.WriteLine("7. Exit program");

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }

            }
            while (userInput == 0 || userInput > 7);

            switch (userInput)
            {
                case 1:
                    // Metod för att se aktiva marschaller genom att söka på postnummer
                    break;
                case 2:
                    // Metod som visar lista med aktiva marschaller
                    Marshall.ActiveMarshalls();
                    HeadMenu.MainMenu();
                    break;
                case 3:
                    // Metod där man kan lägga till en NY marschall
                    AddMarshall.AddMarshallFromConsole();
                    break;
                case 4:
                    // Metod där man kan lägga till en redan existerande marschall
                    break;
                case 5:
                    // Metod som adderar 1 till lost lighter counter
                    CurrentUser.current.AddLostLighter(); 
                    break;
                case 6:
                    // Metod som visar användarens profil
                    CurrentUser.current.PrintCurrentUser();
                    HeadMenu.MainMenu();
                    break;
                case 7:
                    // Metod som visar hejdåhälsning och avslutar programmet
                    ExitProgram.EndMessage(); 
                    break; 
            }
        }

    }
}
