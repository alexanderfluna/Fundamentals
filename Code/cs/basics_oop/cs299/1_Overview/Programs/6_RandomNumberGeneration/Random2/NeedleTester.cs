using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    ///  This program simulates the Buffon needle experiment 
    ///  and prints the resulting approximations of pi.*/
    public class NeedleTester
    {
        public static void Main()
       {
          Needle n = new Needle();
          const int TRIES1 = 10000;
          const int TRIES2 = 1000000;

          for (int i = 1; i <= TRIES1; i++)
             n.Drop();
          Console.Write("Tries = {0}, Tries / Hits = {1:f5}\n",
                TRIES1, (double) n.GetTries() / n.GetHits());

          for (int i = TRIES1 + 1; i <= TRIES2; i++)
             n.Drop();
         Console.Write("Tries = {0}, Tries / Hits = {1:f5}\n",
                TRIES2, (double) n.GetTries() / n.GetHits());
       }
    }
}
