using System;

namespace ConsoleApplication
{
    public class Sort
    {
        // Input: arr - array of SortableI objects
        // Input: n - the size of the array
        public static void SelectionSort(SortableI [] arr, int n)
        {
            SortableI temp; // will be used to swap elements of the array
            int smallest; // will point to the smallest value in the array

            // Iterate through the SortableI array
            for (int leftmost = 0; leftmost < n - 1; leftmost++)
            {
                // smallest points to the leftmost SortableI object
                smallest = leftmost;

                // Iterate through the SortableI starting at the element
                // immediately to the right of the leftmost element
                for (int j = leftmost + 1; j < n; j++)
                {
                    // Find the smallest value to the right of the 
                    // leftmost element and then point to it
                    if (arr[j].LessThan(arr[smallest]))
                        smallest = j;
                }

                // Swap the smallest element to te right of the
                // leftmost element with the leftmost element
                temp = arr[smallest]; // t points to the spot of the smallest element to the right of the leftmost element
                arr[smallest] = arr[leftmost]; // the smallest element is now in the spot of the leftmost element
                arr[leftmost] = temp; // what was the leftmost element is now in the spot of where the smallest element was

            }
        }
    }
}