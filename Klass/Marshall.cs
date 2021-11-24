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
        private string _address;
        private string _postalCode;
        private string _brand = "Unknown";
        private double _burnHours = 0;

        private DateTime _burnOutTime;
        private int _regByUser;


        public Marshall(int id, string brand, double burnHours, DateTime burnOutTime, string address, string postalCode, int regByUser)
        //konstruktor med all info
        {
            this._id = id;
            this._brand = brand;
            this._burnHours = burnHours;
            this._burnOutTime = burnOutTime;
            this._address = address;
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
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
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
            var byAddress = marshalls.OrderBy(x => x.Address).GroupBy(x => x.Address);
            foreach (var group in byAddress)
            {
                foreach (var m in group)
                {
                    if (DateTime.Now < m.BurnOutTime)
                    {
                        Console.WriteLine($@"
Marshall ID : {m.ID}
Address : {m.Address}, {m.PostalCode}
Brand : {m.Brand}
Expected burn time : {m.BurnHours}h.
Registered by user{m.RegByUser} at {m.RegTime}
Marshall will burn out at {m.BurnOutTime}
");
                    }
                }
            }
        }
        public static void PrintAllMarshalls()
        {
            var byAddress = marshalls.OrderBy(x => x.Address).GroupBy(x => x.Address);
            foreach (var group in byAddress)
            {
                foreach (var m in group)
                {
                    Console.WriteLine(value: $@"
Marshall ID : {m.ID}
Address : {m.Address}, {m.PostalCode}
Brand : {m.Brand}
Expected burn time : {m.BurnHours}h.
Registered by user{m.RegByUser} at {m.RegTime}
Marshall will burn out at {m.BurnOutTime}
");
                }
            }
        }


        public static void SearchMarshall()
        {
            int userInput = 0;
            do
            {
                Console.WriteLine(@"
Search for existing marshalls by :
1. Postal code
2. Go back to main menu
");
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
                Console.WriteLine("Enter postal code : ");
                string indata = (Console.ReadLine());
                CurrentUser.current.AddSearchCount();
                var postalCodeMarshall = marshalls.Where(name => name.PostalCode == indata);
                foreach (var group in postalCodeMarshall)
                {
                    if (DateTime.Now < group.BurnOutTime)
                    {
                        Console.WriteLine(@$"
Marshall ID : {group.ID}
Brand : {group.Brand}
Expected burn time : {group.BurnHours}h.
Address : {group.Address}, {group.PostalCode}
Registered by user{group.RegByUser} at {group.RegTime}
Marshall will burn out at {group.BurnOutTime}
");
                        test = false;
                    }
                }
                if (String.IsNullOrEmpty(indata))
                {
                    Console.WriteLine("Please enter some data!");
                    test = false;
                }
                else if (test)
                {

                    Console.WriteLine("No active marshalls on this postal code");
                    SearchMarshall();
                }
                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
                HeadMenu.MainMenu();
            }
        }
    }
}
