// Alexander Luna | Assignment 3 | Test7.cs
using System;

namespace Assignment3
{
    /// <summary>
    /// 7.	Make an iterator to iterate over each product in an order. And a test class to test it.
    /// </summary>
    public class Test7
    {
        public static void Main()
        {
            // ORDER 1:

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
            Order order1 = new Order();
            order1.AddItem(stereo_system);

            // Iterate over each product in order1
            Console.WriteLine("Iterating over each product in order 1:");
            foreach (LineItem item in order1.GetProducts())
            {
                Console.WriteLine(item);
            }


            // ORDER 2:

            // Discount the stereo system bundle to half off
            DiscountedItem discounted_stereo_system = new DiscountedItem(stereo_system, .50);

            // Create order 2 with discounted stereo system bundle
            Order order2 = new Order();
            order2.AddItem(discounted_stereo_system);

            // Iterate over each product in order2
            Console.WriteLine("\nIterating over each product in order 2:");
            foreach (LineItem item in order2.GetProducts())
            {
                Console.WriteLine(item);
            }

            // Order 3:

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
            Order order3 = new Order();
            order3.AddItem(computer);
            order3.AddItem(discounted_speakers);

            // Iterate over each product in order3
            Console.WriteLine("\nIterating over each product in order 3:");
            foreach (LineItem item in order3.GetProducts())
            {
                Console.WriteLine(item);
            }
        }
    }
}
