using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3Bank.Extensions;

namespace Lab3Bank.Entities
{
    public abstract class Account : IAccount
    {
        public double startBalance { get; set; }
        public double currentBalance{ get; set; }

        public double totalDeposit;
        public double numDeposit;
        public double totalWithdrawal;
        public double numWithdrawal;
        public double interestRate;
        public double serviceCharge;

        protected enum Status
        {
            active,
            inactive
        };
        protected Status status;
        //Constructor
        public Account(double balance, double annualInterestRate)
        {
            currentBalance = balance;
            interestRate = annualInterestRate;
        }
        public virtual void MakeDeposit(double amount)
        {
            currentBalance += amount;
            totalDeposit += amount;
            numDeposit++;
        }
        public virtual void CalculateInterest()
        {
            currentBalance += currentBalance * (interestRate / 12);
        }
        public virtual string CloseAndReport()
        {
            currentBalance -= serviceCharge;

            CalculateInterest();
            
            Console.WriteLine("Total Deposit " + totalDeposit);
            Console.WriteLine("Total Withdrawn " + totalWithdrawal);
            Console.WriteLine("Total number of Deposits " + numDeposit);
            Console.WriteLine("Total number of Withdrawals " + numWithdrawal);
          
           
               
           string end =  "starting balance of the month " + MyExtensions.toNAMoneyFormat(startBalance) +"\n Balance at the end of the month " + MyExtensions.toNAMoneyFormat(currentBalance) + "\n the change in balance over the month "  + MyExtensions.getPercentageChange(currentBalance, startBalance) + "%" + "\n";
            
            

            startBalance = currentBalance;
            totalDeposit = 0;
            numWithdrawal = 0;
            numDeposit = 0;
            totalWithdrawal = 0;
            
            //ALSO PRINT ANY DETAILS THAT public void CalculateInterest() may print
            return end;

        }

        public virtual void MakeWithdrawl(double amount)
        {
            currentBalance -= amount;
            totalWithdrawal += amount;
            numWithdrawal++;
        }

        

    }
}
