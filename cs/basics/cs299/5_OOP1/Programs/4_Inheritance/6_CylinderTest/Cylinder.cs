// Fig. 9.15: Cylinder.cs
// Cylinder class inherits from class Circle4.

using System;

namespace CylinderTest
{
   // Cylinder class definition inherits from Circle4
   public class Cylinder : Circle4
   {
      private double height;

      // default constructor
      public Cylinder()
      {
         // implicit call to Circle4 constructor occurs here
      }

      // four-argument constructor
      public Cylinder( int xValue, int yValue, double radiusValue, 
         double heightValue ) : base( xValue, yValue, radiusValue )
      {
         Height = heightValue; // set Cylinder height
      }

      // property Height
      public double Height
      {
         get
         {
            return height;
         }

         set
         {
            if ( value >= 0 ) // validate height
               height = value;
         }

      } // end property Height

      // override Circle4 method Area to calculate Cylinder area
      public override double Area()
      {
         return 2 * base.Area() + base.Circumference() * Height;
      }

      // calculate Cylinder volume
      public double Volume()
      {
         return base.Area() * Height;
      }

      // convert Cylinder to string
      public override string ToString()
      {
         return base.ToString() + "; Height = " + Height;
      }

   } // end class Cylinder
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