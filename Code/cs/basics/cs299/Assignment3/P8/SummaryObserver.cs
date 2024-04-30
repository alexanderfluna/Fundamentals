// Alexander Luna | Assignment 3 | SummaryObserver.cs
using System;

namespace Assignment3
{
    public class SummaryObserver : Observer
    {
        // This observer summarizes the change
        public void StateChanged(ChangeEvent changeEvent)
        {
            Console.WriteLine($"SUMMARY OBSERVER: Change: {changeEvent.changeType}, Item: {changeEvent.item}");
        }
    }
}
