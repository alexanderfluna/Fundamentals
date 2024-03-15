using System;

class MyArray
{
    private int[] array;

    public MyArray(int[] arr)
    {
        array = arr;
    }

    public void Display()
    {
        Console.Write("Array: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public void Search(int element)
    {
        int index = Array.IndexOf(array, element);
        if (index != -1)
        {
            Console.WriteLine($"Element {element} found at index {index}");
        }
        else
        {
            Console.WriteLine($"Element {element} not found in the array");
        }
    }

    public void FindMax()
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"Maximum element: {max}");
    }

    public void FindMin()
    {
        int min = array[0];
        foreach (int num in array)
        {
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine($"Minimum element: {min}");
    }

    public void CalculateAverage()
    {
        double sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        double average = sum / array.Length;
        Console.WriteLine($"Average of the array: {average}");
    }

    public void FindMedian()
    {
        // Note: The array must be sorted to find the median
        Array.Sort(array);

        int middle = array.Length / 2;

        if (array.Length % 2 == 0)
        {
            // Even number of elements, average the middle two
            double median = (array[middle - 1] + array[middle]) / 2.0;
            Console.WriteLine($"Median of the array: {median}");
        }
        else
        {
            // Odd number of elements, middle element is the median
            Console.WriteLine($"Median of the array: {array[middle]}");
        }
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        MyArray myArray = new MyArray(numbers);

        myArray.Display();
        myArray.Search(7);
        myArray.FindMax();
        myArray.FindMin();
        myArray.CalculateAverage();
        myArray.FindMedian();
    }
}
