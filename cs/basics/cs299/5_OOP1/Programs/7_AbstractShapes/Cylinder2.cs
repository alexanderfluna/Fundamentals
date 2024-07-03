// Fig. 10.7: Cylinder2.cs
// Cylinder2 inherits from class Circle2 and overrides key members.
using System;

namespace AbstractShapes
{
   // Cylinder2 inherits from class Circle2
   public class Cylinder2 : Circle2
   {
      private double height; // Cylinder2 height

      // default constructor
      public Cylinder2()
      {
         // implicit call to Circle2 constructor occurs here
      }

      // constructor
      public Cylinder2( int xValue, int yValue, double radiusValue,
         double heightValue ) : base( xValue, yValue, radiusValue )
      {
         Height = heightValue;
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
            // ensure non-negative height value
            if ( value >= 0 )
               height = value;
         }
      }

      // calculate Cylinder2 area
      public override double Area()
      {
         return 2 * base.Area() + base.Circumference() * Height;
      }

      // calculate Cylinder2 volume
      public override double Volume()
      {
         return base.Area() * Height;
      }

      // return string representation of Cylinder2 object
      public override string ToString()
      {
         return base.ToString() + "; Height = " + Height;
      }

      // override property Name from class Circle2
      public override string Name
      {
         get
         {
            return "Cylinder2";
         }
      }

   } // end class Cylinder2
}
