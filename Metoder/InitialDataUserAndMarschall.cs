using System;
using LighterGrp3.Klass;

namespace LighterGrp3.Metoder
{
    public class InitialDataUserAndMarschall
    {
        // Existerande data så att det finns fyra användare och fyra marschaller från början.
        public static void InitialData()
        {
            User user = new User(1, "Ida", 30, "Göteborg", 0, 0, 0);
            User user2 = new User(1, "Ida", 30, "Göteborg", 0, 0, 0);
            User user3 = new User(1, "Ida", 30, "Göteborg", 0, 0, 0);
            User user4 = new User(1, "Ida", 30, "Göteborg", 0, 0, 0);
            DateTime dt = new DateTime(2021,11,16); // Tillfälligt datetime för konstruktorn
            Marshall marshall = new Marshall(1, 2, true, "märke", "adress", 00000,dt, dt, dt, "användare");
            Marshall marshall2 = new Marshall(1, 2, true, "märke", "adress", 00000, dt, dt, dt, "användare");
            Marshall marshall3 = new Marshall(1, 2, true, "märke", "adress", 00000, dt, dt, dt, "användare");
            Marshall marshall4 = new Marshall(1, 2, true, "märke", "adress", 00000, dt, dt, dt, "användare");
        }
      

      
    }
}
