using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
  
   /// This program tests the Triangle class.
    public class TriangleTester
    {
        public static void Main()
   {
      Triangle small = new Triangle(3);
      Console.WriteLine(small.ToString());

      Triangle large = new Triangle(15);
      Console.WriteLine(large.ToString());
   }
    }
}
