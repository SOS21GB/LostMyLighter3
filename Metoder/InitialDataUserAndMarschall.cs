using System;
using LighterGrp3.Klass;

namespace LighterGrp3.Metoder
{
    public class InitialDataUserAndMarschall
    {
        // Existerande data så att det finns fyra användare och fyra marschaller från början.
        public static void InitialData()
        {
            User user = new User(100, "Kalle Karlsson", 30, "Karlssons väg 1", 0, 0, 0);
            User user2 = new User(200, "Anna Andersson", 40, "Anderssons väg 2", 0, 0, 0);
            User user3 = new User(300, "Lisa Larsson", 45, "Larssons Gata 3", 0, 0, 0);
            User user4 = new User(400, "Olle Olsson", 50, "Olssons Gata 4", 0, 0, 0);
            DateTime dt = new DateTime(2021,11,16); // Tillfälligt datetime för konstruktorn
            Marshall marshall = new Marshall(01, 20, true, "märke1", "Sveagatan 1", 10000,dt, dt, dt, "user1");
            Marshall marshall2 = new Marshall(02, 30, true, "märke2", "Svegatan 2", 20000, dt, dt, dt, "user2");
            Marshall marshall3 = new Marshall(03, 40, true, "märke3", "Sveagatan 3", 30000, dt, dt, dt, "user3");
            Marshall marshall4 = new Marshall(04, 50, true, "märke4", "Sveagatan 4", 40000, dt, dt, dt, "user4");
        }
      

      
    }
}
