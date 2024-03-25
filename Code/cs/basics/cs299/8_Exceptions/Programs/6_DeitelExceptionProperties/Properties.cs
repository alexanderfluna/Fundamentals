// Fig 11.3: Properties.cs
// Stack unwinding and Exception class properties.

using System;

// demonstrates using the Message, StackTrace and 
// InnerException properties
class Properties
{
   static void Main( string[] args )
   {
      // call Method1, any Exception it generates will be 
      // caught in the catch block that follows
      try 
      {
         Method1();
      }

         // Output string representation of Exception, then
         // output values of InnerException, Message,
         // and StackTrace properties
      catch ( Exception exception ) 
      {
         Console.WriteLine( 
            "exception.ToString(): \n{0}\n",
            exception.ToString() ); 

         Console.WriteLine( "exception.Message: \n{0}\n",
            exception.Message );

         Console.WriteLine( "exception.StackTrace: \n{0}\n",
            exception.StackTrace );

         Console.WriteLine( 
            "exception.InnerException: \n{0}",
            exception.InnerException );

      } // end catch

   } // end Main

   // calls Method2
   public static void Method1()
   {
      Method2();
   }

   // calls Method3
   public static void Method2()
   {
      Method3();
   }

   // throws an Exception containing an InnerException
   public static void Method3()
   {
      // attempt to convert non-integer string to int
      try 
      {
         Convert.ToInt32( "Not an integer" );
      }

         // catch FormatException and wrap it in new Exception
      catch ( FormatException error ) 
      {
         throw new Exception( 
            "Exception occurred in Method3", error );
      }

   } // end method Method3

} // end class UsingExceptions


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
