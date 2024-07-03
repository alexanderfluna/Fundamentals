using System;
using System.Collections.Generic;

class BinaryHeap<T> where T : IComparable<T>
{
    private List<T> elements;

    public BinaryHeap()
    {
        elements = new List<T>();
    }

    public int Count
    {
        get { return elements.Count; }
    }

    public void Add(T item)
    {
        elements.Add(item);
        HeapifyUp(elements.Count - 1);
    }

    public T Peek()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        return elements[0];
    }

    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        T root = elements[0];
        elements[0] = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);

        HeapifyDown(0);

        return root;
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (elements[index].CompareTo(elements[parentIndex]) < 0)
            {
                Swap(index, parentIndex);
                index = parentIndex;
            }
            else
            {
                break;
            }
        }
    }

    private void HeapifyDown(int index)
    {
        int leftChildIndex, rightChildIndex, minIndex;

        while (true)
        {
            leftChildIndex = 2 * index + 1;
            rightChildIndex = 2 * index + 2;
            minIndex = index;

            if (leftChildIndex < elements.Count && elements[leftChildIndex].CompareTo(elements[minIndex]) < 0)
            {
                minIndex = leftChildIndex;
            }

            if (rightChildIndex < elements.Count && elements[rightChildIndex].CompareTo(elements[minIndex]) < 0)
            {
                minIndex = rightChildIndex;
            }

            if (minIndex != index)
            {
                Swap(index, minIndex);
                index = minIndex;
            }
            else
            {
                break;
            }
        }
    }

    private void Swap(int i, int j)
    {
        T temp = elements[i];
        elements[i] = elements[j];
        elements[j] = temp;
    }
}

class Program
{
    static void Main()
    {
        BinaryHeap<int> minHeap = new BinaryHeap<int>();

        minHeap.Add(4);
        minHeap.Add(10);
        minHeap.Add(8);
        minHeap.Add(5);
        minHeap.Add(1);

        Console.WriteLine("Min Heap Peek: " + minHeap.Peek());

        Console.WriteLine("Min Heap Pop:");
        while (minHeap.Count > 0)
        {
            Console.Write(minHeap.Pop() + " ");
        }
        Console.WriteLine();

        while (minHeap.Count > 0)
        {
            Console.Write(minHeap.Pop() + " ");
        }
        Console.WriteLine();
    }
}
