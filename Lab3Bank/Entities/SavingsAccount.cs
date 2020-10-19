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

        //^Change later
        public SavingsAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {

        }
        
        public override void MakeWithdrawl(double amount)
        {
            if (currentBalance <= 25)
            {
                status = Status.inactive;
            }
            else
                status = Status.active;
            //this should check if account is active and if true it will call Base MakeWithdrawl
            if (status == Status.active) { 
            base.MakeWithdrawl(amount);
            }
            //SLAP AN ERROR
        }

        public override void MakeDeposit(double amount)
        {
            if (currentBalance <= 25)
            {
                status = Status.inactive;
            }
            else
                status = Status.active;
            if (status == Status.inactive)
            {
                base.MakeDeposit(amount);
                if(amount > 25)
                {
                   status = Status.active;
                }

            }
            else
                base.MakeDeposit(amount);


        }
        public override string CloseAndReport()
        {
            if(base.numWithdrawal > 4)
            {
                
                base.serviceCharge += base.numWithdrawal - 4;
            }

            
            
            return base.CloseAndReport();
        }
    }
}
