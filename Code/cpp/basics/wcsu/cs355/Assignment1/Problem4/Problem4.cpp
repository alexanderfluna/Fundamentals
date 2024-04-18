// Alexander Luna | Assignment 1 | Problem4.cpp (C++)
#include <iostream>
#include <ctime>

const int SIZE = 100;
const int ITERATIONS = 200000;

// Function using subscripting
void accessWithSubscripting(int arr[SIZE][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++)
            int value = arr[i][j];
    }
}

// Function using pointer arithmetic
void accessWithPointer(int* arr) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++)
            int value = *(arr + i * SIZE + j);
    }
}

int main() {
    clock_t start, end;
    int arr[SIZE][SIZE];

    // Initialize array with random values
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++)
            arr[i][j] = rand() % 100;
    }

    // Measure time for function using subscripting
    start = clock();
    for (int i = 0; i < ITERATIONS; i++)
        accessWithSubscripting(arr);
    end = clock();
    double time = double(end - start) / CLOCKS_PER_SEC;
    std::cout << "Time taken with subscripting: " << time << " seconds" << std::endl;

    // Measure time for function using pointer arithmetic
    start = clock();
    for (int i = 0; i < ITERATIONS; i++)
        accessWithPointer(&arr[0][0]);
    end = clock();
    time = double(end - start) / CLOCKS_PER_SEC;
    std::cout << "Time taken with pointer arithmetic: " << time << " seconds" << std::endl;

    return 0;
}
