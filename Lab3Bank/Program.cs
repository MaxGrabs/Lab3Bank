using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3Bank.Entities;


namespace Lab3Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            while (1 == 1) {
            try 
            {
                SavingsAccount sav = new SavingsAccount(2,0.12);
                ChequingAccount che = new ChequingAccount(3,0.12);
                GlobalSavingsAccount glo = new GlobalSavingsAccount(4,0.12);
                Console.WriteLine("A: Savings B: Checking C: GlobalSavings Q: Exit");
                String s = Console.ReadLine();
                switch(s.ToUpper()){
                    case "A":
                        Console.WriteLine("A: Deposit B: Withdrawal C: Close + Report R: Return to Bank Menu");
                        String a = Console.ReadLine();
                        switch (a.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("How much would you like to deposit?");
                                string depositString = Console.ReadLine();
                                double deposit = Convert.ToDouble(depositString);
                                sav.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("How much would you like to withdraw?");
                                string withdrawString = Console.ReadLine();
                                double withdraw = Convert.ToDouble(withdrawString);
                                sav.MakeDeposit(withdraw);
                                break;
                            case "C":
                                sav.CloseAndReport();
                                break;
                            case "R":
                                // come back 
                                break;

                        }
                        break;
                    case "B":
                        Console.WriteLine("A: Deposit B: Withdrawal C: Close + Report R: Return to Bank Menu");
                        String b = Console.ReadLine();
                        switch (b.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("How much would you like to deposit?");
                                string depositString = Console.ReadLine();
                                double deposit = Convert.ToDouble(depositString);
                                che.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("How much would you like to withdraw?");
                                string withdrawString = Console.ReadLine();
                                double withdraw = Convert.ToDouble(withdrawString);
                                che.MakeDeposit(withdraw);
                                break;
                            case "C":
                                che.CloseAndReport();
                                break;
                            case "R":
                                //come back
                                break;

                        }
                        break;
                    case "C":
                        Console.WriteLine("A: Deposit B: Withdrawal C: Close + Report D: Report Balance in USD R: Return to Bank Menu");
                        String c = Console.ReadLine();
                        switch (c.ToUpper())
                        {
                            case "A":
                                Console.WriteLine("How much would you like to deposit?");
                                string depositString = Console.ReadLine();
                                double deposit = Convert.ToDouble(depositString);
                                che.MakeDeposit(deposit);
                                break;
                            case "B":
                                Console.WriteLine("How much would you like to withdraw?");
                                string withdrawString = Console.ReadLine();
                                double withdraw = Convert.ToDouble(withdrawString);
                                glo.MakeDeposit(withdraw);
                                break;
                            case "C":
                                glo.CloseAndReport();
                                break;
                            case "D":
                                glo.USValue();
                                break;
                            case "R":
                                //Come back
                                break;

                        }
                        break;
                    case "Q":
                        //exit
                        break;
                } 
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }
        }
    }
}
