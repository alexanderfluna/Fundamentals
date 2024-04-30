// Alexander Luna | Assignment 3 | Test6.cs
using System;

namespace Assignment3
{
    /// <summary>
    /// 6. Provide a test class to test the classes developed so far.
    /// </summary>
    public class Test6
    {
        public static void Main()
        {

            // ORDER 1:

            // Create products for order 1
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

            // Create order 1 with stereo system bundle
            Order order1 = new Order();
            order1.AddItem(stereo_system);
            Console.WriteLine("Order 1:\n" + order1);


            // ORDER 2:

            // Discount the stereo system bundle to half off
            DiscountedItem discounted_stereo_system = new DiscountedItem(stereo_system, .50);

            // Create order 2 with discounted stereo system bundle
            Order order2 = new Order();
            order2.AddItem(discounted_stereo_system);
            Console.WriteLine("==============================================================");
            Console.WriteLine("Order 2:\n" + order2);


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
            Console.WriteLine("==============================================================");
            Console.WriteLine("Order 3:\n" + order3);
        }
    }
}
