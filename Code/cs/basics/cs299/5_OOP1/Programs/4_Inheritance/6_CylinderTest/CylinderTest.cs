// Fig. 9.16: CylinderTest.cs
// Tests class Cylinder.

using System;
using System.Windows.Forms;

namespace CylinderTest
{
   // CylinderTest class definition
   class CylinderTest
   {
      // main entry point for application
      static void Main( string[] args )
      {
         // instantiate object of class Cylinder
         Cylinder cylinder = new Cylinder(12, 23, 2.5, 5.7);

         // properties get initial x-y coordinate, radius and height
         string output = "X coordinate is " + cylinder.X + "\n" +
            "Y coordinate is " + cylinder.Y + "\nRadius is " +
            cylinder.Radius + "\n" + "Height is " + cylinder.Height;
   
         // properties set new x-y coordinate, radius and height
         cylinder.X = 2;
         cylinder.Y = 2;
         cylinder.Height = 10;
         cylinder.Radius = 4.25;

         // get new x-y coordinate and radius
         output += "\n\nThe new location, radius and height of " +
            "cylinder are\nCenter = [" + cylinder + "\n\n";
      
         // display Cylinder's Diameter
         output += "Diameter is " +
            String.Format( "{0:F}", cylinder.Diameter() ) + "\n";

         // display Cylinder's Circumference
         output += "Circumference is " +
            String.Format( "{0:F}", cylinder.Circumference() ) + "\n";
      
         // display Cylinder's Area
         output += "Area is " +
            String.Format( "{0:F}", cylinder.Area() ) + "\n";

         // display Cylinder's Volume
         output += "Volume is " +
            String.Format( "{0:F}", cylinder.Volume() );

         MessageBox.Show( output, "Demonstrating Class Cylinder" );

      } // end method Main

   } // end class CylinderTest
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