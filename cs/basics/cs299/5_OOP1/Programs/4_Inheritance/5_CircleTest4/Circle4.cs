// Fig. 9.13: Circle4.cs
// Circle4 class that inherits from class Point3.

using System;

namespace CircleTest4
{
   // Circle4 class definition inherits from Point3
   public class Circle4 : Point3
   {
      private double radius;

      // default constructor
      public Circle4()
      {
         // implicit call to Point constructor occurs here
      }

      // constructor
     public Circle4( int xValue, int yValue, double radiusValue )
         : base( xValue, yValue )
      {
         Radius = radiusValue;
      }

      // property Radius
      public double Radius
      {
         get
         {
            return radius;
         }

         set
         {
            if ( value >= 0 )   // needs validation
               radius = value;
         }

      } // end property Radius

      // calculate Circle diameter
      public double Diameter()
      {
         return Radius * 2;     // uses property Radius
      }

      // calculate Circle circumference
      public double Circumference()
      {
         return Math.PI * Diameter();
      }

      // calculate Circle area
      public virtual double Area()
      {
         return Math.PI * Math.Pow( Radius, 2 );  // uses property
      }

      // return string representation of Circle4
      public override string ToString()
      {
         // use base reference to return Point string representation
         return "Center= " + base.ToString() +
            "; Radius = " + Radius;  // uses property Radius
      }

   } // end class Circle4
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