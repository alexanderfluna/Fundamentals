using System;
using System.Collections;
using System.Collections.Generic;

class MySortedSet<T> : IEnumerable<T>
{
    private SortedSet<T> sortedSet;

    public MySortedSet()
    {
        sortedSet = new SortedSet<T>();
    }

    public void Add(T item)
    {
        sortedSet.Add(item);
    }

    public bool Remove(T item)
    {
        return sortedSet.Remove(item);
    }

    public bool Contains(T item)
    {
        return sortedSet.Contains(item);
    }

    public void Clear()
    {
        sortedSet.Clear();
    }

    public int Count
    {
        get { return sortedSet.Count; }
    }

    public void UnionWith(IEnumerable<T> other)
    {
        sortedSet.UnionWith(other);
    }

    public void IntersectWith(IEnumerable<T> other)
    {
        sortedSet.IntersectWith(other);
    }

    public void ExceptWith(IEnumerable<T> other)
    {
        sortedSet.ExceptWith(other);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return sortedSet.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        MySortedSet<int> mySortedSet = new MySortedSet<int>();

        mySortedSet.Add(3);
        mySortedSet.Add(1);
        mySortedSet.Add(2);

        Console.WriteLine("SortedSet Contents:");
        DisplaySortedSet(mySortedSet);

        Console.WriteLine($"Contains 2: {mySortedSet.Contains(2)}");

        mySortedSet.Remove(2);
        Console.WriteLine("\nAfter Removing 2:");
        DisplaySortedSet(mySortedSet);

        MySortedSet<int> otherSet = new MySortedSet<int> { 2, 4, 5 };

        mySortedSet.UnionWith(otherSet);
        Console.WriteLine("\nUnion with {2, 4, 5}:");
        DisplaySortedSet(mySortedSet);
    }

    static void DisplaySortedSet<T>(MySortedSet<T> sortedSet)
    {
        foreach (var item in sortedSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
