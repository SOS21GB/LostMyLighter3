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
            var byAdress = marshalls.OrderBy(x => x.Address).GroupBy(x => x.Address);
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
                        Console.WriteLine("Registered by : User{0} ", m.RegByUser);
                        Console.WriteLine();


                    }
                }
            }
        }


        public static void AddExistingMarshall()
        {



        }

        public static void ShowExistingMarshall()
        {


        }
       
    }
}
