using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> myList = new List<int>();

        // Add elements to the list
        myList.Add(3);
        myList.Add(1);
        myList.Add(2);

        // Display the list
        Console.WriteLine("List Contents:");
        DisplayList(myList);

        // Check if the list contains a specific value
        Console.WriteLine($"Contains 2: {myList.Contains(2)}");

        // Remove elements from the list
        myList.Remove(2);
        Console.WriteLine("\nAfter Removing 2:");
        DisplayList(myList);

        // Insert an element at a specific index
        myList.Insert(1, 4);
        Console.WriteLine("\nAfter Inserting 4 at index 1:");
        DisplayList(myList);
    }

    static void DisplayList<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
