using System;
using System.Collections.Generic;

class MyDictionary<TKey, TValue>
{
    private Dictionary<TKey, TValue> dictionary;

    public MyDictionary()
    {
        dictionary = new Dictionary<TKey, TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        dictionary.Add(key, value);
    }

    public bool ContainsKey(TKey key)
    {
        return dictionary.ContainsKey(key);
    }

    public bool ContainsValue(TValue value)
    {
        return dictionary.ContainsValue(value);
    }

    public int Count
    {
        get { return dictionary.Count; }
    }

    public bool Remove(TKey key)
    {
        return dictionary.Remove(key);
    }

    public void Clear()
    {
        dictionary.Clear();
    }

    public bool TryGetValue(TKey key, out TValue value)
    {
        return dictionary.TryGetValue(key, out value);
    }

    public TValue this[TKey key]
    {
        get { return dictionary[key]; }
        set { dictionary[key] = value; }
    }

    public ICollection<TKey> Keys
    {
        get { return dictionary.Keys; }
    }

    public ICollection<TValue> Values
    {
        get { return dictionary.Values; }
    }

    // Other methods could be added based on your requirements

    public void Display()
    {
        foreach (var pair in dictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

        myDictionary.Add("One", 1);
        myDictionary.Add("Two", 2);
        myDictionary.Add("Three", 3);

        Console.WriteLine("Dictionary Contents:");
        myDictionary.Display();

        Console.WriteLine($"Contains Key 'Two': {myDictionary.ContainsKey("Two")}");
        Console.WriteLine($"Contains Value 3: {myDictionary.ContainsValue(3)}");

        myDictionary.Remove("Two");
        Console.WriteLine("\nAfter Removing 'Two':");
        myDictionary.Display();

        Console.WriteLine($"Value for Key 'Three': {myDictionary["Three"]}");

        Console.WriteLine("\nKeys:");
        foreach (var key in myDictionary.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nValues:");
        foreach (var value in myDictionary.Values)
        {
            Console.WriteLine(value);
        }
    }
}
