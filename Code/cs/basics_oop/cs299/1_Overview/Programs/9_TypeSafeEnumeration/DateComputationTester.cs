using System;

namespace TypeSafeEnumeration {

    public class DateComputationTester {

        public static void Main() {
            DateComputation date = new DateComputation(); // Application object
            System.Console.WriteLine("The third day of the week = " +
                                     date[3]);
            System.Console.
                WriteLine("The day of the year for 3/1/2000 is: " +
                              date[Month.March, 1, 2000]);
            System.Console.
                WriteLine("The day of the year for 3/1/2003 is: " +
                              date[Month.March, 1, 2003]);
            System.Console.
            WriteLine("The day of the year for 12/31/2000 is: " +
                              date[Month.December, 31, 2000]);
            System.Console.
            WriteLine("The day of the year for 12/31/2004 is: " +
                              date[Month.December, 31, 2004]);
            System.Console.
            WriteLine("The day of the year for 12/31/2005 is: " +
                              date[Month.December, 31, 2005]);
            System.Console.ReadLine();
            /* Compiler errors emitted since enum constants are type safe
            if (DateComputation.Month.March == 3) {
                Console.WriteLine("Found third month of year.");
            }
            int result = DateComputation.Month.March + DateComputation.Month.April;
            */
        }
    }
}
/* Output
The third day of the week = Tuesday
The day of the year for 3/1/2000 is: 61
The day of the year for 3/1/2003 is: 60
The day of the year for 12/31/2000 is: 366
The day of the year for 12/31/2004 is: 366
The day of the year for 12/31/2005 is: 365
*/
