using LighterGrp3.Klass;
using System;

namespace LighterGrp3.Metoder
{
    class MarshallMetoder
    {
        public void NewMarshall()
        {
            Klass.Marshall marshall = new Marshall();
            marshall.NR++;
            marshall.ID = /*userid+*/ marshall.NR;

            Console.Write("At what address is this marshall located? ");
            marshall.Address = Console.ReadLine();

            Console.Write("For the tracker to work, we need the zip/postal code as well; [XXX XX]: ");
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
                Console.WriteLine("What brand is your marshall? ");
                marshall.Brand = Console.ReadLine();
                Console.WriteLine ("How many hours is the estimated burn time? (if you don't know, press [0].");
                marshall.LifeExp = Convert.ToDateTime(Console.ReadLine());
                Convert.ToDateTime(marshall.LifeExp);


            }




        }
    }
}
