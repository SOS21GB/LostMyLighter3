using System;
using System.Collections.Generic;

namespace LighterGrp3.Klass
{




    public class User

    {
        //Fields & Properties
        public int ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int NumberOfSearches { get; set; }
        public int NumberOfRegisteredMarshalls { get; set; }
        public int NumberOfLostLighters { get; set; }
        public static Dictionary<int, User> users = new Dictionary<int, User>();


        //Tom konstruktor


        //Konstruktor med alla fields 
        public User(int id, string name, int age, string address, int numberofsearches, int numberofregisteredmarshalls, int numberoflostlighters)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.NumberOfSearches = numberofsearches;
            this.NumberOfRegisteredMarshalls = numberofregisteredmarshalls;
            this.NumberOfLostLighters = numberoflostlighters;
            users.Add(ID, this);
        }

        public void PrintCurrentUser()
        {
            Console.WriteLine($@"
User{ID}
Name : {Name}
Age : {Age}
Address : {Address}
Number of searches : {NumberOfSearches}
Number of registered marshalls : {NumberOfRegisteredMarshalls}
Number of lost lighters : {NumberOfLostLighters}
");
        }


        public static User GetUserId(int id)
        {

            return users[id];
        }


        public void AddSearchCount()
        {
            NumberOfSearches++;
        }
        public static void AddRegisteredMarshall()
        {

            CurrentUser.current.NumberOfRegisteredMarshalls++;
        }


        public void AddLostLighter()
        {
            NumberOfLostLighters++;

            Console.WriteLine(@$"
Number of lost lighters : {NumberOfLostLighters}
Press any key to return to main menu.
");

            Console.ReadKey();
            HeadMenu.MainMenu();
        }
    }



}
