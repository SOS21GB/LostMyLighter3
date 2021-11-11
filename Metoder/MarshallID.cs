using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LighterGrp3.Metoder
{
    class MarshallID
    {
        
        static void Count()
        // marshallID utgörs av användarens ID på [0] och en uppräkning av antal tillagda marshaller av användaren på [1].
        // användare med userId (1) som lägger till sin första marshall får marshallId (11) och den andra (12).
        {
            int userId = 0; // metod för count
            int marshallNr = 0; // metod för count
            string marshallId = userId.ToString() + marshallNr.ToString();
            Console.WriteLine(userId);
            Console.WriteLine(marshallNr);
            Console.WriteLine(marshallId);
        }
    }
}
