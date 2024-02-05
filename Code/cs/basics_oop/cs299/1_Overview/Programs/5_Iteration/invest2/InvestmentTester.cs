using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class InvestmentTester
    {
        public static void Main()  {
	      const double INITIAL_BALANCE = 10000;
	      const double RATE = 5;
	      const int YEARS = 20;
	      Investment invest = new Investment(INITIAL_BALANCE, RATE);
	      invest.WaitYears(YEARS);
	      double balance = invest.GetBalance();
	      Console.WriteLine("The balance after {0} years is {1:c}\n", 
		    YEARS, balance);
	}
    }

}
