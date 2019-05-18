using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Interfaces;

namespace BankAccounts.Classes
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(string customer, customerType customerType, float interestRate) : base(customer, customerType, interestRate)
        {

        }

        public override float CalculateInterest(int numberOfMonths)
        {
            if (CustomerType == customerType.Company && MonthsActive <= 12)
            {
                return (numberOfMonths * InterestRate) / 2;
            }

            else if (CustomerType == customerType.Individual && MonthsActive <= 6)
            {
                return 0;
            }

            return numberOfMonths * InterestRate;
        }
    }
}
