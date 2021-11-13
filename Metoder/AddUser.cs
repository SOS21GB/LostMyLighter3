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
        public List<User> Users { get; set; }
        
        public static void AddUserFromConsole()
        {
            List<User> users = new List<User>();

                User User = new User();
                User.ID = users.Count() + 1;
                Console.Write("Enter name : ");
                User.Name = Console.ReadLine();
                Console.Write("Enter age : ");
                User.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Adress : ");
                User.Adress = Console.ReadLine();
                User.NumberOfSearches = 0;
                User.NumberOfRegisteredLighters = 0;
                User.NumberOfLostLighters = 0;
                users.Add(User);
              
        }

        

       
        

    }
}
