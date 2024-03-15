using System;
using System.Collections.Generic;

class MyHashSet<T>
{
    private HashSet<T> hashSet;

    public MyHashSet()
    {
        hashSet = new HashSet<T>();
    }

    public void Add(T item)
    {
        hashSet.Add(item);
    }

    public void Clear()
    {
        hashSet.Clear();
    }

    public bool Contains(T item)
    {
        return hashSet.Contains(item);
    }

    public void CopyTo(T[] array)
    {
        hashSet.CopyTo(array);
    }

    public int Count
    {
        get { return hashSet.Count; }
    }

    public bool Remove(T item)
    {
        return hashSet.Remove(item);
    }

    public void Display()
    {
        Console.Write("HashSet Contents: ");
        foreach (var item in hashSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        MyHashSet<int> myHashSet = new MyHashSet<int>();

        myHashSet.Add(1);
        myHashSet.Add(2);
        myHashSet.Add(3);

        Console.WriteLine("HashSet Contents:");
        myHashSet.Display();

        Console.WriteLine($"Contains 2: {myHashSet.Contains(2)}");

        myHashSet.Remove(2);
        Console.WriteLine("\nAfter Removing 2:");
        myHashSet.Display();

        int[] array = new int[3];
        myHashSet.CopyTo(array);
        Console.WriteLine("\nCopied to Array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine($"\nCount: {myHashSet.Count}");
    }
}
