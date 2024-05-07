// Fig. 14.5: Synchronized.cs
// Showing multiple threads modifying a shared object with
// synchronization.

using System;
using System.Threading;

namespace Synchronized
{
   // this class synchronizes access to an integer
   public class HoldIntegerSynchronized
   {
      // buffer shared by producer and consumer threads 
      private int buffer = -1;

      // occupiedBufferCount maintains count of occupied buffers
      private int occupiedBufferCount = 0;  

      // property Buffer
      public int Buffer
      {      
         get
         { 
            // obtain lock on this object
            Monitor.Enter( this );

            // if there is no data to read, place invoking 
            // thread in WaitSleepJoin state
            if ( occupiedBufferCount == 0 )
            {
               Console.WriteLine( 
                  Thread.CurrentThread.Name + " tries to read." );

               DisplayState( "Buffer empty. " + 
                  Thread.CurrentThread.Name + " waits." );

               Monitor.Wait( this );
            }

            // indicate that producer can store another value 
            // because a consumer just retrieved buffer value
            --occupiedBufferCount;    
                                 
            DisplayState( 
               Thread.CurrentThread.Name + " reads " + buffer );

            // tell waiting thread (if there is one) to 
            // become ready to execute (Started state)
            Monitor.Pulse( this );

            // Get copy of buffer before releasing lock. 
            // It is possible that the producer could be
            // assigned the processor immediately after the
            // monitor is released and before the return 
            // statement executes. In this case, the producer 
            // would assign a new value to buffer before the 
            // return statement returns the value to the 
            // consumer. Thus, the consumer would receive the 
            // new value. Making a copy of buffer and 
            // returning the copy ensures that the
            // consumer receives the proper value.
            int bufferCopy = buffer;

            // release lock on this object
            Monitor.Exit( this );

            return bufferCopy;

         } // end get

         set
         {
            // acquire lock for this object
            Monitor.Enter( this );

            // if there are no empty locations, place invoking
            // thread in WaitSleepJoin state
            if ( occupiedBufferCount == 1 )
            {
               Console.WriteLine( 
                  Thread.CurrentThread.Name + " tries to write." );

               DisplayState( "Buffer full. " + 
                  Thread.CurrentThread.Name + " waits." );

               Monitor.Wait( this );
            }

            // set new sharedInt value
            buffer = value;

            // indicate producer cannot store another value 
            // until consumer retrieves current sharedInt value
            ++occupiedBufferCount;

            DisplayState( 
               Thread.CurrentThread.Name + " writes " + buffer );

            // tell waiting thread (if there is one) to 
            // become ready to execute (Started state)
            Monitor.Pulse( this );

            // release lock on this object
            Monitor.Exit( this );

         } // end set

      } // end property Buffer

      // display current operation and buffer state
      public void DisplayState( string operation )
      {
         Console.WriteLine( "{0,-35}{1,-9}{2}\n", 
            operation, buffer, occupiedBufferCount );
      }

   } // end class HoldIntegerSynchronized
      
   // class Producer's Produce method controls a thread that
   // stores values from 1 to 4 in sharedLocation
   class Producer 
   {
      private HoldIntegerSynchronized sharedLocation;
      private Random randomSleepTime;

      // constructor
      public Producer( 
         HoldIntegerSynchronized shared, Random random )
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
            Thread.CurrentThread.Name + ".\n" );

      } // end method Produce

   } // end class Producer

   // class Consumer's Consume method controls a thread that
   // loops four times and reads a value from sharedLocation
   class Consumer
   {
      private HoldIntegerSynchronized sharedLocation;
      private Random randomSleepTime;

      // constructor
      public Consumer( 
         HoldIntegerSynchronized shared, Random random )
      {
         sharedLocation = shared;
         randomSleepTime = random;
      }

      // read sharedLocation's value four times
      public void Consume()
      {
         int sum = 0;

         // get current thread
         Thread current = Thread.CurrentThread;

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
            ".\nTerminating " + Thread.CurrentThread.Name + ".\n" );

      } // end method Consume

   } // end class Consumer

   // this class creates producer and consumer threads
   class SharedCell
   {
      // create producer and consumer threads and start them
      static void Main( string[] args )
      {
         // create shared object used by threads
         HoldIntegerSynchronized holdInteger = 
            new HoldIntegerSynchronized();

         // Random object used by each thread
         Random random = new Random();

         // create Producer and Consumer objects
         Producer producer = 
            new Producer( holdInteger, random );

         Consumer consumer = 
            new Consumer( holdInteger, random );

         // output column heads and initial buffer state
         Console.WriteLine( "{0,-35}{1,-9}{2}\n",
            "Operation", "Buffer", "Occupied Count" );
         holdInteger.DisplayState( "Initial state"  );

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