// Fig. 14.3: ThreadTester.cs
// Multiple threads printing at different intervals.

using System;
using System.Threading;

namespace threadTester
{
   // class ThreadTester demonstrates basic threading concepts
   class ThreadTester
   {
      static void Main( string[] args )
      {
         // Create and name each thread. Use MessagePrinter's
         // Print method as argument to ThreadStart delegate.
         MessagePrinter printer1 = new MessagePrinter();
         Thread thread1 = 
            new Thread ( new ThreadStart( printer1.Print ) );
         thread1.Name = "thread1";

         MessagePrinter printer2 = new MessagePrinter();
         Thread thread2 = 
            new Thread ( new ThreadStart( printer2.Print ) );
         thread2.Name = "thread2";

         MessagePrinter printer3 = new MessagePrinter();
         Thread thread3 = 
            new Thread ( new ThreadStart( printer3.Print  ) );
         thread3.Name = "thread3";

         Console.WriteLine( "Starting threads" );

         // call each thread's Start method to place each 
         // thread in Started state
         thread1.Start();
         thread2.Start();
         thread3.Start();

         Console.WriteLine( "Threads started\n" ); 

      } // end method Main

   } // end class ThreadTester

   // Print method of this class used to control threads
   class MessagePrinter 
   {
      private int sleepTime;
      private static Random random = new Random();
      
      // constructor to initialize a MessagePrinter object
      public MessagePrinter()
      {
         // pick random sleep time between 0 and 5 seconds
         sleepTime = random.Next( 5001 );
      }

      // method Print controls thread that prints messages
      public void Print() 
      {
         // obtain reference to currently executing thread
         Thread current = Thread.CurrentThread; 

         // put thread to sleep for sleepTime amount of time
         Console.WriteLine( 
            current.Name + " going to sleep for " + sleepTime );

         Thread.Sleep ( sleepTime );

         // print thread name
         Console.WriteLine( current.Name + " done sleeping" );

      } // end method Print

   } // end class MessagePrinter
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
