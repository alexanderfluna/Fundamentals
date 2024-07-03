using System;

class QuickSort
{
    static void Main()
    {
        int[] array = { 12, 4, 5, 6, 7, 3, 1, 15 };
        
        Console.WriteLine("Original array:");
        PrintArray(array);

        QuickSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    static void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(arr, low, high);

            QuickSortAlgorithm(arr, low, partitionIndex - 1);
            QuickSortAlgorithm(arr, partitionIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, high);

        return i + 1;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
