using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Entities
{
    class GlobalSavingsAccount : SavingsAccount, IExchangeable
    {
        public GlobalSavingsAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {

        }
        public double USValue()
        {
            return currentBalance * .76;

        }
    }
}
    