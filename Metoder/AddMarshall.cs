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
            
            DateTime burnOutTime = DateTime.Now.AddHours(burnHours);
            Console.WriteLine("Marshall will burn out {0}", burnOutTime);
            int regByUser = CurrentUser.current.ID;
            User.AddRegisteredMarshall();


            new Marshall( id, brand, burnHours, burnOutTime, address, postalCode, regByUser);
            HeadMenu.MainMenu();
        }
    }
}
