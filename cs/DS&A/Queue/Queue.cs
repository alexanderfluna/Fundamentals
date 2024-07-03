using System;
using System.Collections;
using System.Collections.Generic;

class MyQueue<T> : IEnumerable<T>
{
    private Queue<T> queue;

    public MyQueue()
    {
        queue = new Queue<T>();
    }

    public void Enqueue(T item)
    {
        queue.Enqueue(item);
    }

    public T Dequeue()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return queue.Dequeue();
    }

    public T Peek()
    {
        if (queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return queue.Peek();
    }

    public int Count
    {
        get { return queue.Count; }
    }

    public void Clear()
    {
        queue.Clear();
    }

    public bool Contains(T item)
    {
        return queue.Contains(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return queue.GetEnumerator();
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
        MyQueue<int> myQueue = new MyQueue<int>();

        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);

        Console.WriteLine("Queue Contents:");
        DisplayQueue(myQueue);

        Console.WriteLine($"Dequeue: {myQueue.Dequeue()}");

        Console.WriteLine($"Peek: {myQueue.Peek()}");

        Console.WriteLine($"\nCount: {myQueue.Count}");

        Console.WriteLine($"Contains 2: {myQueue.Contains(2)}");

        myQueue.Clear();
        Console.WriteLine("\nAfter Clearing the Queue:");
        DisplayQueue(myQueue);
    }

    static void DisplayQueue<T>(MyQueue<T> queue)
    {
        foreach (var item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}