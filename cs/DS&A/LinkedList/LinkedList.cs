using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new linked list of integers
        LinkedList<int> linkedList = new LinkedList<int>();

        // Add elements to the linked list
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        // Display the linked list
        Console.WriteLine("LinkedList Contents:");
        foreach (var item in linkedList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Check if the linked list contains a specific value
        Console.WriteLine($"Contains 2: {linkedList.Contains(2)}");

        // Remove elements from the linked list
        linkedList.RemoveFirst();
        Console.WriteLine("\nAfter Removing First Element:");
        foreach (var item in linkedList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        linkedList.RemoveLast();
        Console.WriteLine("\nAfter Removing Last Element:");
        foreach (var item in linkedList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
