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
                Console.Write("Enter name : ");
                string name = Console.ReadLine();
                Console.Write("Enter age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Adress : ");
                string adress = Console.ReadLine();
                int numberofsearches = 0;
                int numberofregisteredlighters = 0;
                int numberoflostlighters = 0;

                new User(id, name, age, adress, numberofsearches, numberofregisteredlighters, numberoflostlighters);
        }

        public static void PrintUser()
        {
            foreach (User u in User.users)
            {
                Console.WriteLine("ID : {0}",u.ID);
                Console.WriteLine("Name : {0}", u.Name);
                Console.WriteLine("Age : {0}", u.Age);
                Console.WriteLine("Adress : {0}", u.Adress);
                Console.WriteLine("Number of searches : {0}", u.NumberOfSearches);
                Console.WriteLine("Number of registered lighters : {0}", u.NumberOfRegisteredLighters);
                Console.WriteLine("Number of lost lighters : {0}", u.NumberOfLostLighters);
            }
        }

       
        

    }
}
