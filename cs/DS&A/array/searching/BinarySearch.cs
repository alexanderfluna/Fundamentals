// Binary search in C#

using System;

class BinarySearch
{
    static int BinarySearchRecursive(int[] array, int target, int left, int right)
    {
        if (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if the target is present at the middle
            if (array[mid] == target)
                return mid;

            // If the target is smaller, ignore the right half
            if (array[mid] > target)
                return BinarySearchRecursive(array, target, left, mid - 1);

            // If the target is larger, ignore the left half
            return BinarySearchRecursive(array, target, mid + 1, right);
        }

        // Target is not present in the array
        return -1;
    }

    static int BinarySearchIterative(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if the target is present at the middle
            if (array[mid] == target)
                return mid;

            // If the target is smaller, ignore the right half
            if (array[mid] > target)
                right = mid - 1;
            // If the target is larger, ignore the left half
            else
                left = mid + 1;
        }

        // Target is not present in the array
        return -1;
    }

    static void Main()
    {
        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int target = 7;

        // Using recursive binary search
        int resultRecursive = BinarySearchRecursive(sortedArray, target, 0, sortedArray.Length - 1);

        if (resultRecursive != -1)
            Console.WriteLine($"Recursive: Element {target} found at index {resultRecursive}");
        else
            Console.WriteLine($"Recursive: Element {target} not found");

        // Using iterative binary search
        int resultIterative = BinarySearchIterative(sortedArray, target);

        if (resultIterative != -1)
            Console.WriteLine($"Iterative: Element {target} found at index {resultIterative}");
        else
            Console.WriteLine($"Iterative: Element {target} not found");
    }
}
