using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Entities
{
    class ChequingAccount : Account
    {
        ChequingAccount sav = new ChequingAccount(2, 5);
        ChequingAccount(double balance, double annualInterestRate) : base(balance, annualInterestRate)
        {

        }
        public override void MakeWithdrawl(double amount)
        {
            //text is very odd
            /*
             * Before the super class method is called, this method will determine if a withdrawal (a
  check written) will cause the balance to go below $0. If the balance goes below $0, a
  service charge of $15 will be taken from the account. The withdrawal will not be made
  due to insufficient funds. If there isn’t enough in the account to pay the service charge,
  the balance will become negative and the customer will owe the negative amount to the
  bank.
             */
        }
        public override void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }
        public override string CloseAndReport()
        {
            double fee = 5 + (0.10 * sav.numWithdrawal);
            sav.serviceCharge += fee;
            return base.CloseAndReport();
        }
    }
}
