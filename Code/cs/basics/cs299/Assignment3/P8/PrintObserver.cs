// Alexander Luna | Assignment 3 | PrintObserver.cs
using System;

namespace Assignment3
{
    public class PrintObserver : Observer
    {
        // This observer prints the invoice after a change
        public void StateChanged(ChangeEvent changeEvent)
        {
            Console.WriteLine("PRINT OBSERVER: INVOICE CHANGE\t" + changeEvent.description);
            // Print the invoice details here
        }
    }
}