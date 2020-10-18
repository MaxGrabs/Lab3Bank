using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Entities
{
    public abstract class Account : IAccount
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
            
            Console.WriteLine(totalDeposit);
            Console.WriteLine(totalWithdrawal);
            Console.WriteLine(numDeposit);
            Console.WriteLine(numWithdrawal);
            double percentage = (currentBalance / startBalance) * 100;
               
            string end =  "starting balance of the month " + startBalance + " Balance at the end of the month " + currentBalance + " the change in balance over the month " + "%" + percentage;
            string hello = "hello";
            /*

            startBalance = currentBalance;
            totalDeposit = 0;
            numWithdrawal = 0;
            numDeposit = 0;
            totalWithdrawal = 0;
            */
            //ALSO PRINT ANY DETAILS THAT public void CalculateInterest() may print
            return hello;
        }

        public virtual void MakeWithdrawl(double amount)
        {
            currentBalance -= amount;
            totalWithdrawal += amount;
            numWithdrawal++;
        }
    }
}
