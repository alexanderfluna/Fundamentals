// DynamicDelegates.cs -  multiple conversions through assignment

using System;

namespace ConsoleApplication1
{
	// 1. Define delegate.
	public delegate double UnitConversion(double from);

	class DynamicDelegates
	{
		//
		// 2. Define handler methods.
		//
		public double FeetToInches(double feet)
		{
			return feet * 12;
		}

		public double YardsToInches(double yards)
		{
			return yards * 36;
		}

		// Factory method for returning delegate
		public UnitConversion GetConversionMethod(string conversionType)
		{
			UnitConversion conversion;

			switch (conversionType)
			{
				case "1":
					conversion = new UnitConversion(FeetToInches);
					break;
				case "2":
					conversion = new UnitConversion(YardsToInches);
					break;
				default:
					throw new ArgumentException("Unrecognized conversion type: " + conversionType, conversionType);
			}

			return conversion;
		}

		// show menu and return units to convert and type of conversion
		public void GetUserInput(out double units, out string conversionType)
		{
			Console.WriteLine("Units Converter");
			Console.WriteLine("------------------------\n");
        
			Console.WriteLine("1 - Feet to Inches");
			Console.WriteLine("2 - Yards to Inches");

			Console.Write("\nPlease select conversion option (1 or 2):  ");
			conversionType = Console.ReadLine();

			Console.Write("\n\nHow many units:  ");

			units = Double.Parse(Console.ReadLine());
		}

		static void Main()
		{
			DynamicDelegates dels = new DynamicDelegates();
        
			double units;
			string conversionType;
            
			dels.GetUserInput(out units, out conversionType);

			// 3. get delegate instance via factory method.
			UnitConversion doConversion = dels.GetConversionMethod(conversionType);

			// 4. Use delegate just like a method.
			double inches = doConversion(units);

			Console.WriteLine("\n{0} Units = {1} Inches.\n", units, inches);
			Console.ReadLine();
		}
	}
}
