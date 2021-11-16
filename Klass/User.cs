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
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public int NumberOfSearches { get; set; } 
        public int NumberOfRegisteredLighters { get; set; } 
        public int NumberOfLostLighters { get; set; } 
        public static List<User> users = new List<User>();


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
            users.Add(this);
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
            Console.ReadKey();
            HeadMenu.MainMenu();
        }
    }

    

}
