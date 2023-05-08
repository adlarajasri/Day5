using System;
namespace AccountsDemoApp
{
    class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;
        public Account()
        {
            Console.WriteLine("Object Created");
        }
        ~Account()
        {
            Console.WriteLine("Object Destroyed");
        }
        public void CreateAccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("***** Account Information *****");
            Console.WriteLine("Account Id:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Opening Balance:" + Balance);
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance - amount < 500)
                throw new ApplicationException("Insufficient Balance");
            else
                this.Balance -= amount;
        }
    }
}