#include <iostream>
#include <vector>

using namespace std;

// Function to find the length of the longest common subsequence
int longestCommonSubsequenceLength(const string& str1, const string& str2) {
    int str1_length = str1.length();
    int str2_length = str2.length();

    vector<vector<int>> matrix(str1_length + 1, vector<int>(str2_length + 1, 0));

    for (int i = 1; i <= str1_length; ++i) {
        for (int j = 1; j <= str2_length; ++j) {
            if (str1[i - 1] == str2[j - 1]) {
                matrix[i][j] = matrix[i - 1][j - 1] + 1;
            }
            else {
                matrix[i][j] = max(matrix[i - 1][j], matrix[i][j - 1]);
            }
        }
    }

    return matrix[str1_length][str2_length];
}

// Function to construct and return the longest common subsequence
string longestCommonSubsequence(const string& str1, const string& str2) {
    int str1_length = str1.length();
    int str2_length = str2.length();

    // Create matrix of 0s
    vector<vector<int>> matrix(str1_length + 1, vector<int>(str2_length + 1, 0));

    for (int i = 1; i <= str1_length; ++i) {
        for (int j = 1; j <= str2_length; ++j) {
            if (str1[i - 1] == str2[j - 1]) {
                matrix[i][j] = matrix[i - 1][j - 1] + 1;
            }
            else {
                matrix[i][j] = max(matrix[i - 1][j], matrix[i][j - 1]);
            }
        }
    }

    // Reconstruct the LCS
    int length = matrix[str1_length][str2_length];
    string lcs(length, ' ');

    int i = str1_length, j = str2_length;
    while (i > 0 && j > 0) {
        if (str1[i - 1] == str2[j - 1]) {
            lcs[--length] = str1[i - 1];
            i--;
            j--;
        }
        else if (matrix[i - 1][j] > matrix[i][j - 1]) {
            i--;
        }
        else {
            j--;
        }
    }

    return lcs;
}

int main() {
    string str1, str2;

    cout << "Enter the first sequence: ";
    cin >> str1;

    cout << "Enter the second sequence: ";
    cin >> str2;

    int length = longestCommonSubsequenceLength(str1, str2);
    cout << "Length of Longest Common Subsequence: " << length << endl;

    string lcs = longestCommonSubsequence(str1, str2);
    cout << "Longest Common Subsequence: " << lcs << endl;

    return 0;
}
