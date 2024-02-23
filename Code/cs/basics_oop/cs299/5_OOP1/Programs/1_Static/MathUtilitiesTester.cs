using System;

namespace StaticMethods {

    public class MathUtilitiesTester {

        public static void Main() {
            Console.WriteLine("The square root of 2.0: " +
                              MathUtilities.SquareRoot(2.0m, 0.00000000000000000000000001m));
            Console.WriteLine("The value of pi: " +
                              MathUtilities.ApproximatePI(1000000000));
            Console.ReadLine();
        }
    }
}
/* Output
The square root of 2.0: 1.4142135623730950488016887242
                        1.4142135623730950488016887242 (from http://www.rossi.com/sqr2.htm)
The value of pi: 3.141647356
                 3.1415926535 (http://lcf.www9.50megs.com/pi.html)
*/ 


