using ConsoleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Services
{
    static class AccountServices
    {
        static List<Account> Accounts = new List<Account>();

        public static void Create()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("|     Create new account           |");
            Console.WriteLine("====================================");

            // Seed to generate random int.
            Random seed = new Random();

            // Create new holder.
            Console.Write("Enter the Holder name: ");
            string holderName = Console.ReadLine();

            Holder holder = new Holder(seed.Next(9999), holderName);

            // Create new account.
            Console.Write("Enter the account ID: ");
            int accID = int.Parse(Console.ReadLine());
            Console.Write("Enter initial balance: ");
            double accBal = double.Parse(Console.ReadLine());

            Account acc = new Account(accID, accBal);
            acc.AddHolder(holder); // Add holder to the account.
            Accounts.Add(acc);

            Console.WriteLine("\nAccount created!\n");
            Console.WriteLine(holder);
            Console.WriteLine(acc);
            Console.WriteLine();
        }

        public static void Read()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("|     Account infos                |");
            Console.WriteLine("====================================");

            foreach(Account account in Accounts)
            {
                account.Holders.ForEach(Console.WriteLine);
                Console.WriteLine(account);
                Console.WriteLine();
            }
        }
    }
}
