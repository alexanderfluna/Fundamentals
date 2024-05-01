// Alexander Luna | Test 2 | Problem3_Client.cs
// Tabulating.cs - Using delegates to tabulate simple functions. 
using System;

namespace ConsoleApplication1
{
	public class Application 
	{
		public delegate double NumericFunction(double value);

		public static void PrintTableOfFunction(NumericFunction numericFunction, string functionName, double start, double end, double increment)
        {
			double value = start;
			while (value <= end)
            {
				double result = numericFunction(value);
				Console.WriteLine($"{functionName}({value:0.00}) = {result:0.0000}");
				value += increment;
			}
		}

		public static double Cubic(double value)
        {
			return Math.Pow(value, 3);
        }

		public static void Main()
		{
			// calculate log(x) for x from 0.1 to 5 step 0.1 
			// In the output, show "log" as a function name
			Console.WriteLine("PrintTableOfFunction(new NumericFunction(Math.Log), 'log', 0.1, 5, 0.1);\n");
			PrintTableOfFunction(new NumericFunction(Math.Log), "log", 0.1, 5, 0.1);
			Console.WriteLine("===========================================================================\n");

			// calculate sin(x) for x from 0.0 to 2*Pi step 0.1 
			// In the output, show "sin" as a function name
			Console.WriteLine("PrintTableOfFunction(new NumericFunction(Math.Sin), 'sin', 0.0, 2 * Math.PI, 0.1);\n");
			PrintTableOfFunction(new NumericFunction(Math.Sin), "sin", 0.0, 2 * Math.PI, 0.1);
			Console.WriteLine("===========================================================================\n");

			// calculate abs(x) for x from -1 to 1 step 0.1 
			// In the output, show "abs" as a function name
			Console.WriteLine("PrintTableOfFunction(new NumericFunction(Math.Abs), 'abs', -1.0, 1.0, 0.1);\n");
			PrintTableOfFunction(new NumericFunction(Math.Abs), "abs", -1.0, 1.0, 0.1);
			Console.WriteLine("===========================================================================\n");

			// calculate Cubic(x) for x from 1 to 5 step 0.5 
			// In the output, show "cubic" as a function name
			// Cubic(x) is your own function - you must define it
			Console.WriteLine("PrintTableOfFunction(new NumericFunction(Cubic), 'cubic', 1.0, 5.0, 0.5);\n");
			PrintTableOfFunction(new NumericFunction(Cubic), "cubic", 1.0, 5.0, 0.5);
			Console.WriteLine("===========================================================================\n");
		}
	}
}
