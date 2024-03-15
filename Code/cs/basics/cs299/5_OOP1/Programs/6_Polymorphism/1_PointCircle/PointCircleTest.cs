// Fig. 10.3: PointCircleTest.cs
// Demonstrating inheritance and polymorphism.

using System;
//using System.Windows.Forms;

namespace PointCircle
{
   // PointCircleTest class definition
   class PointCircleTest
   {
        // main entry point for application.
        static void Main(string[] args)
        {
            Point point1 = new Point(30, 50);
            Circle circle1 = new Circle(120, 89, 2.7);

            Console.WriteLine("Point point1: " + point1.ToString());
            Console.WriteLine("Circle circle1: " + circle1.ToString());

            // use 'is a' relationship to assign 
            // Circle circle1 to Point reference
            Point point2 = circle1;

            Console.WriteLine("Circle circle1 (via point2): " +
               point2.ToString());

            // downcast (cast base-class reference to derived-class
            // data type) point2 to Circle circle2
            Circle circle2 = (Circle)point2;

            Console.WriteLine("Circle circle1 (via circle2): " +
               circle2.ToString());

            Console.WriteLine("Area of circle1 (via circle2): " +
               circle2.Area().ToString("F"));

         // attempt to assign point1 object to Circle reference
         if ( point1 is Circle )
         {
            circle2 = ( Circle ) point1;
            Console.WriteLine("cast successful");
         }
         else
         {
            Console.WriteLine("point1 does not refer to a Circle");
         }           

      } // end method Main

   } // end class PointCircleTest
}

/*
 **************************************************************************
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/