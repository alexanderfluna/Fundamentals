// Fig. 14.6: CircularBuffer.cs
// Implementing the producer/consumer relationship with a
// circular buffer.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace CircularBuffer
{
   // implement the shared integer with synchronization
   public class HoldIntegerSynchronized
   {
      // each array element is a buffer
      private int[] buffers = { -1, -1, -1 };

      // occupiedBufferCount maintains count of occupied buffers
      private int occupiedBufferCount = 0;

      // variable that maintain read and write buffer locations
      private int readLocation = 0, writeLocation = 0;
      
      // GUI component to display output
      private TextBox outputTextBox;

      // constructor
      public HoldIntegerSynchronized( TextBox output )
      {
         outputTextBox = output;
      }

      // property Buffer
      public int Buffer
      {
         get
         {
            // lock this object while getting value 
            // from buffers array
            lock ( this )
            {
               // if there is no data to read, place invoking 
               // thread in WaitSleepJoin state
               if ( occupiedBufferCount == 0 )
               {
                  outputTextBox.Text += "\r\nAll buffers empty. " + 
                     Thread.CurrentThread.Name + " waits.";
                  outputTextBox.ScrollToCaret();

                  Monitor.Wait( this );
               }

               // obtain value at current readLocation, then 
               // add string indicating consumed value to output
               int readValue = buffers[ readLocation ];

               outputTextBox.Text += "\r\n" + 
                  Thread.CurrentThread.Name + " reads " + 
                  buffers[ readLocation ] + " ";

               // just consumed a value, so decrement number of 
               // occupied buffers
               --occupiedBufferCount;

               // update readLocation for future read operation,
               // then add current state to output
               readLocation = 
                  ( readLocation + 1 ) % buffers.Length;
               outputTextBox.Text += CreateStateOutput();
               outputTextBox.ScrollToCaret();

               // return waiting thread (if there is one) 
               // to Started state
               Monitor.Pulse( this );

               return readValue;

            } // end lock

         } // end accessor get

         set
         {
            // lock this object while setting value 
            // in buffers array
            lock ( this )
            {
               // if there are no empty locations, place invoking
               // thread in WaitSleepJoin state
               if ( occupiedBufferCount == buffers.Length )
               {
                  outputTextBox.Text += "\r\nAll buffers full. " + 
                     Thread.CurrentThread.Name + " waits.";
                  outputTextBox.ScrollToCaret();

                  Monitor.Wait( this );
               }

               // place value in writeLocation of buffers, then
               // add string indicating produced value to output
               buffers[ writeLocation ] = value;

               outputTextBox.Text += "\r\n" + 
                  Thread.CurrentThread.Name + " writes " + 
                  buffers[ writeLocation ] + " ";

               // just produced a value, so increment number of 
               // occupied buffers
               ++occupiedBufferCount;

               // update writeLocation for future write operation,
               // then add current state to output
               writeLocation = 
                  ( writeLocation + 1 ) % buffers.Length;
               outputTextBox.Text += CreateStateOutput();
               outputTextBox.ScrollToCaret();

               // return waiting thread (if there is one) 
               // to Started state
               Monitor.Pulse( this );

            } // end lock

         } // end accessor set

      } // end property Buffer

      // create state output
      public string CreateStateOutput()
      {
         // display first line of state information
         string output = "(buffers occupied: " + 
            occupiedBufferCount + ")\r\nbuffers: ";

         for ( int i = 0; i < buffers.Length; i++ )
            output += " " + buffers[ i ] + "  ";

         output += "\r\n";

         // display second line of state information
         output += "         ";

         for ( int i = 0; i < buffers.Length; i++ )
            output += "---- ";

         output += "\r\n";

         // display third line of state information
         output += "         ";

         // display readLocation (R) and writeLocation (W)
         // indicators below appropriate buffer locations
         for ( int i = 0; i < buffers.Length; i++ ) 

            if ( i == writeLocation && 
               writeLocation == readLocation ) 
               output += " WR  ";
            else if ( i == writeLocation )
               output += " W   ";
            else if  ( i == readLocation ) 
               output += "  R  ";
            else
               output += "     ";

         output += "\r\n";

         return output;
      }

   } // end class HoldIntegerSynchronized

   // produce the integers from 11 to 20 and place them in buffer
   public class Producer
   {
      private HoldIntegerSynchronized sharedLocation;
      private TextBox outputTextBox;
      private Random randomSleepTime;

      // constructor
      public Producer( HoldIntegerSynchronized shared, 
         Random random, TextBox output )
      {
         sharedLocation = shared;
         outputTextBox = output;
         randomSleepTime = random;
      }

      // produce values from 11-20 and place them in 
      // sharedLocation's buffer
      public void Produce()
      {
         // sleep for random interval upto 3000 milliseconds
         // then set sharedLocation's Buffer property
         for ( int count = 11; count <= 20; count++ )
         {
            Thread.Sleep( randomSleepTime.Next( 1, 3000 ) );
            sharedLocation.Buffer = count;
         }

         string name = Thread.CurrentThread.Name;

         outputTextBox.Text += "\r\n" + name +
            " done producing.\r\n" + name + " terminated.\r\n";
         
         outputTextBox.ScrollToCaret();

      } // end method Produce

   } // end class Producer

   // consume the integers 1 to 10 from circular buffer
   public class Consumer
   {
      private HoldIntegerSynchronized sharedLocation;
      private TextBox outputTextBox;
      private Random randomSleepTime;

      // constructor
      public Consumer( HoldIntegerSynchronized shared,
         Random random, TextBox output )
      {
         sharedLocation = shared;
         outputTextBox = output;
         randomSleepTime = random;
      }

      // consume 10 integers from buffer
      public void Consume()
      {
         int sum = 0;

         // loop 10 times and sleep for random interval upto 
         // 3000 milliseconds then add sharedLocation's 
         // Buffer property value to sum
         for ( int count = 1; count <= 10; count++ )
         {
            Thread.Sleep( randomSleepTime.Next( 1, 3000 ) );
            sum += sharedLocation.Buffer;
         }

         string name = Thread.CurrentThread.Name;
         
         outputTextBox.Text += "\r\nTotal " + name + 
            " consumed: " + sum + ".\r\n" + name + 
            " terminated.\r\n";

         outputTextBox.ScrollToCaret();

      } // end method Consume

   } // end class Consumer

   // set up the producer and consumer and start them
   public class CircularBuffer : System.Windows.Forms.Form
   {
      private System.Windows.Forms.TextBox outputTextBox;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // no-argument constructor
      public CircularBuffer()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.outputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // outputTextBox
         // 
         this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.outputTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.outputTextBox.Multiline = true;
         this.outputTextBox.Name = "outputTextBox";
         this.outputTextBox.ReadOnly = true;
         this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.outputTextBox.Size = new System.Drawing.Size(304, 461);
         this.outputTextBox.TabIndex = 0;
         this.outputTextBox.Text = "";
         // 
         // CircularBuffer
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(304, 461);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputTextBox});
         this.Name = "CircularBuffer";
         this.Text = "CircularBuffer";
         this.Load += new System.EventHandler(this.CircularBuffer_Load);
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new CircularBuffer() );
      }

      // Load event handler creates and starts threads
      private void CircularBuffer_Load( 
         object sender, System.EventArgs e )
      {
         // create shared object
         HoldIntegerSynchronized sharedLocation = 
            new HoldIntegerSynchronized( outputTextBox );

         // display sharedLocation state before producer
         // and consumer threads begin execution
         outputTextBox.Text = sharedLocation.CreateStateOutput();

         // Random object used by each thread
         Random random = new Random();

         // create Producer and Consumer objects
         Producer producer = 
            new Producer( sharedLocation, random, outputTextBox );
         Consumer consumer =
            new Consumer( sharedLocation, random, outputTextBox );

         // create and name threads
         Thread producerThread = 
            new Thread( new ThreadStart( producer.Produce ) );
         producerThread.Name = "Producer";

         Thread consumerThread = 
            new Thread( new ThreadStart( consumer.Consume ) );
         consumerThread.Name = "Consumer";

         // start threads
         producerThread.Start();
         consumerThread.Start();

      } // end CircularBuffer_Load method

   } // end class CircularBuffer
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