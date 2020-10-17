using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Entities
{
    class SavingsAccount : Account
    {
        //Change later
        SavingsAccount sav = new SavingsAccount(2, 5);
        //^Change later
        public SavingsAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {

        }
        
        public override void MakeWithdrawl(double amount)
        {
            //this should check if account is active and if true it will call Base MakeWithdrawl
            if (sav.status == Status.active) { 
            base.MakeWithdrawl(amount);
            }
        }

        public override void MakeDeposit(double amount)
        {
            if (sav.status == Status.inactive)
            {
                base.MakeDeposit(amount);
                if(amount > 25)
                {
                    sav.status = Status.active;
                }

            }

        }
        public override string CloseAndReport()
        {
            if(sav.numWithdrawal > 4)
            {
                double temp = sav.numWithdrawal - 4;
                sav.serviceCharge += sav.serviceCharge + temp;
            }
            //um temporary
            return base.CloseAndReport();
        }
    }
}
