using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Classes;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = Accounts.CreateAccounts();
            foreach (Account account in accounts)
            {
                account.Print();
            }

            Console.ReadKey();
        }
    }
}
