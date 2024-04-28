// Alexander Luna | Assignment 3 | Test.cs
using System;

namespace Assignment3
{
    /// <summary>
    /// 6. Provide a test class to test the classes developed so far.
    /// </summary>
    public class Test
    {
        public static void Main()
        {

            // ORDER 1:

            // Create products for stereo system bundle
            Product tuner = new Product ("Tuner", 10 );
            Product amplifier = new Product ("Amplifier", 20 );
            Product cd_player = new Product ("CD player", 30 );
            Product speakers = new Product("Speakers", 40);

            // Add products to stereo system bundle
            Bundle stereo_system = new Bundle();
            stereo_system.AddItem(tuner);
            stereo_system.AddItem(amplifier);
            stereo_system.AddItem(cd_player);
            stereo_system.AddItem(speakers);

            // Create order with stereo system bundle
            Order order1 = new Order();
            order1.AddItem(stereo_system);
            Console.WriteLine("Order 1:\n" + order1);


            // ORDER 2:

            // Discount the stereo system bundle to half off
            DiscountedItem discounted_stereo_system = new DiscountedItem(stereo_system, .50);

            // Create order with discounted stereo system bundle
            Order order2 = new Order();
            order2.AddItem(discounted_stereo_system);
            Console.WriteLine("\nOrder 2:\n" + order2);


            // Order 3:

            // Create products for computer
            Product monitor = new Product("Monitor", 500);
            Product mouse = new Product("Mouse", 10);
            DiscountedItem discounted_speakers = new DiscountedItem(speakers, .20);

            // Add products to computer bundle
            Bundle computer = new Bundle();
            computer.AddItem(monitor);
            computer.AddItem(mouse);

            // Create order with computer bundle and discounted speakers
            Order order3 = new Order();
            order3.AddItem(computer);
            order3.AddItem(discounted_speakers);
            Console.WriteLine("\nOrder 3:\n" + order3);

        }
    }
}