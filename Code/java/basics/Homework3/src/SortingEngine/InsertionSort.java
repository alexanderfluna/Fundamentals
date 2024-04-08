// Alexander Luna | InsertionSort.java
// Implementation of insertion sort that implements SortingAlgorithmI

package SortingEngine;

import java.io.Serializable;

public class InsertionSort implements SortingAlgorithmI, Serializable {

    // Empty constructor
    InsertionSort() {}

    // Input: an unsorted array of ints
    // Output: the same array after being sorted using insertion sort
    @Override
    public int[] sort(int[] array) {
        return insertionSort(array);
    }

    // Input: an array, A[0..n-1] of sortable objects
    // Output: the same array sorted in non-decreasing order
    public static int[] insertionSort(int[] A) {
        int n = A.length;
        for (int i = 1; i < n; i++) {
            int key = A[i];
            int j = i - 1;

            // Slide to the right
            while (j >= 0 && A[j] > key) {
                A[j + 1] = A[j];
                j--;
            }

            // Place the key into the hole
            A[j + 1] = key;
        }
        return A;
    }
}
