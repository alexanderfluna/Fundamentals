// Fig. 9.11: CircleTest3.cs
// Testing class Circle3.

using System;
using System.Windows.Forms;

namespace CircleTest3
{
   // CircleTest3 class definition
   class CircleTest3
   {
      // main entry point for application
      static void Main( string[] args )
      {
         // instantiate Circle3
         Circle3 circle = new Circle3( 37, 43, 2.5 );

         // get Circle3's initial x-y coordinates and radius
         string output = "X coordinate is " + circle.X + "\n" +
            "Y coordinate is " + circle.Y + "\nRadius is " +
            circle.Radius;

         // set Circle3's x-y coordinates and 
         // radius to new values
         circle.X = 2;
         circle.Y = 2;
         circle.Radius = 4.25;

         // display Circle3's string representation
         output += "\n\n" +
            "The new location and radius of circle are " +
            "\n" + circle + "\n";

         // display Circle3's Diameter
         output += "Diameter is " +
            String.Format( "{0:F}", circle.Diameter() ) + "\n";

         // display Circle3's Circumference
         output += "Circumference is " +
            String.Format( "{0:F}", circle.Circumference() ) +
            "\n";

         // display Circle3's Area
         output += "Area is " + 
            String.Format( "{0:F}", circle.Area() );

         MessageBox.Show( output, "Demonstrating Class Circle3" );

      } // end method Main

   } // end class CircleTest3
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