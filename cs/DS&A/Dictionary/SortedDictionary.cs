using System;
using System.Collections.Generic;
using System.Linq;

class MySortedDictionary<TKey, TValue>
{
    private SortedDictionary<TKey, TValue> sortedDictionary;

    public MySortedDictionary()
    {
        sortedDictionary = new SortedDictionary<TKey, TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        sortedDictionary.Add(key, value);
    }

    public bool ContainsKey(TKey key)
    {
        return sortedDictionary.ContainsKey(key);
    }

    public bool ContainsValue(TValue value)
    {
        return sortedDictionary.ContainsValue(value);
    }

    public int Count
    {
        get { return sortedDictionary.Count; }
    }

    public bool Remove(TKey key)
    {
        return sortedDictionary.Remove(key);
    }

    public void Clear()
    {
        sortedDictionary.Clear();
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        return sortedDictionary.TryGetValue(key, out value);
    }

    public TValue this[TKey key]
    {
        get { return sortedDictionary[key]; }
        set { sortedDictionary[key] = value; }
    }

    public ICollection<TKey> Keys
    {
        get { return sortedDictionary.Keys; }
    }

    public ICollection<TValue> Values
    {
        get { return sortedDictionary.Values; }
    }

    public KeyValuePair<TKey, TValue> First()
    {
        return sortedDictionary.First();
    }

    // Other methods could be added based on your requirements

    public void Display()
    {
        foreach (var pair in sortedDictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        MySortedDictionary<string, int> mySortedDictionary = new MySortedDictionary<string, int>();

        mySortedDictionary.Add("One", 1);
        mySortedDictionary.Add("Three", 3);
        mySortedDictionary.Add("Two", 2);

        Console.WriteLine("Sorted Dictionary Contents:");
        mySortedDictionary.Display();

        Console.WriteLine($"Contains Key 'Two': {mySortedDictionary.ContainsKey("Two")}");
        Console.WriteLine($"Contains Value 3: {mySortedDictionary.ContainsValue(3)}");

        mySortedDictionary.Remove("Two");
        Console.WriteLine("\nAfter Removing 'Two':");
        mySortedDictionary.Display();

        Console.WriteLine($"Value for Key 'Three': {mySortedDictionary["Three"]}");

        Console.WriteLine("\nKeys:");
        foreach (var key in mySortedDictionary.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nValues:");
        foreach (var value in mySortedDictionary.Values)
        {
            Console.WriteLine(value);
        }
    }
}
