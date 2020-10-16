using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank
{/*
  * It has data fields that hold the following basic information about a bank account. The visibility is up to you, use
your knowledge from your previous Java course – the concept is the same.
• Starting balance this month
• Current balance this month
• Total of deposits this month (i.e. cumulative amount deposited)
• Number of deposits this month
• Total of withdrawals this month (i.e. cumulative amount withdrawn)
• Number of withdrawals this month
• Annual interest rate
• This month’s service charge
• Current account status (to represent an active or inactive account)
o Use an enum for this one.
  */
    abstract class Account : IAccount
    {
       protected double startBalance;
       protected double currentBalance;
       protected double totalDeposit;
       protected double numDeposit;
       protected double totalWithdrawal;
       protected double numWithdrawal;
       protected double interestRate;
       protected double serviceCharge;

       enum Status
        {
            active,
            inactive
        }
        //Constructor
        public Account(double CB, double IR)
        {
            currentBalance = CB;
            interestRate = IR;
        }
        public void MakeDeposit(double amount)
        {
            currentBalance += amount;
            totalDeposit += amount;
            numDeposit++;
        }
        public void CalculateInterest()
        {
            currentBalance += currentBalance * (interestRate / 12);
        }
        public string CloseAndReport()
        {
            currentBalance -= serviceCharge;
            CalculateInterest();
            
            Console.WriteLine(totalDeposit);
            Console.WriteLine(totalWithdrawal);
            Console.WriteLine(numDeposit);
            Console.WriteLine(numWithdrawal);
            double percentage = (currentBalance / startBalance) * 100;
            

            startBalance = currentBalance;
            totalDeposit = 0;
            numWithdrawal = 0;
            numDeposit = 0;
            totalWithdrawal = 0;
            //ALSO PRINT ANY DETAILS THAT public void CalculateInterest() may print
            return "starting balance of the month " + startBalance + " Balance at the end of the month " + currentBalance + " the change in balance over the month " + "%" + percentage;
        }

        public void MakeWithdrawl(double amount)
        {
            currentBalance -= amount;
            totalWithdrawal += amount;
            numWithdrawal++;
        }
    }
}
