using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Entities
{
    class GlobalSavingsAccount : SavingsAccount, IExchangeable
    {
        GlobalSavingsAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {

        }
        public double USValue(double rate)
        {
            currentBalance = currentBalance * rate;
            return currentBalance;

        }
    }
}
