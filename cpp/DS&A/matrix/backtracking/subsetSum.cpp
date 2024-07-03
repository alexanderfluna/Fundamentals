#include <iostream>
#include <vector>

using namespace std;

bool isSubsetSum(const vector<int>& nums, int target) {
    int n = nums.size();
    vector<vector<bool>> dp(n + 1, vector<bool>(target + 1, false));

    // Base case: an empty subset can always achieve a sum of 0
    for (int i = 0; i <= n; ++i) {
        dp[i][0] = true;
    }

    // Fill the DP table
    for (int i = 1; i <= n; ++i) {
        for (int j = 1; j <= target; ++j) {
            // If the current number is greater than the target sum,
            // exclude it from the subset
            if (nums[i - 1] > j) {
                dp[i][j] = dp[i - 1][j];
            }
            else {
                // Otherwise, consider including or excluding the current number
                dp[i][j] = dp[i - 1][j] || dp[i - 1][j - nums[i - 1]];
            }
        }
    }

    // The final result is stored in the bottom-right cell of the DP table
    return dp[n][target];
}

int main() {
    int n;
    cout << "Enter the number of elements in the set: ";
    cin >> n;

    vector<int> nums(n);
    cout << "Enter the elements of the set: ";
    for (int i = 0; i < n; ++i) {
        cin >> nums[i];
    }

    int target;
    cout << "Enter the target sum: ";
    cin >> target;

    if (isSubsetSum(nums, target)) {
        cout << "Subset with the sum " << target << " exists." << endl;
    }
    else {
        cout << "No subset with the sum " << target << " exists." << endl;
    }

    return 0;
}
