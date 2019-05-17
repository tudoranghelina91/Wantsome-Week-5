using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Interfaces;

namespace BankAccounts.Classes
{
    public class MortgageAccount : Account, IDeposit
    {
        public void Deposit(float amount)
        {

        }

        public override float CalculateInterest(int numberOfMonths)
        {
            if (Customer == customer.Company && MonthsActive <= 12)
            {
                return (numberOfMonths * InterestRate) / 2;
            }

            else if (Customer == customer.Individual && MonthsActive <= 6)
            {
                return 0;
            }

            return numberOfMonths * InterestRate;
        }
    }
}
