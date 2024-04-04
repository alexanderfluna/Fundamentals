// Alexander Luna | Assignment 1 | Problem1a.cpp
#include <iostream>
using namespace std;

// Arrays will be of size 100 x 100
const int SIZE = 100;

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


int main() {
    int iterations = 100000;
    clock_t start, end;

    // Measure time used by static array allocation
    start = clock();
    for (int i = 0; i < iterations; ++i)
        static_array_declaration();
    end = clock();
    cout << "Time used by static array allocation: " << double(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Measure time used by stack array allocation
    start = clock();
    for (int i = 0; i < iterations; ++i)
        stack_array_declaration();
    end = clock();
    cout << "\nTime used by stack array allocation: " << double(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Measure time used by heap array allocation with deallocation
    start = clock();
    for (int i = 0; i < iterations; ++i)
        heap_array_declaration();
    end = clock();
    cout << "\nTime used by heap array allocation with deallocation: " << double(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    return 0;
}

/*
This code creates three functions: one for statically declaring large 2D arrays, one for creating them on the stack, and one for creating them on the heap. It then measures the time taken for each function to execute by calling them 100,000 times each. Finally, it outputs the measured times.

Explanation of results:

Static array declaration: Static allocation of memory is typically very fast because the memory for static arrays is allocated at compile-time. Since the memory is allocated once during program initialization, the overhead of repeated allocation is avoided. Therefore, this should be the fastest among the three methods.

Stack array creation: Stack allocation is also fast as it involves incrementing the stack pointer, but it may be slightly slower than static allocation due to the overhead of stack management. However, since stack memory is automatically deallocated when the function exits, there is no need to explicitly free memory, which may make it faster compared to heap allocation.

Heap array creation: Heap allocation involves more overhead because it requires dynamic memory allocation and deallocation, which involves finding a suitable block of memory and updating memory management data structures. Therefore, heap allocation is generally slower compared to stack and static allocation. Additionally, since heap-allocated memory must be manually deallocated to avoid memory leaks, this method also incurs the overhead of explicit deallocation.

In summary, you would expect static array declaration to be the fastest, followed by stack array creation, and then heap array creation to be the slowest.
*/