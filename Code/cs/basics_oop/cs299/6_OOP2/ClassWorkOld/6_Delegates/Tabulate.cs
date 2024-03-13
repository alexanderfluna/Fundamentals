// SimpleDlegateDemo.cs - The first program using delegates

using System;

namespace ConsoleApplication1
{
	// 1. Define delegate
	public delegate double CalcFunction(double num);

	class QuickDelegateDemo
	{
        // Will use functions Math.Log(), Math.Sin(), Mat.Abs()
		// 2. Define handler methods
		/*public static double FeetToInches(double feet)
		{
			return feet * 12;
		}
        public static double InchesToFeet(double inches)
        {
            return inches / 12;
        }
         * */
        // a method that uses a delegate as an argument
        public static void PrintTable (CalcFunction calc, string name, double start, double end, double step){
            Console.WriteLine("   Function " + name+ "()");
            Console.WriteLine("x\t" + name + "(x)");
            for (double x = start; x <= end; x+=step){
                double result = calc(x);
                Console.WriteLine("{0}\t{1}", x, result);
            }
        }         

		static void Main()
		{
			// Create delegate instances
            CalcFunction LogFunction = new CalcFunction(Math.Log);
            CalcFunction SinFunction = new CalcFunction(Math.Sin);
            CalcFunction AbsFunction = new CalcFunction(Math.Abs);

            //Call the PrintTable function
            PrintTable(LogFunction, "Log", 0.1, 0.5, 0.1);
            Console.WriteLine("\n\n");

            PrintTable(SinFunction, "Sin", 0.1, 0.5, 0.1);
            Console.WriteLine("\n\n");

            PrintTable(AbsFunction, "Abs", -0.5, .5, 0.2);
            Console.WriteLine("\n\n");

            
		}
	}
}
