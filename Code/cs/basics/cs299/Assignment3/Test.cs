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
            // Create products
            Product tuner = new Product ("Tuner", 10 );
            Product amplifier = new Product ("Amplifier", 20 );
            Product cd_player = new Product ("CD player", 30 );
            Product speakers = new Product("Speakers", 40);
            DiscountedItem discounted_speakers = new DiscountedItem(speakers, .20);

            // Create bundle
            Bundle stereo_system = new Bundle("Stereo system");
            stereo_system.AddItem(tuner);
            stereo_system.AddItem(amplifier);
            stereo_system.AddItem(cd_player);
            stereo_system.AddItem(discounted_speakers);

            // Create an order with the bundle
            Order order1 = new Order();
            order1.AddItem(stereo_system);
            Console.Write(order1);

            // Discount the stereo system to half off
            DiscountedItem discounted_stereo_system = new DiscountedItem(stereo_system, .50);

            // Create an order with the discounted bundle
            Order order2 = new Order();
            order2.AddItem(discounted_stereo_system);
            Console.Write(order2);
        }
    }
}