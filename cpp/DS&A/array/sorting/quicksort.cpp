#include <iostream>
#include <vector>

// Partition function for Quicksort
int partition(std::vector<int>& arr, int low, int high) {
    int pivot = arr[high]; // Choose the rightmost element as the pivot
    int i = low - 1; // Index of smaller element

    for (int j = low; j < high; j++) {
        // If the current element is smaller than or equal to the pivot
        if (arr[j] <= pivot) {
            i++;

            // Swap arr[i] and arr[j]
            std::swap(arr[i], arr[j]);
        }
    }

    // Swap arr[i + 1] and arr[high] (put the pivot in its correct position)
    std::swap(arr[i + 1], arr[high]);

    return i + 1; // Return the partition index
}

// Quicksort function
void quickSort(std::vector<int>& arr, int low, int high) {
    if (low < high) {
        // Partition the array into two halves and get the partition index
        int pi = partition(arr, low, high);

        // Recursively sort the subarrays
        quickSort(arr, low, pi - 1);
        quickSort(arr, pi + 1, high);
    }
}

// Utility function to print an array
void printArray(const std::vector<int>& arr) {
    for (int i : arr) {
        std::cout << i << " ";
    }
    std::cout << std::endl;
}

int main() {
    std::vector<int> arr = {10, 7, 8, 9, 1, 5};

    std::cout << "Original array: ";
    printArray(arr);

    // Perform quicksort
    quickSort(arr, 0, arr.size() - 1);

    std::cout << "Sorted array: ";
    printArray(arr);

    return 0;
}
