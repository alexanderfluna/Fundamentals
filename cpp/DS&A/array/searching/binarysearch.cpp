#include <iostream>
#include <vector>

// Binary search function
int binarySearch(const std::vector<int>& arr, int target) {
    int left = 0;
    int right = arr.size() - 1;

    while (left <= right) {
        int mid = left + (right - left) / 2;

        // Check if the target is present at the middle
        if (arr[mid] == target) {
            return mid;
        }

        // If the target is greater, ignore the left half
        if (arr[mid] < target) {
            left = mid + 1;
        }
        // If the target is smaller, ignore the right half
        else {
            right = mid - 1;
        }
    }

    // If the target is not present in the array
    return -1;
}

int main() {
    std::vector<int> sortedArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    int target = 5;

    // Perform binary search
    int result = binarySearch(sortedArray, target);

    if (result != -1) {
        std::cout << "Element " << target << " found at index " << result << std::endl;
    } else {
        std::cout << "Element " << target << " not found in the array" << std::endl;
    }

    return 0;
}
