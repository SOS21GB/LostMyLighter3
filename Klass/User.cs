using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LighterGrp3.Metoder;

namespace LighterGrp3.Klass
{
   
    class User
    {
        //Fields & Properties
        public int ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public int NumberOfSearches { get; set; } 
        public int NumberOfRegisteredLighters { get; set; } 
        public int NumberOfLostLighters { get; set; } 
        public static Dictionary<int, User> users = new Dictionary<int, User>();


        //Tom konstruktor


        //Konstruktor med alla fields 
        public User(int id, string name, int age, string adress, int numberofsearches, int numberofregisteredlighters, int numberoflostlighters)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Adress = adress;
            this.NumberOfSearches = numberofsearches;
            this.NumberOfRegisteredLighters = numberofregisteredlighters;
            this.NumberOfLostLighters = numberoflostlighters;
            users.Add(ID,this);
        }

        public void PrintCurrentUser()
        {
        
                Console.WriteLine("ID : {0}", ID);
                Console.WriteLine("Name : {0}",Name);
                Console.WriteLine("Age : {0}", Age);
                Console.WriteLine("Adress : {0}", Adress);
                Console.WriteLine("Number of searches : {0}", NumberOfSearches);
                Console.WriteLine("Number of registered lighters : {0}", NumberOfRegisteredLighters);
                Console.WriteLine("Number of lost lighters : {0}", NumberOfLostLighters);
      
        }


        public static User GetUserId(int id)
        {

            return users[id];
        }


        public void AddSearchCount()
        {
            NumberOfSearches++;
        }


        public void AddLostLighter()
        {
            NumberOfLostLighters++;
            Console.WriteLine("Number of lost lighters: {0}", NumberOfLostLighters);
            // Tryck för att komma vidare
            Console.WriteLine("Press any key to return to Main menu");
            Console.ReadKey();
            HeadMenu.MainMenu();
        }
    }

    

}
