#include <iostream>
#include <vector>

using namespace std;

// Function to compute the nth Fibonacci number
int fibonacci(int n, vector<int>& memo) {
    if (n <= 1)
        return n;

    // Check if the result is already computed
    if (memo[n] != -1)
        return memo[n];

    // Compute and store the result in the memoization table
    memo[n] = fibonacci(n - 1, memo) + fibonacci(n - 2, memo);
    cout << memo[n] << " ";

    return memo[n];
}

int main() {
    int n;

    cout << "Enter the value of n: ";
    cin >> n;

    // Initialize memoization table with -1 (not computed)
    vector<int> memo(n + 1, -1);

    // Compute and print the nth Fibonacci number
    int result = fibonacci(n, memo);
    cout << "\nThe " << n << "th Fibonacci number is: " << result << endl;

    return 0;
}
