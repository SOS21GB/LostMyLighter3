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
                Console.WriteLine("Your ID : {0}", id);
                Console.Write("Enter name : ");
                string name = Console.ReadLine();
                Console.Write("Enter age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Adress : ");
                string adress = Console.ReadLine();
                int numberofsearches = 0;
                int numberofregisteredlighters = 0;
                int numberoflostlighters = 0;


                CurrentUser.current = new User(id, name, age, adress, numberofsearches, numberofregisteredlighters, numberoflostlighters);
                
                HeadMenu.MainMenu();
        }

        
        
        public static void PrintAllUsers()
        {
            foreach (KeyValuePair<int, User> u in User.users)
            {
                Console.WriteLine("ID : {0}",u.Value.ID);
                Console.WriteLine("Name : {0}", u.Value.Name);
                Console.WriteLine("Age : {0}", u.Value.Age);
                Console.WriteLine("Adress : {0}", u.Value.Adress);
                Console.WriteLine("Number of searches : {0}", u.Value.NumberOfSearches);
                Console.WriteLine("Number of registered lighters : {0}", u.Value.NumberOfRegisteredMarshalls);
                Console.WriteLine("Number of lost lighters : {0}", u.Value.NumberOfLostLighters);
            }
        }
        
        

       
        

    }
}
