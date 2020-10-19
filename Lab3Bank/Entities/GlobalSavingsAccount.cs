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
        public double USValue(double rate)
        {
            return currentBalance * rate ;
            
        }

        public override void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }
        public override void MakeWithdrawl(double amount)
        {
            base.MakeWithdrawl(amount);
        }
        public override string CloseAndReport()
        {
            return base.CloseAndReport();
        }

    }
}
    