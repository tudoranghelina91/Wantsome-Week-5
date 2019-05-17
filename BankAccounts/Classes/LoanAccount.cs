using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Interfaces;

namespace BankAccounts.Classes
{
    public class LoanAccount : Account, IDeposit
    {
        public void Deposit(float amount)
        {

        }

        public override float CalculateInterest(int numberOfMonths)
        {
            if (Customer == customer.Individual && numberOfMonths > 3)
            {
                return numberOfMonths * InterestRate;
            }

            else if (Customer == customer.Company && numberOfMonths > 2)
            {
                return numberOfMonths * InterestRate;
            }

            return 0;
        }
    }
}
