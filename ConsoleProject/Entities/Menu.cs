using ConsoleProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Entities
{
    static class Menu
    {
        public static void Home()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("|     Welcome to MPSBank v2.0!     |");
            Console.WriteLine("====================================");
            Console.WriteLine("Choose an option below: \n");
            Console.WriteLine("1. Create a new account");
            Console.WriteLine("2. Show account infos");
            Console.WriteLine("3. Edit existing account");
            Console.WriteLine("4. Delete existing account");
            Console.WriteLine("5. Access MPS ATM");
            Console.WriteLine("6. Exit");
            Console.Write("\nYour option: ");
            int menuOption = int.Parse(Console.ReadLine());

            if (menuOption == 1)
            {
                AccountServices.Create();
                Inner();
            }

            else if (menuOption == 2)
            {
                AccountServices.Read();
                Inner();
            }

            else if(menuOption == 6)
            {
                Environment.Exit(0);
            }

            else
            {
                Home();
            }
        }

        public static void Inner()
        {
            Console.WriteLine("Choose an option below: \n");
            Console.WriteLine("1. Back to home");
            Console.WriteLine("2. Exit");
            Console.Write("\nYour option: ");
            int opt = int.Parse(Console.ReadLine());

            if (opt != 1)
            {
                Environment.Exit(0);
            }

            else
            {
                Home();
            }
        }
    }
}
