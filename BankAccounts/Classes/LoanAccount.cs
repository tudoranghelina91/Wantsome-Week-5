using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Interfaces;

namespace BankAccounts.Classes
{
    public class LoanAccount : Account
    {
        public LoanAccount(string customer, customerType customerType, float interestRate) : base(customer, customerType, interestRate)
        {

        }

        public override float CalculateInterest(int numberOfMonths)
        {
            if (CustomerType == customerType.Individual && numberOfMonths > 3)
            {
                return numberOfMonths * InterestRate;
            }

            else if (CustomerType == customerType.Company && numberOfMonths > 2)
            {
                return numberOfMonths * InterestRate;
            }

            return 0;
        }
    }
}
