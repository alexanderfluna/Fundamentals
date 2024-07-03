using System;

namespace Fractions {

    public class FractionTester {

        static void Main() {
            Fraction f1 = new Fraction(-1, 2);
            Fraction f2 = new Fraction(1, 2);
            Fraction f3 = new Fraction(5, 10);
            if (f2 == f3) {
                System.Console.WriteLine(f2.ToString() + " == " +
                                         f2.ToString());
            }
			if (f2.Equals(f3)) 
			{
				System.Console.WriteLine(f2.ToString() + " Equals " +
					f2.ToString());
			}
            Fraction f4 = f1 * f2;
            System.Console.WriteLine(f1.ToString() + " * " +
                        f2.ToString() + " = " + f4.ToString());
            Fraction f5 = f2 - f1;
            System.Console.WriteLine(f2.ToString() + " - " +
                     f1.ToString() + " = " + f5.ToString());
            Fraction f6 = f1 / f2;
            System.Console.WriteLine(f1.ToString() + " / " +
                     f2.ToString() + " = " + f6.ToString());            
            
        }
    }
}
