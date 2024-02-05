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
                int* ptr1, ptr2;
                ptr1 = &var1;
                ptr2 = ptr1;
                *ptr2 = 20;

            }
            Console.WriteLine(var1);

        }
    }
}
