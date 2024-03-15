// Fig. 8.10: CompositionTest.cs
// Demonstrate an object with member object reference.

using System;
using System.Windows.Forms;

namespace CompositionTest
{
   // Composition class definition
   class CompositionTest
   {
      // main entry point for application
      static void Main( string[] args )
      {
         Employee e = 
            new Employee( "Bob", "Jones", 7, 24, 1949, 3, 12, 1988 );

         MessageBox.Show( e.ToEmployeeString(), 
            "Testing Class Employee" );
      
      } // end method Main

   } // end class CompositionTest
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
