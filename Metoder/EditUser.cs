using System;
using LighterGrp3.Klass;
namespace LighterGrp3.Metoder

{
    public static class EditUser
    {


        // Kunna göra ändringar i användaren. o T.ex. Byta namn, ändra ålder.
        //Peka sedan mot current user



        public static void EditUserMethod()
        {
            int userInput = 0;

            do
            {
                {
                    Console.WriteLine("Choose what you want to edit: ");
                    Console.WriteLine("1. Edit name");
                    Console.WriteLine("2. Edit age");
                    Console.WriteLine("3. Edit address");

                    try
                    {
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("You need to choose a number from the menu. Press a key and try again: ");
                    }



                }
            }
            while (userInput == 0 || userInput > 3);

            try
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Edit name");
                        CurrentUser.current.Name = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Edit age");
                        CurrentUser.current.Age = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Edit address");
                        CurrentUser.current.Adress = Console.ReadLine();
                        break;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                EditUser.EditUserMethod();
            }



        }
    }







}


