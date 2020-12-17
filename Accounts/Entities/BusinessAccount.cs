using System;
namespace Accounts.Entities
{
    public class BusinessAccount : Account
    {
        public double LimitLoan { get; set; }

        public BusinessAccount(int numAccount, int agNumber, double balance, string name, double limitLoan)
            : base(numAccount, agNumber, balance, name)
        {
            LimitLoan = limitLoan;
        }

        public override void Deposit(double valueDep)
        {
            Balance += valueDep;
        }

        public override void Withdraw(double valueWith)
        {
            Balance -= valueWith - 2.0;
        }

        public override void Transfer(double transfValue)
        {
            Balance += transfValue - 2.0;
        }

        public override string ToString()
        {
            return " HolderAccount : " + HolderAccount
                 + " Agency : " + AgNumber
                 + " Number Account : " + NumberAccount
                 + " Current Balance : " + Balance
                 + " Limit Loan : " + LimitLoan;
        }
    }
}
