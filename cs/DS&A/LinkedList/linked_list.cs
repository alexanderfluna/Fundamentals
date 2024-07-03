using System;
using System.Collections;
using System.Collections.Generic;

class MyLinkedList<T> : IEnumerable<T>
{
    private class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node head;
    private Node tail;

    public int Count { get; private set; }

    public void AddFirst(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }

        Count++;
    }

    public void AddLast(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }

        Count++;
    }

    public void RemoveFirst()
    {
        if (head == null)
            return;

        head = head.Next;

        if (head == null)
            tail = null;

        Count--;
    }

    public void RemoveLast()
    {
        if (head == null)
            return;

        if (head == tail)
        {
            head = tail = null;
        }
        else
        {
            Node current = head;
            while (current.Next != tail)
            {
                current = current.Next;
            }

            current.Next = null;
            tail = current;
        }

        Count--;
    }

    public bool Contains(T value)
    {
        Node current = head;

        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value))
                return true;

            current = current.Next;
        }

        return false;
    }

    public void Clear()
    {
        head = tail = null;
        Count = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;

        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
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
        MyLinkedList<int> linkedList = new MyLinkedList<int>();

        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);

        Console.WriteLine("LinkedList Contents:");
        foreach (var item in linkedList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Contains 2: {linkedList.Contains(2)}");

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
