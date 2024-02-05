using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
   /// <summary>
   /// This program simulates casting a die ten times.
   /// </summary>
    public class DieTester    {

        public static void Main(){

              Die d = new Die(6);
              const int TRIES = 10;
              for (int i = 1; i <= TRIES; i++)
              {  
                 int n = d.Cast();
                 Console.Write(n + " ");
              }
              Console.WriteLine();
        }
    }

}
