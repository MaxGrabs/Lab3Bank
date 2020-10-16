using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bank.Extensions
{
    static class Class1
    {
        
        public static bool isDivisible(this int val, int divisor)
        {
            return val % divisor == 0; ;
        }

    }
}
