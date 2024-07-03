// Fig. 9.19: ConstructorAndDestructor.cs
// Display order in which base-class and derived-class constructors
// and destructors are called.

using System;

namespace ConstructorsAndDestructor
{
   // ConstructorAndDestructor class definition
   class ConstructorAndDestructor
   {
      // main entry point for application.
      static void Main( string[] args )
      {
         Circle5 circle1, circle2;

         // instantiate objects
         circle1 = new Circle5( 72, 29, 4.5 );
         circle2 = new Circle5( 5, 5, 10 );

         Console.WriteLine();

         // mark objects for garbage collection
         circle1 = null;
         circle2 = null;

         // inform garbage collector to execute
         System.GC.Collect();
		
      } // end method Main

   } // end class ConstructorAndDestructor
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