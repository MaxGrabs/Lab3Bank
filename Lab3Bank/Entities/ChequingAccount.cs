using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Entities
{
    class ChequingAccount : Account
    {
        protected double startBalance;
        protected double currentBalance;
        protected double totalDeposit;
        protected double numDeposit;
        protected double totalWithdrawal;
        protected double numWithdrawal;
        protected double interestRate;
        protected double serviceCharge;

        protected enum Status
        {
            active,
            inactive
        };
        new protected Status status;
       
        public ChequingAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {

        }
        public override void MakeWithdrawl(double amount)
        {
            //Hard to understand this one. Seems very harsh.
           if(currentBalance - amount < 0)
            {
                serviceCharge += 15;
            }
           else
                base.MakeDeposit(amount);

        }
        public override void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }
        public override string CloseAndReport()
        {
            double fee = 5 + (0.10 * numWithdrawal);
            serviceCharge += fee;
            return base.CloseAndReport();
        }
    }
}
