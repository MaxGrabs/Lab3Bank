using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank
{
    class SavingsAccount : Account
    {
       new public string CloseAndReport()
        {
            throw new NotImplementedException();
        }

       new public void MakeDeposit(double amount)
        {
            throw new NotImplementedException();
        }

       new public  void MakeWithdrawl(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
