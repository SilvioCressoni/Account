using System;
using Accounts.Entities;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME. Lets open an Account.");

            SavingAccount accSavings = new SavingAccount(1001, 001, 1000.00, "Silvio Cressoni", 0.1);
            BusinessAccount bussAccount = new BusinessAccount(1002, 002, 1000.00, "Juliana Cressoni", 50.000);

            Console.WriteLine("---------------------");
            Console.WriteLine(accSavings.ToString());
            Console.WriteLine("---------------------");
            Console.WriteLine(bussAccount.ToString());

            accSavings.Transfer(100.0);
            accSavings.Withdraw(100.0);

            bussAccount.Transfer(100.0);
            bussAccount.Withdraw(100.0);

            Console.WriteLine("---------------------");
            Console.WriteLine(accSavings.ToString());
            Console.WriteLine("---------------------");
            Console.WriteLine(bussAccount.ToString());


        }
    }
}
