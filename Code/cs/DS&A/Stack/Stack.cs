using System;
using System.Collections;
using System.Collections.Generic;

class MyStack<T> : IEnumerable<T>
{
    private Stack<T> stack;

    public MyStack()
    {
        stack = new Stack<T>();
    }

    public void Push(T item)
    {
        stack.Push(item);
    }

    public T Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return stack.Pop();
    }

    public T Peek()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return stack.Peek();
    }

    public bool Contains(T item)
    {
        return stack.Contains(item);
    }

    public void Clear()
    {
        stack.Clear();
    }

    public int Count
    {
        get { return stack.Count; }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return stack.GetEnumerator();
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
        MyStack<int> myStack = new MyStack<int>();

        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        Console.WriteLine("Stack Contents:");
        DisplayStack(myStack);

        Console.WriteLine($"Pop: {myStack.Pop()}");

        Console.WriteLine($"Peek: {myStack.Peek()}");

        Console.WriteLine($"\nCount: {myStack.Count}");

        Console.WriteLine($"Contains 2: {myStack.Contains(2)}");

        myStack.Clear();
        Console.WriteLine("\nAfter Clearing the Stack:");
        DisplayStack(myStack);
    }

    static void DisplayStack<T>(MyStack<T> stack)
    {
        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
