// Fig. 9.7: CircleTest.cs
// Testing class Circle.

using System;
using System.Windows.Forms;

namespace CircleTest
{
   // CircleTest class definition
   class CircleTest
   {
      // main entry point for application.
      static void Main( string[] args )
      {
         // instantiate Circle
         Circle circle = new Circle( 37, 43, 2.5 );

         // get Circle's initial x-y coordinates and radius
         string output = "X coordinate is " + circle.X + 
            "\nY coordinate is " + circle.Y + "\nRadius is " +
            circle.Radius;

         // set Circle's x-y coordinates and radius to new values
         circle.X = 2;
         circle.Y = 2;
         circle.Radius = 4.25;

         // display Circle's string representation
         output += "\n\nThe new location and radius of " +
            "circle are \n" + circle + "\n";

         // display Circle's diameter
         output += "Diameter is " +
            String.Format( "{0:F}", circle.Diameter() ) + "\n";

         // display Circle's circumference
         output += "Circumference is " +
            String.Format( "{0:F}", circle.Circumference() ) + "\n";

         // display Circle's area
         output += "Area is " +
            String.Format( "{0:F}", circle.Area() );

         MessageBox.Show( output, "Demonstrating Class Circle" );

      } // end method Main

   } // end class CircleTest
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