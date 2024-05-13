// Alexander Luna | Test 3 | ComparablePair.cs
using System;

namespace test3
{
    // Implement a class ComparablePair<T, U> which implements the interface IComparable<ComparablePair<T, U>>
    public class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
    // T and U are types that implement IComparable<T> and IComparable<U> respectively
    where T : IComparable<T>
    where U : IComparable<U>
    {
        // Properties that return each of the parts
        public T First { get; }
        public U Second { get; }

        // The class ComparablePair<T, U> should have an appropriate constructor that initializes both parts of the pair
        public ComparablePair(T first, U second)
        {
            First = first;
            Second = second;
        }

        // The method from the IComparable interface we must implement
        // Input: The other object of this class we are comparing to
        public int CompareTo(ComparablePair<T, U> other)
        {
            // Compare the values of the First property of both objects
            int firstComparison = First.CompareTo(other.First);

            // If the values are not equal, return the comparison
            if (firstComparison != 0)
                return firstComparison;

            // If the values of the First property were equal, compare the Second property of the objects
            return Second.CompareTo(other.Second);
        }
    }

    // Write a program to test your class
    class Program
    {
        static void Main()
        {
            // An arrays of pairs
            ComparablePair<int, string>[] pairs = new ComparablePair<int, string>[]
             {
                new ComparablePair<int, string>(2, "John"),
                new ComparablePair<int, string>(1, "Alice"),
                new ComparablePair<int, string>(3, "Bob"),
                new ComparablePair<int, string>(1, "Charlie"),
                new ComparablePair<int, string>(2, "Mary")
             };

            // Print the unsorted pairs
            Console.WriteLine("Unsorted pairs:");
            foreach (ComparablePair<int, string> pair in pairs)
                Console.WriteLine($"({pair.First}, {pair.Second})");

            // Sort the pairs using System.Array.Sort
            Array.Sort(pairs);

            // Print the sorted pairs
            Console.WriteLine("\nSorted pairs:");
            foreach (ComparablePair<int, string> pair in pairs)
                Console.WriteLine($"({pair.First}, {pair.Second})");
        }
    }
}
