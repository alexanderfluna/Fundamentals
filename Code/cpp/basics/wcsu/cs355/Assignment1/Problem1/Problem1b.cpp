// Alexander Luna | Assignment 1 | Problem1b.cpp
#include <iostream>
using namespace std;

// Arrays will be of size 100 x 100
const int SIZE = 100;

// Choose a slightly smaller number of ITERATIONS, and repeat the experiment with all four functions, with this number of ITERATIONS. 
const int ITERATIONS = 100000 - 10000;

// Declares statically two equally large square two-dimensional arrays
void static_array_declaration() {
    static int arr1[SIZE][SIZE];
    static int arr2[SIZE][SIZE];
}

// Declares two equally large square two-dimensional arrays on the stack
void stack_array_declaration() {
    int arr1[SIZE][SIZE];
    int arr2[SIZE][SIZE];
}

// Declares two equally large square two-dimensional arrays from the heap
void heap_array_declaration() {
    int** arr1 = new int* [SIZE];
    int** arr2 = new int* [SIZE];
    for (int i = 0; i < SIZE; ++i) {
        arr1[i] = new int[SIZE];
        arr2[i] = new int[SIZE];
    }
    // Deallocate memory
    for (int i = 0; i < SIZE; ++i) {
        delete[] arr1[i];
        delete[] arr2[i];
    }
    delete[] arr1;
    delete[] arr2;
}

// Declares two equally large square two-dimensional arrays from the heap without deallocation
void heap_array_declaration_without_deallocation() {
    int** arr1 = new int* [SIZE];
    int** arr2 = new int* [SIZE];
    for (int i = 0; i < SIZE; ++i) {
        arr1[i] = new int[SIZE];
        arr2[i] = new int[SIZE];
    }
}

int main() {
    clock_t start, end;

    // Measure time used by static array allocation
    start = clock();
    for (int i = 0; i < ITERATIONS; ++i)
        static_array_declaration();
    end = clock();
    cout << "Time used by static array allocation: " << double(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Measure time used by stack array allocation
    start = clock();
    for (int i = 0; i < ITERATIONS; ++i)
        stack_array_declaration();
    end = clock();
    cout << "\nTime used by stack array allocation: " << double(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Measure time used by heap array allocation with deallocation
    start = clock();
    for (int i = 0; i < ITERATIONS; ++i)
        heap_array_declaration();
    end = clock();
    cout << "\nTime used by heap array allocation with deallocation: " << double(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Measure time for heap allocation without deallocation
    int count = 0;
    start = clock();
    try {
        while (true) {
            heap_array_declaration_without_deallocation();
            count++;
        }
    }
    catch (exception) {
    }
    end = clock();
    cout << "\nHeap array allocation without deallocation: " << endl;
    cout << "The memory has exhuasted in " << double(end - start) / CLOCKS_PER_SEC << " seconds after " << count << " ITERATIONS." << endl;

    return 0;
}