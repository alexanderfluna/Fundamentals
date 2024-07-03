// Alexander Luna | Assignment 3 | Test8.cs
using System;

namespace Assignment3
{
    /// <summary>
    /// 8d. Provide a test program to test your event-driven implementation.
    /// </summary>
    public class Test8
    {
        public static void Main()
        {
            AddRemoveObserver addRemoveObserver = new AddRemoveObserver();
            PriceObserver priceObserver = new PriceObserver();            

            // Invoice 1:

            // Create products for order 1
            Product tuner = new Product("Tuner", 10);
            Product amplifier = new Product("Amplifier", 20);
            Product cd_player = new Product("CD player", 30);
            Product speakers = new Product("Speakers", 40);

            // Add products to stereo system bundle
            Bundle stereo_system = new Bundle();
            stereo_system.AddItem(tuner);
            stereo_system.AddItem(amplifier);
            stereo_system.AddItem(cd_player);
            stereo_system.AddItem(speakers);

            // Create order 1 with stereo system bundle
            Console.WriteLine("Invoice 1:");
            Invoice invoice1 = new Invoice();
            invoice1.AttachObserver(addRemoveObserver);
            invoice1.AttachObserver(priceObserver);
            invoice1.AddItem(stereo_system);
            invoice1.RemoveItem(stereo_system);


            // Invoice 2:

            // Discount the stereo system bundle to half off
            DiscountedItem discounted_stereo_system = new DiscountedItem(stereo_system, .50);

            // Create order 2 with discounted stereo system bundle
            Console.WriteLine("==============================================================");
            Console.WriteLine("\nInvoice 2:");
            Invoice invoice2 = new Invoice();
            invoice2.AttachObserver(addRemoveObserver);
            invoice2.AttachObserver(priceObserver);
            invoice2.AddItem(discounted_stereo_system);
            invoice2.RemoveItem(discounted_stereo_system);


            // Invoice 3:

            // Create products for order 3
            Product monitor = new Product("Monitor", 300);
            Product keyboard = new Product("Keyboard", 50);
            Product mouse = new Product("Mouse", 20);
            DiscountedItem discounted_speakers = new DiscountedItem(speakers, .20);

            // Add products to computer bundle
            Bundle computer = new Bundle();
            computer.AddItem(monitor);
            computer.AddItem(keyboard);
            computer.AddItem(mouse);

            // Create order 3 with computer bundle and discounted speakers
            Console.WriteLine("==============================================================");
            Console.WriteLine("\nInvoice 3:");
            Invoice invoice3 = new Invoice();
            invoice3.AttachObserver(addRemoveObserver);
            invoice3.AttachObserver(priceObserver);
            invoice3.AddItem(computer);
            invoice3.AddItem(discounted_speakers);
            invoice3.RemoveItem(discounted_speakers);
        }
    }
}
