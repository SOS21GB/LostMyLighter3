using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LighterGrp3.Metoder
{
    class MarshallMetoder
    {
        public static void AddMarshall()
        {

            Marshall marshalls = new Marshall();

            marshalls.NR++;

            marshalls.ID =  /*userID+*/ marshalls.NR;
            Console.Write("What brand is your marshall? ");
            marshalls.Brand = Console.ReadLine();
            Console.Write("Is this marshall active? [Y/N] ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Yes":
                case "yes":
                case "Y":
                case "y":
                    marshalls.Active = true;
                    break;
                default:
                    marshalls.Active = false;
                    break;
            }
            Console.Write("address");
            marshalls.Address = Console.ReadLine();

            Console.Write("zip/postal; [XXX XX]: ");
            marshalls.PostalCode = Convert.ToInt32(Console.ReadLine());

            marshalls.RegTime = DateTime.Now;
            Console.Write("How long does it last? ");
            marshalls.LifeExp = Convert.ToInt32(Console.ReadLine());
            marshalls.ExpOut = marshalls.RegTime.AddYears(-marshalls.LifeExp);
            
        }

        static void PrintInfo()
        {
            Console.WriteLine("ID: {0}.", );
        }








            /*

            void PrintInfo()
            {
                Console.WriteLine("Marsall {0} is located at {1}, {2}.", marshall.ID, marshall.Address, marshall.PostalCode);
                Console.WriteLine("The brand is {0} and has an estimated burn time of {1} hours.");
                if (marshalls.Active = true)
                {
                    Console.WriteLine("The marshall is burning NOW and should burn out at {0}.");
                }
                Console.WriteLine("User {0} registered this {1}");
            }

            void AddBrand()
            {
                Console.WriteLine("Brand: ");
                marshall.Brand = Console.ReadLine();
                Console.WriteLine("How many hours?? (if you don't know, press [0].");
                marshall.LifeExp = Convert.ToDateTime(Console.ReadLine());
                Convert.ToDateTime(marshall.LifeExp);


            }


            */

        }
    }
}
