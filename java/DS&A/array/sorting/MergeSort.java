public class MergeSort {
    public static void main(String[] args) {
        int[] arr = {12, 11, 13, 5, 6, 7};
        System.out.println("Original array:");
        for (int i : arr){
            System.out.print(i + " ");
        }

        mergeSort(arr, 0, arr.length-1);
        System.out.println("\n Sorted array:");
        for (int i : arr){
            System.out.print(i + " ");
        }
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
