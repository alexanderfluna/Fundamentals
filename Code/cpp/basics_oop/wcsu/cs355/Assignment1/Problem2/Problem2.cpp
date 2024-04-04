#include <iostream>
#include <ctime>
#include <cstdlib>

using namespace std;

const int SIZE = 100;
const int NUM_MULTIPLICATIONS = 10000;

// Function to initialize a matrix with random values
void initializeMatrix(int matrix[][SIZE]) {
    for (int i = 0; i < SIZE; ++i) {
        for (int j = 0; j < SIZE; ++j) {
            matrix[i][j] = rand() % 100; // Random number between 0 and 99
        }
    }
}

// Function to initialize a heap matrix with random values
void initializeHeapMatrix(int** matrix) {
    for (int i = 0; i < SIZE; ++i) {
        for (int j = 0; j < SIZE; ++j) {
            matrix[i][j] = rand() % 100; // Random number between 0 and 99
        }
    }
}

// Function to perform matrix multiplication for static and stack matrices
void multiplyMatrix(int matrix1[][SIZE], int matrix2[][SIZE], int result[][SIZE]) {
    for (int i = 0; i < SIZE; ++i) {
        for (int j = 0; j < SIZE; ++j) {
            result[i][j] = 0;
            for (int k = 0; k < SIZE; ++k) {
                result[i][j] += matrix1[i][k] * matrix2[k][j];
            }
        }
    }
}

// Function to perform matrix multiplication for heap-allocated arrays
void multiplyHeapMatrix(int** matrix1, int** matrix2, int** result) {
    for (int i = 0; i < SIZE; ++i) {
        for (int j = 0; j < SIZE; ++j) {
            result[i][j] = 0;
            for (int k = 0; k < SIZE; ++k) {
                result[i][j] += matrix1[i][k] * matrix2[k][j];
            }
        }
    }
}

int main() {
    clock_t start, end;

    // Allocate memory for matrices
    static int staticMatrix[SIZE][SIZE];
    int stackMatrix[SIZE][SIZE];
    int** heapMatrix1 = new int* [SIZE];
    int** heapMatrix2 = new int* [SIZE];
    for (int i = 0; i < SIZE; ++i) {
        heapMatrix1[i] = new int[SIZE];
        heapMatrix2[i] = new int[SIZE];
    }

    // Initialize matrices
    srand(time(nullptr)); // Seed for random numbers
    initializeMatrix(staticMatrix);
    initializeMatrix(stackMatrix);
    initializeHeapMatrix(heapMatrix1);
    initializeHeapMatrix(heapMatrix2);

    // Measure time for static matrix multiplication
    start = clock();
    for (int i = 0; i < NUM_MULTIPLICATIONS; ++i) {
        multiplyMatrix(staticMatrix, staticMatrix, staticMatrix);
    }
    end = clock();
    cout << "Time for static matrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Measure time for stack matrix multiplication
    start = clock();
    for (int i = 0; i < NUM_MULTIPLICATIONS; ++i) {
        multiplyMatrix(stackMatrix, stackMatrix, stackMatrix);
    }
    end = clock();
    cout << "Time for stack matrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Measure time for heap matrix multiplication
    start = clock();
    for (int i = 0; i < NUM_MULTIPLICATIONS; ++i) {
        multiplyHeapMatrix(heapMatrix1, heapMatrix2, heapMatrix1); // Reusing heapMatrix1 for the result
    }
    end = clock();
    cout << "Time for heap matrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Deallocate memory for heap matrices
    for (int i = 0; i < SIZE; ++i) {
        delete[] heapMatrix1[i];
        delete[] heapMatrix2[i];
    }
    delete[] heapMatrix1;
    delete[] heapMatrix2;

    return 0;
}
