// Fig. 10.4: Shape.cs
// Demonstrate a shape hierarchy using an abstract base class.
using System;

namespace AbstractShapes
{
   public abstract class Shape
   {
      // return Shape's area
      public virtual double Area()
      {
         return 0;
      }

      // return Shape's volume
      public virtual double Volume()
      {
         return 0;
      }

      // return Shape's name
      public abstract string Name
      {
         get;
      }
   }
}
