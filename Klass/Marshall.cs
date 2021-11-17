using System;
using System.Collections.Generic;
using LighterGrp3.Metoder;
using System.Linq;

namespace LighterGrp3.Klass
{
    class Marshall
    {
        public static List<Marshall> marshalls = new List<Marshall>();

        private DateTime _regTime;           //när den registrerades. Använd DateTime
        private int _id;                               
        private string _address;                       //adress 
        private string _postalCode;                       //postnummer
        private string _brand = "Unknown";             
        private double _burnHours;                //hur länge förväntas den brinna? Använd DateTime
        private bool _isActive;                  
        private DateTime _burnOutTime;                      //när förväntas den slockna? Använd DateTime
        private int _regByUser = 0;                     //userId + eventuellt userName

        public Marshall(DateTime regTime, int id, string brand, double burnHours, bool isActive, DateTime burnOutTime, string address, string postalCode, int regByUser)
        //konstruktor med all info
        {
            this._id = id;
            this._regTime = regTime;
            this._brand = brand;
            this._burnHours = burnHours;
            this._isActive = isActive;
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
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
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
            foreach (Marshall m in marshalls)
            {
                if (m.IsActive)
                {
                    Console.WriteLine(m.IsActive);

                }
            }
        }
    }
}
