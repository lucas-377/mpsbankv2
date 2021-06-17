using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Entities
{
    class Account
    {
        public int Id { get; set; }
        public double Balance { get; private set; }
        public List<Holder> Holders { get; set; } = new List<Holder>();

        public Account() { }

        public Account(int id)
        {
            Id = id;
        }

        public void AddHolder(Holder holder)
        {
            Holders.Add(holder);
        }

        public void RemoveHolder(Holder holder)
        {
            Holders.Remove(holder);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Console.Write("No balance for this operation, try with another amount.");
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            return 
                "Account ID: " + Id +
                "\nTotal balance: $ " + Balance;
        }
    }
}
