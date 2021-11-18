using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LighterGrp3.Klass;

namespace LighterGrp3.Metoder
{
    class AddMarshall
    {
        public static void AddMarshallFromConsole()
        {
            DateTime regTime = DateTime.Now;
            int id = Marshall.marshalls.Count() + 1;
            Console.WriteLine("Marshall ID : {0}", id);
            Console.Write("Enter address : ");
            string address = Console.ReadLine();
            Console.Write("Enter postalcode : ");
            string postalCode = Console.ReadLine();
            Console.Write("Enter brand : ");
            string brand = Console.ReadLine();
            Console.Write("Enter total burn hours : ");
            double burnHours = Convert.ToDouble(Console.ReadLine());
            Console.Write("Is it active [Y/N]? ");
            string active = Console.ReadLine();
            bool isActive;
            switch (active)
            {
                case "Y":
                case "y":
                case "Yes":  //tänker att vi lägger in stränghantering senare för att korta ner här till max två val
                case "yes":
                    isActive = true;
                    break;
                default:
                    isActive = false;
                    break;
            }
            DateTime burnOutTime = DateTime.Now.AddHours(burnHours);
            Console.WriteLine("Marshall will burn out {0}", burnOutTime);
            int regByUser = CurrentUser.current.ID;

            new Marshall( id, brand, burnHours, isActive, burnOutTime, address, postalCode, regByUser);
        }
    }
}
