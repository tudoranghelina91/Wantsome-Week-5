using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Classes
{
    abstract class Account
    {
        public enum Customer { Individual, Company };
        public float Balance { get; set; }
        public float InterestRate { get; set; }

        public virtual float CalculateInterest(int numberOfMonths)
        {
            return numberOfMonths * InterestRate;
        }
    }
}
