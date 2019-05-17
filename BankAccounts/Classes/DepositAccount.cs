using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Interfaces;

namespace BankAccounts.Classes
{
    public class DepositAccount : Account, IDeposit, IWithdraw
    {
        public void Deposit(float amount)
        {

        }

        public void Withdraw(float amount)
        {

        }
    }
}
