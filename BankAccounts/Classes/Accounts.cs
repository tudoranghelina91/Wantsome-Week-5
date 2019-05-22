using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Classes
{
     public static class Accounts
     {
        public static Account[] CreateAccounts()
        {
            DepositAccount personalDeposit = new DepositAccount("Ionel Ionescu", Account.customerType.Individual, 13);
            personalDeposit.MonthsActive = 2;
            personalDeposit.Balance = 50000;
            personalDeposit.Withdraw(200);
            personalDeposit.Deposit(200);

            DepositAccount corporateDeposit = new DepositAccount("S.C. GELU S.R.L.", Account.customerType.Company, 44);
            corporateDeposit.MonthsActive = 2;
            corporateDeposit.Balance = 50000;
            corporateDeposit.Withdraw(200);
            corporateDeposit.Deposit(200);

            LoanAccount personalLoan = new LoanAccount("Marian Andreescu", Account.customerType.Individual, 41);
            personalLoan.MonthsActive = 2;
            personalLoan.Balance = 48000;
            personalLoan.Deposit(200);

            LoanAccount corporateLoan = new LoanAccount("S.C. MARTIANUL S.R.L.", Account.customerType.Company, 22);
            corporateLoan.MonthsActive = 2;
            corporateLoan.Balance = 48000;
            corporateLoan.Deposit(200);

            MortgageAccount personalMortgage = new MortgageAccount("Vasile Ciocan", Account.customerType.Individual, 42);
            personalMortgage.MonthsActive = 2;
            personalMortgage.Balance = 48000;
            personalMortgage.Deposit(200);

            MortgageAccount corporateMortgage = new MortgageAccount("S.C PINGELE S.R.L.", Account.customerType.Company, 112);
            corporateMortgage.MonthsActive = 2;
            corporateMortgage.Balance = 48000;
            corporateMortgage.Deposit(200);

            DepositAccount personalDeposit2 = new DepositAccount("Ionel Ionescu", Account.customerType.Individual, 13);
            personalDeposit2.MonthsActive = 3;
            personalDeposit2.Balance = 50000;
            personalDeposit2.Withdraw(200);
            personalDeposit2.Deposit(200);

            DepositAccount corporateDeposit2 = new DepositAccount("S.C. GELU S.R.L.", Account.customerType.Company, 44);
            corporateDeposit2.MonthsActive = 3;
            corporateDeposit2.Balance = 50000;
            corporateDeposit2.Withdraw(200);
            corporateDeposit2.Deposit(200);

            LoanAccount personalLoan2 = new LoanAccount("Marian Andreescu", Account.customerType.Individual, 41);
            personalLoan2.MonthsActive = 3;
            personalLoan2.Balance = 50000;
            personalLoan2.Deposit(200);

            LoanAccount corporateLoan2 = new LoanAccount("S.C. MARTIANUL S.R.L.", Account.customerType.Company, 22);
            corporateLoan2.MonthsActive = 3;
            corporateLoan2.Balance = 48000;
            corporateLoan2.Deposit(200);

            MortgageAccount personalMortgage2 = new MortgageAccount("Vasile Ciocan", Account.customerType.Individual, 42);
            personalMortgage2.MonthsActive = 3;
            personalMortgage2.Balance = 48000;
            personalMortgage2.Deposit(200);

            MortgageAccount corporateMortgage2 = new MortgageAccount("S.C PINGELE S.R.L.", Account.customerType.Company, 112);
            corporateMortgage2.MonthsActive = 3;
            corporateMortgage2.Balance = 48000;
            corporateMortgage2.Deposit(200);

            return new Account[] { personalDeposit, corporateDeposit, personalLoan, corporateLoan, personalMortgage, corporateMortgage,
                personalDeposit2, corporateDeposit2, personalLoan2, corporateLoan2, personalMortgage2, corporateMortgage2
            };
        }
     }
}
