using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Lab3Bank.Entities;


namespace Lab3Bank.Extensions
{
    public static class MyExtensions
    {
        //we dont know how to do without parameters while outside of Account
        public static double getPercentageChange( double curr, double start)
        {   

            double percentage = ((curr/start) * 100);
            return percentage;
        }

        public static string toNAMoneyFormat(double amount)
        {

          return amount.ToString("C2");
        }

    }
}
