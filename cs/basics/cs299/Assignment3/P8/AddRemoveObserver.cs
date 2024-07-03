// Alexander Luna | Assignment 3 | AddRemoveObserver.cs
using System;

namespace Assignment3
{
    /// <summary>
    /// This observer prints whether the item was added or removed from the invoice
    /// </summary>
    public class AddRemoveObserver : Observer
    {
        
        public void StateChanged(ChangeEvent changeEvent)
        {
            Console.WriteLine($"Add/Remove: {changeEvent.changeType}");
        }
    }
}