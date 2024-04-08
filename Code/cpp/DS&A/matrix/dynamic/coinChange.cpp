#include <iostream>
#include <vector>

using namespace std;

// Function to count the number of ways to make change for a given amount
int countWaysToMakeChange(const vector<int>& coins, int amount) {
    int coins_size = coins.size();
    vector<vector<int>> matrix(coins_size + 1, vector<int>(amount + 1, 0));

    // Base case: There is one way to make change for amount 0 (no coins used)
    for (int i = 0; i <= coins_size; ++i) {
        matrix[i][0] = 1;
    }

    // Fill the matrix table to count the ways to make change
    for (int i = 1; i <= coins_size; ++i) {
        for (int j = 1; j <= amount; ++j) {
            // Include the current coin or exclude it
            matrix[i][j] = matrix[i - 1][j] + (j >= coins[i - 1] ? matrix[i][j - coins[i - 1]] : 0);
        }
    }

    return matrix[coins_size][amount];
}

int main() {
    vector<int> coins = { 25, 10, 5, 1 }; // Quarters, Dimes, Nickels, Pennies

    int amount = 67; // Example: 67 cents

    int ways = countWaysToMakeChange(coins, amount);

    cout << "Number of ways to make change for " << amount << " cents using given coins: " << ways << endl;

    return 0;
}
