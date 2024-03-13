// Tabulating.cs - Using delegates to tabulate simple functions. 

using System;

namespace ConsoleApplication1
{
	public class Application 
	{

		

		public static void Main()
		{
			// calculate log(x) for x from 0.1 to 5 step 0.1 
			// In the output, show “log” as a function name
			PrintTableOfFunction(new NumericFunction(Math.Log), "log", 0.1, 5, 0.1);
			// calculate sin(x) for x from 0.0 to 2*Pi step 0.1 
			// In the output, show “sin” as a function name
			PrintTableOfFunction(new NumericFunction(Math.Sin), "sin", 0.0, 2 * Math.PI, 0.1);
			// calculate abs(x) for x from -1 to 1 step 0.1 
			// In the output, show “abs” as a function name
			PrintTableOfFunction(new NumericFunction(Math.Abs), "abs", -1.0, 1.0, 0.1);
			// calculate Cubic(x) for x from 1 to 5 step 0.5 
			// In the output, show “cubic” as a function name
			// Cubic(x) is your own function - you must define it
			PrintTableOfFunction(new NumericFunction(Cubic), "cubic", 1.0, 5.0, 0.5);

		}
	}
}
