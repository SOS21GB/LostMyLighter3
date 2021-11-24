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

        //kanske lägga till metod för att TÄNDA en marschall? Kanske det vi tänkte med add existing /Vips
        public static void AddMarshallFromConsole()
        {
            DateTime regTime = DateTime.Now;
            int id = Marshall.marshalls.Count() + 1;
            Console.WriteLine($"Marshall ID : {id}");
            Console.Write("Enter address : ");
            string address = Console.ReadLine();
            Console.Write("Enter postal code : ");
            string postalCode = Console.ReadLine();
            Console.Write("Enter brand : ");
            string brand = Console.ReadLine();
            Console.Write("Enter total burn hours : ");
            double burnHours = Convert.ToDouble(Console.ReadLine());
            
            DateTime burnOutTime = DateTime.Now.AddHours(burnHours);
            Console.WriteLine($"Marshall will burn out at {burnOutTime}");
            int regByUser = CurrentUser.current.ID;
            User.AddRegisteredMarshall();


            new Marshall( id, brand, burnHours, burnOutTime, address, postalCode, regByUser);
            HeadMenu.MainMenu();


        }
    }
}
