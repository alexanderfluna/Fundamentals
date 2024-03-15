using System;

class MergeSort
{
    static void Main()
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("Original array:");
        PrintArray(array);

        // Perform merge sort
        MergeSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    static void MergeSortAlgorithm(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            // Recursively sort the two halves
            MergeSortAlgorithm(array, left, middle);
            MergeSortAlgorithm(array, middle + 1, right);

            // Merge the sorted halves
            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        // Create temporary arrays
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copy data to temporary arrays leftArray[] and rightArray[]
        for (int i = 0; i < n1; ++i)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; ++j)
            rightArray[j] = array[middle + 1 + j];

        // Merge the temporary arrays back into arr[left..right]
        int k = left;
        int leftIndex = 0, rightIndex = 0;

        while (leftIndex < n1 && rightIndex < n2)
        {
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                array[k] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[k] = rightArray[rightIndex];
                rightIndex++;
            }
            k++;
        }

        // Copy the remaining elements of leftArray[], if there are any
        while (leftIndex < n1)
        {
            array[k] = leftArray[leftIndex];
            leftIndex++;
            k++;
        }

        // Copy the remaining elements of rightArray[], if there are any
        while (rightIndex < n2)
        {
            array[k] = rightArray[rightIndex];
            rightIndex++;
            k++;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
