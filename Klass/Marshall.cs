﻿using System;
using System.Collections.Generic;

namespace LighterGrp3.Klass
{
    class Marshall
    {
        public static List<Marshall> marshalls = new List<Marshall>();

        private int _nr = 0;                           //marshallNr - ska den räkna upp för varje så ID blir 11,12,53,24 osv eller 11,12,51,21?
        private int _id;                               //userId + marshallNr
        private string _brand = "Unknown";             //märke på marshall
        private bool _active = false;                  //
        private DateTime _lifeExp;                     //hur länge förväntas den brinna? Använd DateTime
        private DateTime _expOut;                      //när förväntas den slockna? Använd DateTime
        private DateTime _regTime;                     //när den registrerades. Använd DateTime
        private string _address;                       //adress 
        private int _postalCode;                       //postnummer
        private string _regByUser;                     //userId + eventuellt userName

        public Marshall(int nr, int id, bool active, string brand, string address, int postalCode, DateTime lifeExp, DateTime expOut, DateTime regTime, string regByUser)
        //konstruktor med all info
        {
            this._nr = nr;
            this._id = id;
            this._brand = brand;
            this._active = active;
            this._lifeExp = lifeExp;
            this._expOut = expOut;
            this._regTime = regTime;
            this._address = address;
            this._postalCode = postalCode;
            this._regByUser = regByUser;
            marshalls.Add(this);
        }
        public Marshall(string brand, DateTime lifeExp)
        //konstruktor med märkesinfo
        {
            this._brand = brand;
            this._lifeExp = lifeExp;
        }

        public int NR
        {
            get
            {
                return _nr;
            }
            set
            {
                _nr = value;
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
        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
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
        public int PostalCode
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
        public DateTime LifeExp
        {
            get
            {
                return _lifeExp;
            }
            set
            {
                _lifeExp = value;
            }
        }
        public DateTime ExpOut
        {
            get
            {
                return _expOut;
            }
            set
            {
                _expOut = value;
            }
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
        public string RegByUser
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



        void ActiveMarshalls()
        {
            foreach (Marshall m in marshalls)
            {
                if (Active)
                {
                    Console.WriteLine(Active);
                }
            }
        }
        //Marshall marshall = new Marshall();
    }
}