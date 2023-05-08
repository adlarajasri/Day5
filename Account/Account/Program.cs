using System;
namespace AccountsDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("******************************");
                Console.WriteLine("**** Accounts Application ****");
                Console.WriteLine("******************************");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display Account Information");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. Withdraw Amount");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Enter Choice :");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter Account Id:");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Name:");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter Opening Balance:");
                        decimal Balance = decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(Id, Name, Balance);
                        break;
                    case 2:
                        if (a != null)
                            a.DisplayInfo();
                        else
                            Console.WriteLine("********* Open Account First *********\n");
                        break;
                    case 3:
                        if (a != null)
                            a.Deposit(5000);
                        else
                            Console.WriteLine("********* Open Account First *********\n");
                        break;
                    case 4:
                        if (a != null)
                            a.Withdraw(5000);
                        else
                            Console.WriteLine("********* Open Account First *********\n");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("********* Wrong Choice *********\n");
                        break;
                }
            } while (ch != 0);
            Console.WriteLine("Thanks for using the app");
        }
    }
}