using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Entities
{
    class ChequingAccount : Account
    {
 
      
       
        public ChequingAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {

        }
        public override void MakeWithdrawl(double amount)
        {
         
            //Hard to understand this one. Seems very harsh.
            if (currentBalance - amount < 0)
            {
                serviceCharge += 15;
            }
           else
                base.MakeWithdrawl(amount);

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
