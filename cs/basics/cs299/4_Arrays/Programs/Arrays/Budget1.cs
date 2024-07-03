using System;

namespace ConsoleApplication1
{

	/// <summary>
	/// display spending categories
	/// uses one-dimensional array
	/// uses Math.Round() and output formatting
	/// </summary>
	
	class Budget1
    {

        

        static double R3(double x)
        {
            //this method rounds a double value to three decimal places
            double z = ((double)(Math.Round(x * 1000))) / 1000;
            return z;
        }


        public static void Main()
        {

            double[] spend = new double[6] { 0, 12, 15, 80, 40, 30 };
            double total = 0;

            for (int category = 1; category <= 5; category++)
            {
                total += spend[category];
            }
            for (int category = 1; category <= 5; category++)
            {
                double share = spend[category] / total;
                // using our own method to format
                //Console.WriteLine("Category: {0} Spending: {1} Share: {2}"
                //                  ,category, spend[category], R3(share));
                
                // using C# Format strings
                Console.WriteLine("Category: {0} Spending: {1:c} Share: {2:F3}"
                                  , category, spend[category], share);
            }
        }
    }
}
