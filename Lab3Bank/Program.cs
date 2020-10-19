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
                SavingsAccount sav = new SavingsAccount(5,0.12);
                ChequingAccount che = new ChequingAccount(5,0.12);
                GlobalSavingsAccount glo = new GlobalSavingsAccount(5,0.12);
            while (1 == 1) {
            try 
            {
               
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
                                sav.MakeWithdrawl(withdraw);
                                break;
                            case "C":
                                   
                                    Console.Write(sav.CloseAndReport());
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
                                che.MakeWithdrawl(withdraw);
                                break;
                            case "C":
                                    Console.Write(che.CloseAndReport());
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
                                glo.MakeWithdrawl(withdraw);
                                break;
                            case "C":
                                Console.WriteLine(glo.CloseAndReport());
                                break;
                            case "D":
                                Console.WriteLine(glo.USValue(0.76));
                                   
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
