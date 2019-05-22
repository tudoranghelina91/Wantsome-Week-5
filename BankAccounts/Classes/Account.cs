using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Interfaces;
using IODS.Handlers;

namespace BankAccounts.Classes
{
    public abstract class Account : IDeposit
    {
        public enum customerType { Individual, Company };
        public customerType CustomerType { get; set; }
        public string Customer { get; set; }
        public float Balance { get; set; }
        public float InterestRate { get; set; }
        public int MonthsActive { get; set; }
        protected Account(string customer, customerType customerType, float interestRate)
        {
            Customer = customer;
            CustomerType = customerType;
            InterestRate = interestRate;
        }

        public void Deposit(float amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public virtual float CalculateInterest(int numberOfMonths)
        {
            return numberOfMonths * InterestRate;
        }

        public void Print()
        {
            Console.WriteLine($"Customer: {Customer}");
            Console.WriteLine($"Customer Type: {CustomerType}");
            Console.WriteLine($"Account Balance: {Balance}");
            Console.WriteLine($"Interest Rate: {InterestRate}");
            Console.WriteLine($"Months Active: {MonthsActive}");
            Console.WriteLine();
        }
    }
}
