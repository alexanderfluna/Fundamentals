// Fig. 9.18: Circle5.cs
// Circle5 class that inherits from class Point4.

using System;

namespace ConstructorsAndDestructor
{
   // Circle5 class definition inherits from Point4
   public class Circle5 : Point4
   {
      private double radius;

      // default constructor
      public Circle5()
      {
         // implicit call to Point3 constructor occurs here
         Console.WriteLine( "Circle5 constructor: {0}", this );
      }

      // constructor
      public Circle5( int xValue, int yValue, double radiusValue )
         : base( xValue, yValue )
      {
         Radius = radiusValue;
         Console.WriteLine( "Circle5 constructor: {0}", this );
      }

      // destructor overrides version in class Point4
      ~Circle5()
      {
         Console.WriteLine( "Circle5 destructor: {0}", this );
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
            if ( value >= 0 )
               radius = value;
         }

      } // end property Radius

      // calculate Circle5 diameter
      public double Diameter()
      {
         return radius * 2;
      }

      // calculate Circle5 circumference
      public double Circumference()
      {
         return Math.PI * Diameter();
      }

      // calculate Circle5 area
      public virtual double Area()
      {
         return Math.PI * Math.Pow( radius, 2 );
      }

      // return string representation of Circle5
      public override string ToString()
      {
         // use base reference to return Point3 string
         return "Center = " + base.ToString() +
            "; Radius = " + radius;
      }

   } // end class Circle5
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