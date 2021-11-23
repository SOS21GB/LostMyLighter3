﻿using System;
using System.Collections.Generic;
using LighterGrp3.Klass;
namespace LighterGrp3.Metoder


{
    public class LogIn
    {
        public static User LogInMethod()
        {
            Console.WriteLine("Enter you're user ID : ");

            try
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                foreach (KeyValuePair<int, User> user in User.users)
                {

                    if (user.Value.ID == answer)
                    {
                        Console.WriteLine("Successfull login.");
                        return user.Value;
                    }
                }
                Console.WriteLine("Incorrect login. Please try again.");
                StartingScreen.StartMenu();
                return null;
            }


            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                StartingScreen.StartMenu();
                return null;
            }



        }
    }
}
