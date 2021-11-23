using System;
using System.Collections.Generic;
using System.Linq;

namespace LighterGrp3.Klass
{
    class Marshall
    {
        public static List<Marshall> marshalls = new List<Marshall>();

        private DateTime _regTime = DateTime.Now;
        private int _id;
        private string _adress;
        private string _postalCode;
        private string _brand = "Unknown";
        private double _burnHours = 0;

        private DateTime _burnOutTime;
        private int _regByUser;


        public Marshall(int id, string brand, double burnHours, DateTime burnOutTime, string adress, string postalCode, int regByUser)
        //konstruktor med all info
        {
            this._id = id;
            this._brand = brand;
            this._burnHours = burnHours;

            this._burnOutTime = burnOutTime;
            this._adress = adress;
            this._postalCode = postalCode;
            this._regByUser = regByUser;

            marshalls.Add(this);
        }

        public DateTime RegTime
        {
            get
            {
                return _regTime;
            }
            set
            {
                _regTime = value;
            }
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        public double BurnHours
        {
            get
            {
                return _burnHours;
            }
            set
            {
                _burnHours = value;
            }
        }

        public DateTime BurnOutTime
        {
            get
            {
                return _burnOutTime;
            }
            set
            {
                _burnOutTime = value;
            }
        }
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return _postalCode;
            }
            set
            {
                _postalCode = value;
            }
        }
        public int RegByUser
        {
            get
            {
                return _regByUser;
            }
            set
            {
                _regByUser = value;
            }
        }

        public static void ActiveMarshalls()
        {
            var byAdress = marshalls.OrderBy(x => x.Adress).GroupBy(x => x.Adress);
            foreach (var group in byAdress)
            {
                Console.WriteLine(group.Key);

                foreach (var m in group)
                {
                    if (DateTime.Now < m.BurnOutTime)
                    {


                        Console.WriteLine($"Brand : {m.Brand}");
                        Console.WriteLine($"Address : {m.Address} {m.PostalCode}");
                        Console.WriteLine($"Will burn out in {m.BurnOutTime} hours.");
                        Console.WriteLine($"Registered by : User{m.RegByUser}, {m.RegTime}");

                        Console.WriteLine();


                    }
                }
            }
        }
        public static void PrintAllMarshalls()
        {
            var byAdress = marshalls.OrderBy(x => x.Adress).GroupBy(x => x.Adress);
            foreach (var group in byAdress)
            {
                Console.Write(group.Key);

                foreach (var m in group)
                {
                    Console.WriteLine(" {0}",m.PostalCode);
                    Console.WriteLine(m.Brand);
                    Console.WriteLine(m.BurnOutTime);
                    Console.WriteLine("Registered by user{0}, {1} ", m.RegByUser, m.RegTime);
                    Console.WriteLine();
                }
            }
        }

 
        public static void SearchMarshall()
        {
            int userInput = 0;
            do
            {
                Console.WriteLine("Search for existing marshalls by:\n");
                Console.WriteLine("1. Postalcode");
               
                Console.WriteLine("2. Go back to main menu");



                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }

            }
            while (userInput == 0 || userInput > 4);

            switch (userInput)
            {
                case 1:
                    SearchMarshallPostalCode();
                    break;

                case 2:
                    HeadMenu.MainMenu();
                    break;

            }

        }
        public static void SearchMarshallPostalCode()
        {



            bool test = true;
            while (test)
            {



                Console.WriteLine("Enter postalcode");
                string indata = (Console.ReadLine());
                CurrentUser.current.AddSearchCount();
                var postalCodeMarshall = marshalls.Where(name => name.PostalCode == indata);
                foreach (var group in postalCodeMarshall)
                {
                    Console.WriteLine("Marhall ID: {0}", group.ID);
                    Console.WriteLine("Marshall brand: {0}", group.Brand);
                    Console.WriteLine("Marshall expected burntime {0}", group.BurnHours);
                    Console.WriteLine("Marshall adress {0}", group.Adress);
                    Console.WriteLine("Marshall postal code {0}", group.PostalCode);
                    Console.WriteLine("Marshall registered time {0}", group.RegTime);
                    Console.WriteLine("Marshall will expire in {0}", group.BurnOutTime);
                    Console.WriteLine("User ID:{0}", CurrentUser.current.ID);
                    Console.WriteLine();
                    test = false;

                    
                }

                if (test)
                {
                    
                    Console.WriteLine("Wrong postalcode");
                    

                    SearchMarshall();
                }

                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
                HeadMenu.MainMenu();
            }
        }

    }

}
