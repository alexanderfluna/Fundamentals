// Alexander Luna | Assignment 1 | Problem4.cpp
#include <iostream>
#include <ctime>

const int SIZE = 100;
const int iterations = 1000000;

// Function to access array elements using subscripting
void accessArrayWithSubscript(int arr[SIZE][SIZE]) {
    for (int i = 0; i < SIZE; ++i) {
        for (int j = 0; j < SIZE; ++j)
            arr[i][j] = i + j; // Accessing elements using subscripting
    }
}

// Function to access array elements using pointer arithmetic
void accessArrayWithPointer(int* arr) {
    for (int i = 0; i < SIZE; ++i) {
        for (int j = 0; j < SIZE; ++j)
            *(arr + i * SIZE + j) = i + j; // Accessing elements using pointer arithmetic
    }
}

int main() {
    int arr[SIZE][SIZE];
    clock_t start, end;

    // Perform the first method 1,000,000 times
    start = clock();
    for (int i = 0; i < iterations; ++i)
        accessArrayWithSubscript(arr);
    end = clock();

    // Print time for the first method in milliseconds
    std::cout << "Average time taken with subscripting: " << double(end - start) / CLOCKS_PER_SEC << " seconds" << std::endl;

    // Perform the second method 1,000,000 times
    start = clock();
    for (int i = 0; i < iterations; ++i)
        accessArrayWithPointer(&arr[0][0]);
    end = clock();

    // Print time for the second method in milliseconds
    std::cout << "Average time taken with pointer arithmetic: " << double(end - start) / CLOCKS_PER_SEC << " seconds" << std::endl;

    return 0;
}
