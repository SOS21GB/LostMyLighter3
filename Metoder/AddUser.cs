using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LighterGrp3.Klass;

namespace LighterGrp3.Metoder
{
    class AddUser
    {

        public static void AddUserFromConsole()
        {

                int id = User.users.Count()+1;
                Console.WriteLine($"Your ID : {id}");
                Console.Write("Enter name : ");
                string name = Console.ReadLine();
                Console.Write("Enter age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Address : ");
                string address = Console.ReadLine();
                int numberofsearches = 0;
                int numberofregisteredlighters = 0;
                int numberoflostlighters = 0;


                CurrentUser.current = new User(id, name, age, address, numberofsearches, numberofregisteredlighters, numberoflostlighters);
                
                HeadMenu.MainMenu();
        }

        
        
        public static void PrintAllUsers()
        {
            foreach (KeyValuePair<int, User> u in User.users)
            {
                Console.WriteLine($@"User{u.Value.ID}
Name : {u.Value.Name}
Age : {u.Value.Age}
Address : {u.Value.Address}
Number of searches : {u.Value.NumberOfSearches}
Number of registered marshalls : {u.Value.NumberOfRegisteredMarshalls}
Number of lost lighters : {u.Value.NumberOfLostLighters}
");
            }
        }
        
        

       
        

    }
}
