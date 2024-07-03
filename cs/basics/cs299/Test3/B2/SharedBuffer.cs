// Alexander Luna | Test 3 | SharedBuffer.cs
using System;
using System.Threading;

namespace Multithreading
{
   public class IntCell
   {
        public int Number
        {
            get;
            set;            
        }       
    }
   
    public class MessageBuffer
    {
        IntCell cell1 = new IntCell();
        IntCell cell2 = new IntCell(); // Add another instance variable IntCell cell2
        bool useCell1 = true; // This will be used as a flag to determine whether to use cell1 or cell2

        // Change SetMessage to alternate between the two variables cell1 and cell2
        public void SetMessage(int num)
        {
            IntCell currentCell = useCell1 ? cell1 : cell2; // If true, use cell1. If false, use cell2
            Monitor.Enter(currentCell); // Pass the current cell to the Monitor
            currentCell.Number = num; // Assign the number of the current cell to the number passed to the function
            Monitor.Pulse(currentCell); // Signal to any waiting threads
            Console.WriteLine("Set new message {0}", // Print the set message
                               currentCell.Number);
            Monitor.Exit(currentCell); // Release the current cell from the Monitor
            useCell1 = !useCell1;  // Flip the flag so we use the other cell for the next message
        }

        // Change ProcessMessages to alternate between the two variables cell1 and cell2
        public void ProcessMessages()
        {            
            while (true)
            {
                IntCell currentCell = useCell1 ? cell1 : cell2; // If true, use cell1. If false, use cell2
                Monitor.Enter(currentCell); // Pass the current cell to the Monitor
                try
                {
                    Monitor.Wait(currentCell); // The current cell enters a waiting state

                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine("ProcessMessage interrupted");
                    Monitor.Exit(currentCell);
                    return;
                }
                Console.WriteLine("Processed new message {0}", // Print the processed message
                                   currentCell.Number);
                Monitor.Exit(currentCell); // Release the current cell from the Monitor
                useCell1 = !useCell1; // Flip the flag so we use the other cell for the next message
            }
        }
    }

    public class CreateMessages
    {
        MessageBuffer msg;
        public CreateMessages(MessageBuffer m)
        {
            msg = m;
        }
        public void EntryPoint()
        {
            for (int i = 1; i <= 5; ++i)
            {
                msg.SetMessage(i);
                Thread.Sleep(400);
            }
            Console.WriteLine("CreateMessages thread terminating");
        }
    }

    public class ProcessMessages
    {
        MessageBuffer msg;
        public ProcessMessages(MessageBuffer m)
        {
            msg = m;
        }

        public void EntryPoint()
        {
            msg.ProcessMessages();
            Console.WriteLine("ProcessMessages thread terminating");
        }
    }
    public class Tester
    {
        public static void Main()
        {
            MessageBuffer m = new MessageBuffer();

            ProcessMessages pm = new ProcessMessages(m);
            CreateMessages cm = new CreateMessages(m);
            Thread consumer = new Thread(new ThreadStart(pm.EntryPoint));
            consumer.Start();

            Thread producer = new Thread(new ThreadStart(cm.EntryPoint));
            producer.Start();
            producer.Join();
            consumer.Interrupt();
            consumer.Join();

            Console.WriteLine("Primary thread terminating");
        }
    }
}
