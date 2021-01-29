﻿using System;
using EducationPortal.Prompt.Infrastructure;
using EducationPortal.Prompt.Views.Shared;

namespace EducationPortal.Prompt.Views.Account
{
    public static class Profile
    {
        public static void Show(string msg = null)
        {
            Console.Clear();
            Header.Show();

            if (msg != null)
            {
                Console.WriteLine("========");
                Console.WriteLine($"message: {msg}");
                Console.WriteLine("========");
            }

            if (Provider.AuthorizedUser != null)
            {
                Console.WriteLine("Profile.");
                Console.WriteLine($"Welcome, {Provider.AuthorizedUser.Login}");

                Console.WriteLine("(3)My Videos \n" +
                                  "(4)Log Out. \n" +
                                  "(5)Exit");

                int.TryParse(Console.ReadLine(), out var option);

                Console.Clear();

                switch (option)
                {
                    case 3:
                        // Videos.Show(tm);
                        break;
                    case 4:
                        Provider.AccountController.Logout();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
                
                Console.Clear();

                Home.Home.Show();
            }
        }
    }
}
