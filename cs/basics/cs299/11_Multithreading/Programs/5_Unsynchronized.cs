// Fig. 14.4: Unsynchronized.cs
// Showing multiple threads modifying a shared object without
// synchronization.

using System;
using System.Threading;

namespace Unsynchronized
{
   // this class represents a single shared int
   public class HoldIntegerUnsynchronized
   {
      // buffer shared by producer and consumer threads
      private int buffer = -1; 
   
      // property Buffer
      public int Buffer
      {      
         get
         {
            Console.WriteLine( Thread.CurrentThread.Name + 
               " reads " + buffer );

            return buffer;
         }

         set
         {
            Console.WriteLine( Thread.CurrentThread.Name + 
               " writes " + value );

            buffer = value;
         }

      } // end property Buffer

   } // end class HoldIntegerUnsynchronized

   // class Producer's Produce method controls a thread that
   // stores values from 1 to 4 in sharedLocation
   class Producer 
   {
      private HoldIntegerUnsynchronized sharedLocation;
      private Random randomSleepTime;

      // constructor
      public Producer( 
         HoldIntegerUnsynchronized shared, Random random )
      {
         sharedLocation = shared;
         randomSleepTime = random;
      }

      // store values 1-4 in object sharedLocation
      public void Produce()
      {
         // sleep for random interval upto 3000 milliseconds
         // then set sharedLocation's Buffer property
         for ( int count = 1; count <= 4; count++ ) 
         {
            Thread.Sleep( randomSleepTime.Next( 1, 3000 ) );
            sharedLocation.Buffer = count; 
         }

         Console.WriteLine( Thread.CurrentThread.Name + 
            " done producing.\nTerminating " + 
            Thread.CurrentThread.Name + "." );

      } // end method Produce

   } // end class Producer

   // class Consumer's Consume method controls a thread that
   // loops four times and reads a value from sharedLocation
   class Consumer
   {
      private HoldIntegerUnsynchronized sharedLocation;
      private Random randomSleepTime;

      // constructor
      public Consumer( 
         HoldIntegerUnsynchronized shared, Random random )
      {
         sharedLocation = shared;
         randomSleepTime = random;
      }

      // read sharedLocation's value four times
      public void Consume()
      {
         int sum = 0;

         // sleep for random interval upto 3000 milliseconds
         // then add sharedLocation's Buffer property value
         // to sum
         for ( int count = 1; count <= 4; count++ )
         {
            Thread.Sleep( randomSleepTime.Next( 1, 3000 ) );
            sum += sharedLocation.Buffer;
         }
      
         Console.WriteLine( Thread.CurrentThread.Name + 
            " read values totaling: " + sum + 
            ".\nTerminating " + Thread.CurrentThread.Name + "." );

      } // end method Consume

   } // end class Consumer

   // this class creates producer and consumer threads
   class SharedCell
   {
      // create producer and consumer threads and start them
      static void Main( string[] args )
      {
         // create shared object used by threads
         HoldIntegerUnsynchronized holdInteger = 
            new HoldIntegerUnsynchronized();

         // Random object used by each thread
         Random random = new Random();

         // create Producer and Consumer objects
         Producer producer = 
            new Producer( holdInteger, random );

         Consumer consumer = 
            new Consumer( holdInteger, random );

         // create threads for producer and consumer and set 
         // delegates for each thread
         Thread producerThread = 
            new Thread( new ThreadStart( producer.Produce ) );
         producerThread.Name = "Producer";

         Thread consumerThread = 
            new Thread( new ThreadStart( consumer.Consume ) );
         consumerThread.Name = "Consumer";

         // start each thread
         producerThread.Start();
         consumerThread.Start();

      } // end method Main

   } // end class SharedCell
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