using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Interfaces;

namespace BankAccounts.Classes
{
    public class DepositAccount : Account, IWithdraw
    {

        public override float CalculateInterest(int numberOfMonths)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }

            return numberOfMonths * InterestRate;
        }

        public DepositAccount(string customer, customerType customerType, float interestRate) : base(customer, customerType, interestRate)
        {

        }

        public void Withdraw(float amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
            }
        }
    }
}
