using System;
namespace Accounts.Entities
{
    public class SavingAccount : Account
    {
        private double InterestRate { get; set; }

        public SavingAccount(int numAccount, int agNumber, double balance, string name, double interestedRate)
            : base(numAccount, agNumber, balance, name)
        {
            InterestRate = interestedRate;
        }

        public override void Deposit(double valueDep)
        {
            Balance += valueDep;
        }

        public override void Withdraw(double valueWith)
        {
            Balance -= valueWith;
        }

        public override void Transfer(double transfValue)
        {
            Deposit(transfValue);

        }

        public override string ToString()
        {
            return " HolderAccount : " + HolderAccount
                 + " Agency : " + AgNumber
                 + " Number Account : " + NumberAccount
                 + " Current Balance : " + Balance
                 + " Current Rate : " + InterestRate;

        }

    }
}
