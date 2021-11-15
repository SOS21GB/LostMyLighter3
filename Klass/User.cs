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
        public List<User> Users
        {
            get { return Users; }
            set { }
        }
            

        //Tom konstruktor

        public User()
        {
            
        }

        

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
            
        }


        public void AddSearchCount()
        {
            NumberOfSearches++;
        }



    }

    

}
