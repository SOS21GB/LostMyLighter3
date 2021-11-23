using System;
using LighterGrp3.Metoder;
using LighterGrp3.Klass; 

namespace LighterGrp3
{
    class StartingScreen
    {

        // Metod med startmeny som visas allra först innan man är inloggad. 

        public static void StartMenu()
        {
            int userInput = 0;
            do
            {
                Console.WriteLine(@"WELCOME TO 'LOST MY LIGTHER'!
Enter one of below numbers to proceed.\n
1. Log in
2. Create new user
3. View list of marshalls
4. Exit program");
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
            while (userInput == 0 || userInput > 4);

            switch (userInput)
            {
                case 1:
                    // Metod för Login (Obs metoden behöver skicka vidare till MainMenu)
                    CurrentUser.current = LogIn.LogInMethod();
                    HeadMenu.MainMenu(); 
                    break;
                case 2:
                    // Metod för skapa ny användare (Obs, metoden behöver skicka vidare till MainMenu)
                    AddUser.AddUserFromConsole();
                    
                    break;
                case 3:
                    // Metod för se lista med marschaller (Även om man inte är inloggad.)
                    Marshall.PrintAllMarshalls();
                    StartMenu(); 
                    break;
                case 4:
                    // Avslutar programmet.
                    ExitProgram.EndMessage(); 
                    break;
            }
        }
    }
}
