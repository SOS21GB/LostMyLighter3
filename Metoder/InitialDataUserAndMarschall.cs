using LighterGrp3.Klass;
using System;

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
           
            Marshall marshall1 = new Marshall( 10, "märke1", 2,  DateTime.Now.AddHours(2), "Sveagatan 5", "12345", 100);
            Marshall marshall2 = new Marshall( 20, "märke2", 3, DateTime.Now.AddHours(3), "Sveagatan 4", "23456", 200);
            Marshall marshall3 = new Marshall( 30, "märke3", 4, DateTime.Now.AddHours(4), "Sveagatan 1", "34567", 300);
            Marshall marshall4 = new Marshall( 40, "märke4", 4, DateTime.Now.AddHours(4), "Sveagatan 3", "45678", 400);
            Marshall marshall5 = new Marshall( 10, "märke1", 4, DateTime.Now.AddHours(4), "Sveagatan 2", "12345", 100);
        }



    }
}
