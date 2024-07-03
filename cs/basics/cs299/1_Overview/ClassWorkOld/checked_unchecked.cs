
using System;
using System.Collections;

namespace CheckedUnchecked {

    public class CheckedUncheckedExample {

        static void Main() {
            short z=0;
            short a = 32767;
            short b = 32767;

            try
            {
                z = checked((short)(a + b));
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("z is " + z);
            z = unchecked((short)(a + b));
            Console.WriteLine("unchecked z is " + z);

            for (int i = 0; i < 3; i++)
            {
                Console.Write(" " + i);
                //for (int i = 0; 0 < 2) // cannot declare i

            }
        }
    }
}
