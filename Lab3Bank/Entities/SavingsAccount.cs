using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Entities

{
    class SavingsAccount : Account
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
        //Change later

        //^Change later
        public SavingsAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {

        }
        
        public override void MakeWithdrawl(double amount)
        {
            //this should check if account is active and if true it will call Base MakeWithdrawl
            if (status == Status.active) { 
            base.MakeWithdrawl(amount);
            }
            //SLAP AN ERROR
        }

        public override void MakeDeposit(double amount)
        {
            if (status == Status.inactive)
            {
                base.MakeDeposit(amount);
                if(amount > 25)
                {
                   status = Status.active;
                }

            }

            
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
