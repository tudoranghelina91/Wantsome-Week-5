using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Classes
{
    public abstract class Account
    {
        public enum customer { Individual, Company };
        public customer Customer { get; set; }
        public float Balance { get; set; }
        public float InterestRate { get; set; }
        public int MonthsActive { get; set; }

        public virtual float CalculateInterest(int numberOfMonths)
        {
            return numberOfMonths * InterestRate;
        }
    }
}
