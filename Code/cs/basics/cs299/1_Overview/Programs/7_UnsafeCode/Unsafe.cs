using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace __CsharpConsoleProject
{
    class Unsafe
    {
        static void Main(string[] args)
        {
            int var1 = 5;
            unsafe
            {
                Console.WriteLine("var1 = " + var1);
                Console.WriteLine("&var1 = " + (int)&var1);
                
                int* ptr1, ptr2;

                ptr1 = &var1;
                Console.WriteLine("ptr1 = " + (int)ptr1);
                Console.WriteLine("*ptr1 = " + (int)*ptr1);

                ptr2 = ptr1;
                *ptr2 = 20;
                Console.WriteLine("ptr2 = " + (int)ptr2);
                Console.WriteLine("*ptr2 = " + (int)*ptr2);

            }
            Console.WriteLine(var1);

        }
    }
}
