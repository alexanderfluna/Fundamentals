#include <iostream>
#include <vector>

using namespace std;

// Function to solve the 0/1 Knapsack Problem using dynamic programming
int knapsack(const vector<int>& weights, const vector<int>& values, int capacity) {
    int weights_size = weights.size();

    // Create a 2D array to store the maximum value for different subproblems
    vector<vector<int>> matrix(weights_size + 1, vector<int>(capacity + 1, 0));

    // Fill the matrix array using bottom-up dynamic programming
    for (int i = 1; i <= weights_size; ++i) {
        for (int w = 1; w <= capacity; ++w) {
            // If the current item can fit into the knapsack
            if (weights[i - 1] <= w) {
                // Decide whether to include the current item or not
                matrix[i][w] = max(matrix[i - 1][w], values[i - 1] + matrix[i - 1][w - weights[i - 1]]);
            }
            else {
                // If the current item is too heavy, exclude it
                matrix[i][w] = matrix[i - 1][w];
            }
        }
    }

    // The value in the bottom-right cell represents the maximum value for the entire problem
    return matrix[weights_size][capacity];
}

int main() {
    // Example: Knapsack with weights and values
    vector<int> weights = { 2, 3, 4, 5 };
    vector<int> values = { 3, 4, 5, 6 };
    int capacity = 5;

    // Solve the knapsack problem and print the result
    int maxValue = knapsack(weights, values, capacity);
    cout << "Maximum value that can be obtained: " << maxValue << endl;

    return 0;
}
