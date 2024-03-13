// SimpleDlegateDemo.cs - The first program using delegates

using System;

namespace ConsoleApplication1
{
	// 1. Define delegate
	public delegate double UnitConversion(double from);

	class QuickDelegateDemo
	{
		// 2. Define handler methods
		public static double FeetToInches(double feet)
		{
			return feet * 12;
		}
        public static double InchesToFeet(double inches)
        {
            return inches / 12;
        }
        // a method that uses a delegate as an argument
        public static void printConversion (double num, 
                                        UnitConversion conv){
            double result = conv(num);
            Console.WriteLine(num + " was converted to " 
                                 + result);
        }

		static void Main()
		{
			// Create delegate instance
			UnitConversion DoConversion = new UnitConversion(FeetToInches);

			Console.Write("Please enter feet:  ");
			double feet = Double.Parse(Console.ReadLine());

			// Use delegate just like a method.
			double inches = DoConversion(feet);
			Console.WriteLine("{0} Feet = {1} Inches.", feet, inches);
			
            // Create delegate instance
            DoConversion = new UnitConversion(InchesToFeet);
            Console.Write("Please enter inches:  ");
            inches = Double.Parse(Console.ReadLine());

            // Use delegate just like a method.
            feet = DoConversion(inches);
            Console.WriteLine("{0} Feet = {1} Inches.", feet, inches);
                   
            printConversion (inches, DoConversion);
            DoConversion = new UnitConversion(FeetToInches);
            printConversion(feet, DoConversion);

            
		}
	}
}
