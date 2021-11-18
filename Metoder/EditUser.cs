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

                Console.WriteLine("Edit name");
                CurrentUser.current.Name = Console.ReadLine();

                Console.WriteLine("Edit age");
                CurrentUser.current.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Edit address");
                CurrentUser.current.Adress = Console.ReadLine();


            }







        }
    }

