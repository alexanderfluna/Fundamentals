// Alexander Luna | Assignment 3 | Test.cs
using System;

namespace Assignment3
{
    /// <summary>
    /// 8d. Provide a test program to test your event-driven implementation.
    /// </summary>
    public class Test
    {
        public static void Main()
        {
            Invoice invoice = new Invoice();
            PrintObserver printObserver = new PrintObserver();
            SummaryObserver summaryObserver = new SummaryObserver();

            invoice.AttachObserver(printObserver);
            invoice.AttachObserver(summaryObserver);

            Product product1 = new Product("Product 1", 10.00);
            invoice.AddItem(product1);

            Product product2 = new Product ("Product 2", 20.00);
            invoice.AddItem(product2);

            invoice.RemoveItem(product1);
        }
    }
}