#include <iostream>
#include <climits> // For INT_MAX and INT_MIN
using namespace std;

// Function to display the elements of an array
void displayArray(const int arr[], int size) {
    cout << "Array elements: ";
    for (int i = 0; i < size; ++i) {
        cout << arr[i] << " ";
    }
    cout << endl;
}

// Function to search for an element in an array
bool searchElement(const int arr[], int size, int target) {
    for (int i = 0; i < size; ++i) {
        if (arr[i] == target) {
            return true;
        }
    }
    return false;
}

// Function to find the maximum element in an array
int findMax(const int arr[], int size) {
    int maxElement = INT_MIN;
    for (int i = 0; i < size; ++i) {
        if (arr[i] > maxElement) {
            maxElement = arr[i];
        }
    }
    return maxElement;
}

// Function to find the minimum element in an array
int findMin(const int arr[], int size) {
    int minElement = INT_MAX;
    for (int i = 0; i < size; ++i) {
        if (arr[i] < minElement) {
            minElement = arr[i];
        }
    }
    return minElement;
}

// Function to calculate the sum of elements in an array
int calculateSum(const int arr[], int size) {
    int sum = 0;
    for (int i = 0; i < size; ++i) {
        sum += arr[i];
    }
    return sum;
}

// Function to calculate the average of elements in an array
double calculateAverage(const int arr[], int size) {
    int sum = calculateSum(arr, size);
    return static_cast<double>(sum) / size;
}

// Function to calculate the median of a sorted array
double calculateMedian(const int arr[], int size) {    
    if (size % 2 == 0) {
        // If the size of the array is even, average the middle two elements
        int middle1 = size / 2 - 1;
        int middle2 = size / 2;
        return (static_cast<double>(arr[middle1]) + arr[middle2]) / 2.0;
    } else {
        // If the size of the array is odd, the middle element is the median
        int middle = size / 2;
        return arr[middle];
    }
}

int main() {
    // Array Initialization
    int arr[] = { 1, 2, 3, 4, 5 };
    int size = sizeof(arr) / sizeof(arr[0]);

    // Array Traversal
    displayArray(arr, size);

    // Find Maximum and Minimum
    cout << "Maximum element: " << findMax(arr, size) << endl;
    cout << "Minimum element: " << findMin(arr, size) << endl;

    // Calculate Sum, Average, and Median
    cout << "Sum of elements: " << calculateSum(arr, size) << endl;
    cout << "Average of elements: " << calculateAverage(arr, size) << endl;
    cout << "Median of elements: " << calculateMedian(arr, size) << endl;

    // Search for an Element
    int target;
    cout << "Enter an element to search: ";
    cin >> target;
    if (searchElement(arr, size, target)) {
        cout << target << " found in the array.\n";
    }
    else {
        cout << target << " not found in the array.\n";
    }

    return 0;
}