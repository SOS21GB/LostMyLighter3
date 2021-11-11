namespace LighterGrp3.Klass
{
    public class MarshallKlass
    {
        private int _id = 0; //userId + marshallNr
        private bool _active = false; //
        private string _brand = "x"; //märke på marshall
        private string _address; //adress 
        private int _postalCode; //postnummer
        private double _lifeExp; //hur länge förväntas den brinna? Använd DateTime
        private double _expOut; //när förväntas den slockna? Använd DateTime
        private double _regTime; //när den registrerades. Använd DateTime
        private string _userReg; //userId + eventuellt userName
        public MarshallKlass()
        {
        }
        public MarshallKlass(int id, bool active, string brand, string address, int postalCode, double lifeExp, double expOut, double regTime, string userReg)
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
            this._userReg = userReg;
        }
        public MarshallKlass(string brand, double lifeExp)
        //konstruktor med märkesinfo
        {
            this._brand = brand;
            this._lifeExp = lifeExp;
        }
        public MarshallKlass(int id, bool active, string address, int postalCode, double expOut)
        //konstruktor för aktiva marshaller
        {
            this._id = id;
            this._active = active;
            this._address = address;
            this._postalCode = postalCode;
            this._expOut = expOut;
        }
        public MarshallKlass(int id, string address, int postalCode, double lifeExp, string userReg)
        //konstruktor för alla marshaller, för ej inloggad användare
        {
            this._id = id;
            this._address = address;
            this._postalCode = postalCode;
            this._lifeExp = lifeExp;
            this._userReg = userReg;
        }
    }
}
