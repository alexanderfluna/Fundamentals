// Alexander Luna | Assignment 3 | PriceObserver.cs
using System;

namespace Assignment3
{
    /// <summary>
    /// This observer prints the price of the item
    /// </summary>
    public class PriceObserver : Observer
    {
        public void StateChanged(ChangeEvent changeEvent)
        {
            Console.WriteLine($"Price:  {changeEvent.item.Price:c}\n");
        }
    }
}
