// Fig 11.2: UsingExceptions.cs
// Using finally blocks.

using System;

namespace UsingExceptions
{
   // demonstrating that finally always executes
   class UsingExceptions
   {
      // entry point for application
      static void Main( string[] args )
      {
         // Case 1: No exceptions occur in called method.
         Console.WriteLine( "Calling DoesNotThrowException" );
         DoesNotThrowException();

         // Case 2: Exception occurs and is caught 
         // in called method.
         Console.WriteLine( "\nCalling ThrowExceptionWithCatch" );
         ThrowExceptionWithCatch();

         // Case 3: Exception occurs, but not caught
         // in called method, because no catch blocks.
         Console.WriteLine( 
            "\nCalling ThrowExceptionWithoutCatch" );

         // call ThrowExceptionWithoutCatch
         try 
         {
            ThrowExceptionWithoutCatch();
         }

            // process exception returned from 
            // ThrowExceptionWithoutCatch
         catch 
         {
            Console.WriteLine( "Caught exception from " + 
               "ThrowExceptionWithoutCatch in Main" );
         }

         // Case 4: Exception occurs and is caught
         // in called method, then rethrown to caller.
         Console.WriteLine( 
            "\nCalling ThrowExceptionCatchRethrow" );

         // call ThrowExceptionCatchRethrow
         try 
         {
            ThrowExceptionCatchRethrow();
         }

            // process exception returned from 
            // ThrowExceptionCatchRethrow
         catch
         {
            Console.WriteLine( "Caught exception from " + 
               "ThrowExceptionCatchRethrow in Main" );
         }

      } // end method Main

      // no exceptions thrown
      public static void DoesNotThrowException()
      {
         // try block does not throw any exceptions 
         try 
         {
            Console.WriteLine( "In DoesNotThrowException" );
         }

            // this catch never executes
         catch
         {
            Console.WriteLine( "This catch never executes" );
         }

            // finally executes because corresponding try executed
         finally
         {
            Console.WriteLine( 
               "Finally executed in DoesNotThrowException" );
         }

         Console.WriteLine( "End of DoesNotThrowException" );

      } // end method DoesNotThrowException

      // throws exception and catches it locally
      public static void ThrowExceptionWithCatch()
      {
         // try block throws exception
         try 
         {
            Console.WriteLine( "In ThrowExceptionWithCatch" );
            
            throw new Exception( 
               "Exception in ThrowExceptionWithCatch" );
         }

            // catch exception thrown in try block
         catch ( Exception error )
         {
            Console.WriteLine( "Message: " + error.Message );
         }

            // finally executes because corresponding try executed
         finally
         {
            Console.WriteLine( 
               "Finally executed in ThrowExceptionWithCatch" );
         }

         Console.WriteLine( "End of ThrowExceptionWithCatch" );

      } // end method ThrowExceptionWithCatch

      // throws exception and does not catch it locally
      public static void ThrowExceptionWithoutCatch()
      {
         // throw exception, but do not catch it
         try 
         {
            Console.WriteLine( "In ThrowExceptionWithoutCatch" );

            throw new Exception( 
               "Exception in ThrowExceptionWithoutCatch" );
         }

            // finally executes because corresponding try executed
         finally
         {
            Console.WriteLine( "Finally executed in " +
               "ThrowExceptionWithoutCatch" );
         }

         // unreachable code; would generate logic error 
         Console.WriteLine( "This will never be printed" );

      } // end method ThrowExceptionWithoutCatch

      // throws exception, catches it and rethrows it
      public static void ThrowExceptionCatchRethrow()
      {
         // try block throws exception
         try 
         { 
            Console.WriteLine( "In ThrowExceptionCatchRethrow" );

            throw new Exception( 
               "Exception in ThrowExceptionCatchRethrow" );
         }

            // catch any exception, place in object error
         catch ( Exception error )
         {
            Console.WriteLine( "Message: " + error.Message );

            // rethrow exception for further processing
            throw error;  

            // unreachable code; would generate logic error
         }

            // finally executes because corresponding try executed
         finally 
         {
            Console.WriteLine( "Finally executed in " +
               "ThrowExceptionCatchRethrow" );
         }

         // unreachable code; would generate logic error 
         Console.WriteLine( "This will never be printed" );

      } // end method ThrowExceptionCatchRethrow

   } // end class UsingExceptions
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
