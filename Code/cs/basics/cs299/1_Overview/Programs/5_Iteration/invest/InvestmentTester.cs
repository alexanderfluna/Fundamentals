using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
   /// <summary>
   /// This program computes how long it takes for an investment
   /// to double.
   /// </summary>
    public class InvestmentTester    {
        public static void Main()       {
          const double INITIAL_BALANCE = 10000;
          const double RATE = 5;
          Investment invest = new Investment(INITIAL_BALANCE, RATE);
          invest.WaitForBalance(2 * INITIAL_BALANCE);
          int years = invest.GetYears();
          Console.WriteLine("The investment doubled after "
                + years + " years");
       }
    }

}
