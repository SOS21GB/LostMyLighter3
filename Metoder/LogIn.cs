using System;
using System.Collections.Generic;
using LighterGrp3.Klass;
namespace LighterGrp3.Metoder


{
    public class LogIn
    {
        public static User LogInMethod()
        {
            Console.WriteLine("Enter you're user ID: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<int, User> user in User.users)
            {
                
                if (user.Value.ID == answer)
                {
                    Console.WriteLine("Successfull Login");
                    return user.Value;
                }
            }
            return null;
        }
    }
}
