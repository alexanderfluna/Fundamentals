#include <iostream>
#include <string>

template <typename T, int size>
class Array {
private:
    T elements[size];

public:
    // Constructor
    Array() {}

    // Method to get elements from the user
    void getElementsFromUser() {
        for (int i = 0; i < size; ++i) {
            std::cout << "Element " << i << ": ";
            std::cin >> elements[i];
        }
    }

    // Method to display the array
    void display() {
        std::cout << "Array elements: ";
        for (int i = 0; i < size; ++i) {
            std::cout << elements[i] << " ";
        }
        std::cout << std::endl;
    }

    // Method to search for an element
    bool search(const T& value) {
        for (int i = 0; i < size; ++i) {
            if (elements[i] == value) {
                std::cout << "Element found at index " << i << std::endl;
                return true;
            }
        }
        std::cout << "Element not found in the array." << std::endl;
        return false;
    }

    // Method to sort the array using insertion sort
    void insertionSort() {
        for (int i = 1; i < size; ++i) {
            T key = elements[i];
            int j = i - 1;

            // Move elements that are greater than key to one position ahead
            while (j >= 0 && elements[j] > key) {
                elements[j + 1] = elements[j];
                --j;
            }

            // Place the key at its correct position
            elements[j + 1] = key;
        }
    }
};

int main() {
    const int ARRAY_SIZE = 3;

    // Example usage for an integer array
    Array<int, ARRAY_SIZE> intArray;

    // Get integer elements from the user
    std::cout << "Enter " << ARRAY_SIZE << " elements for the integer array:" << std::endl;
    intArray.getElementsFromUser();

    // Display integer array before and after insertion sort
    intArray.display();
    intArray.insertionSort();
    intArray.display();

    // Search for an element in the integer array
    int intSearchValue;
    std::cout << "Enter the integer element to search: ";
    std::cin >> intSearchValue;
    intArray.search(intSearchValue);

    // Example usage for a string array
    Array<std::string, ARRAY_SIZE> stringArray;

    // Get string elements from the user
    std::cout << "Enter " << ARRAY_SIZE << " elements for the string array:" << std::endl;
    stringArray.getElementsFromUser();

    // Display string array before and after insertion sort
    stringArray.display();
    stringArray.insertionSort();
    stringArray.display();

    // Search for an element in the string array
    std::string stringSearchValue;
    std::cout << "Enter the string element to search: ";
    std::cin >> stringSearchValue;
    stringArray.search(stringSearchValue);

    return 0;
}