using System;
using System.Collections.Generic;
using LighterGrp3.Metoder;

namespace LighterGrp3.Klass
{
    public class Marshall
    {
        private int _id;                    //userId + marshallNr
        private bool _active = false;       //
        private string _brand = "x";        //märke på marshall
        private string _address;            //adress 
        private int _postalCode;            //postnummer
        private double _lifeExp = 0.0 ;     //hur länge förväntas den brinna? Använd DateTime
        private double _expOut;             //när förväntas den slockna? Använd DateTime
        private double _regTime;            //när den registrerades. Använd DateTime
        private string _regByUser;          //userId + eventuellt userName
        private List<Marshall> _marshalls;

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
        public double LifeExp
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
        public double ExpOut
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
        public double RegTime
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
        public List<Marshall> Marshalls
        {
            get
            {
                return _marshalls;
            }
            set
            {
                _marshalls = value;
            }
        }

        public Marshall()
        //tom konstruktor
        {
        }
        public Marshall(int id, bool active, string brand, string address, int postalCode, double lifeExp, double expOut, double regTime, string regByUser)
        //konstruktor med all info
        {
            this._id = id;
            this._active = active;
            this._brand = brand;
            this._address = address;
            this._postalCode = postalCode;
            this._lifeExp = lifeExp;
            this._expOut = expOut;
            this._regTime = regTime;
            this._regByUser = regByUser;
        }
        public Marshall(string brand, double lifeExp)
        //konstruktor med märkesinfo
        {
            this._brand = brand;
            this._lifeExp = lifeExp;
        }
    }
}
