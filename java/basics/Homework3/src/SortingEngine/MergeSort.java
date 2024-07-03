// Alexander Luna | MergeSort.java
// Implementation of merge sort that implements SortingAlgorithmI

package SortingEngine;

import java.io.Serializable;

public class MergeSort implements SortingAlgorithmI, Serializable {

    // Empty constructor
    MergeSort() {}

    // Input: an unsorted array of ints
    // Output: the same array after being sorted using merge sort
    @Override
    public int[] sort(int[] array) {
        return mergeSort(array, 0, array.length - 1);
    }

    // Input: an unsorted array A[0..n-1]
    // Input: an integer l, the left-most index
    // Input: an integer r, the right-most index
    // Output: the array A, sorted in non-decreasing order
    public static int[] mergeSort(int[] A, int l, int r) {
        // Check if there is anything to sort
        if (l < r) {

            // Compute the middle index
            int m = (l + r) / 2;

            // Sort the left-hand side
            mergeSort(A, l, m);

            // Sort the right-hand side
            mergeSort(A, m + 1, r);

            // Merge them back together
            merge(A, l, m, r);

        }
        return A;
    }

    // Input: an array A[0..n-1]
    // Input: an integer l, the left-most index
    // Input: an integer m, the middle index
    // Input: an integer r, the right-most index
    public static void merge(int[] A, int l, int m, int r) {
        // Create a temporary array B
        int[] B = new int[r - l + 1];

        int i = 0; // First unused index of B
        int s = l; // Top of the left stack
        int t = m + 1; // Top of the right stack

        // Keep taking the smallest value as long as both
        // stacks still have values
        while (s <= m && t <= r) {
            if (A[s] <= A[t]) {
                // Take from left stack
                B[i] = A[s];
                s++;
            }
            else {
                // Take from right stack
                B[i] = A[t];
                t++;
            }
            i++;
        }

        // Copy the remaining elements from the left or right stack, if any
        while (s <= m) {
            B[i] = A[s];
            s++;
            i++;
        }
        while (t <= r) {
            B[i] = A[t];
            t++;
            i++;
        }

        // Sorting is now complete. Just copy the newly sorted part over the original
        for (i = 0; i < B.length; i++) {
            A[l + i] = B[i];
        }
    }
}