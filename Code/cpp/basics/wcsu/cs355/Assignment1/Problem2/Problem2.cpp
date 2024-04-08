// Alexander Luna / Assignment 2 / Problem2.cpp
#include <iostream>
#include <ctime>
#include <cstdlib>
using namespace std;

const int SIZE = 100;
const int iterations = 1000000;

// Function to initialize a static or stack matrix with random values
void initialize_matrix(int matrix[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) 
            matrix[i][j] = rand() % 100; // Random number between 0 and 99
    }
}

// Function to initialize a heap matrix with random values
void initialize_matrix(int** matrix) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++) 
            matrix[i][j] = rand() % 100; // Random number between 0 and 99
    }
}

// Function to perform matrix multiplication with static and stack matrices
void matrix_times_matrix(int matrix1[][SIZE], int matrix2[][SIZE]) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++)
            matrix1[i][j] * matrix2[i][j];
    }
}

// Function to perform matrix multiplication with static or stack matrices and heap matrices
void matrix_times_matrix(int matrix1[][SIZE], int** matrix2) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++)
            matrix1[i][j] * matrix2[i][j];
    }
}

// Function to perform matrix multiplication with heap matrices
void matrix_times_matrix(int** matrix1, int** matrix2) {
    for (int i = 0; i < SIZE; i++) {
        for (int j = 0; j < SIZE; j++)
            matrix1[i][j] * matrix2[i][j];
    }
}

int main() {
    clock_t start, end;

    // Allocate memory for matrices
    static int staticMatrix[SIZE][SIZE];
    int stackMatrix[SIZE][SIZE];
    int** heapMatrix = new int* [SIZE];
    for (int i = 0; i < SIZE; i++) 
        heapMatrix[i] = new int[SIZE];

    // Initialize matrices
    srand(time(nullptr)); // Seed for random numbers
    initialize_matrix(staticMatrix);
    initialize_matrix(stackMatrix);
    initialize_matrix(heapMatrix);

    // Case 1: staticMatrix * staticMatrix
    start = clock();
    for (int i = 0; i < iterations; i++)
        matrix_times_matrix(staticMatrix, staticMatrix);
    end = clock();
    cout << "Case 1: Time for staticMatrix * staticMatrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Case 2: staticMatrix * stackMatrix
    start = clock();
    for (int i = 0; i < iterations; i++)
        matrix_times_matrix(staticMatrix, stackMatrix);
    end = clock();
    cout << "Case 2: Time for staticMatrix * stackMatrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Case 3: stackMatrix * heapMatrix
    start = clock();
    for (int i = 0; i < iterations; i++)
        matrix_times_matrix(stackMatrix, heapMatrix);
    end = clock();
    cout << "Case 3: Time for stackMatrix * heapMatrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Case 4: stackMatrix * stackMatrix
    start = clock();
    for (int i = 0; i < iterations; i++) 
        matrix_times_matrix(stackMatrix, stackMatrix);
    end = clock();
    cout << "Case 4: Time for stackMatrix * stackMatrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Case 5: stackMatrix * heapMatrix
    start = clock();
    for (int i = 0; i < iterations; i++)
        matrix_times_matrix(stackMatrix, heapMatrix);
    end = clock();
    cout << "Case 5: Time for stackMatrix * heapMatrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Case 6: heapMatrix * heapMatrix
    start = clock();
    for (int i = 0; i < iterations; i++) 
        matrix_times_matrix(heapMatrix, heapMatrix);
    end = clock();
    cout << "Case 6: Time for heapMatrix * heapMatrix multiplication: " << (double)(end - start) / CLOCKS_PER_SEC << " seconds" << endl;

    // Deallocate memory for heap matrix
    for (int i = 0; i < SIZE; i++) 
        delete[] heapMatrix[i];
    delete[] heapMatrix;

    return 0;
}
