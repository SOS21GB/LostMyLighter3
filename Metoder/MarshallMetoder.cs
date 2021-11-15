using LighterGrp3.Klass;
using System;

namespace LighterGrp3.Metoder
{
    class MarshallMetoder
    {
        public static void NewMarshall()
        {
            
            Marshall marshall = new Marshall();
            marshall.NR++;
            marshall.ID = /*userid+*/ marshall.NR;

            Console.Write("address");
            marshall.Address = Console.ReadLine();

            Console.Write("zip/postal; [XXX XX]: ");
            marshall.PostalCode = Convert.ToInt32(Console.ReadLine());


            
            void PrintInfo()
            {
                Console.WriteLine("Marsall {0} is located at {1}, {2}.", marshall.ID, marshall.Address, marshall.PostalCode);
                Console.WriteLine("The brand is {0} and has an estimated burn time of {1} hours.");
                if(marshall.Active = true)
                {
                    Console.WriteLine("The marshall is burning NOW and should burn out at {0}.");
                }
                Console.WriteLine("User {0} registered this {1}");
            }

            void AddBrand()
            {
                Console.WriteLine("Brand: ");
                marshall.Brand = Console.ReadLine();
                Console.WriteLine ("How many hours?? (if you don't know, press [0].");
                marshall.LifeExp = Convert.ToDateTime(Console.ReadLine());
                Convert.ToDateTime(marshall.LifeExp);


            }




        }
    }
}
