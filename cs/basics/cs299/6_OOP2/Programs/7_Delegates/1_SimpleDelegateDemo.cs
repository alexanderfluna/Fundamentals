using System;

namespace VS_CS
{
    public delegate double UnitConversion(double from);

    class DelegateDemo
    {
        
        public static double FeetToInches(double feet)
        {
            return feet * 12;
        }

        public static double InchesToFeet(double inches)
        {
            return inches / 12;
        }

        public static void PrintConversion(double num, UnitConversion conv)
        {
            double result = conv(num);
            Console.WriteLine("Num is: " + num);
        }

        static void Main(string[] args)
        {
            // Create a UnitConversion that uses the FeetToInches method
            UnitConversion DoConversion = new UnitConversion(FeetToInches);

            // Ask user for feet and store in feet var
            Console.Write("Please enter feet: ");
            double feet = Double.Parse(Console.ReadLine());

            // Convert from feet to inches using delegate
            double inches = DoConversion(feet);
            Console.WriteLine("{0} Feet = {1} Inches.", feet, inches);

            // Change UnitConversion to use InchesToFeet method
            DoConversion = new UnitConversion(InchesToFeet);
            Console.Write("Please enter inches: ");
            inches = Double.Parse(Console.ReadLine());

            // Convert from inches to feet using delegate
            feet = DoConversion(inches);
            Console.WriteLine("{0} Feet = {1} Inches.", feet, inches);

            // PrintConversion to print inches to feet
            PrintConversion(inches, DoConversion);

            // PrintConversion to print feet to inches
            DoConversion = new UnitConversion(FeetToInches);
            PrintConversion(feet, DoConversion);
        }

    }
}
