using System;
namespace Accounts
{
    public class Account
    {
        public int NumberAccount { get; set; }
        public int AgNumber { get; set; }
        public string HolderAccount { get; private set; }
        private double _balance;

        public Account(int numAccount, int agNumber, double balance, string name)
        {
            NumberAccount = numAccount;
            AgNumber = agNumber;
            _balance = balance;
            HolderAccount = name;
        }

        public Account()
        {
        }

        public double Balance
        {
            get { return _balance; }

            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("The balance must be greater than 0. Please, make a deposit.");
                }
            }
        }

        public virtual void Deposit(double valueDep)
        {
            Balance += valueDep;
        }

        public virtual void Withdraw(double valueWith)
        {
            Balance = valueWith - 5.0;
        }

        public virtual void Transfer(double transfValue)
        {
            Balance += transfValue - 5.0;
        }

        public override string ToString()
        {
            return "HolderAccount : " + HolderAccount
                 + " Agency : " + AgNumber
                 + " Number Account : " + NumberAccount
                 + " Current Balance : " + Balance;

        }
    }
}
