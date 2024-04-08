#include <iostream>
#include <vector>

using namespace std;

bool isSafe(int row, int col, const vector<int>& placement) {
    for (int i = 0; i < row; ++i) {
        if (placement[i] == col || abs(placement[i] - col) == abs(i - row)) {
            return false;
        }
    }
    return true;
}

void nQueens(int n, int row, vector<int>& placement, vector<vector<string>>& solutions) {
    if (row == n) {
        // Found a solution, construct the chessboard configuration
        vector<string> solution(n, string(n, '.'));

        for (int i = 0; i < n; ++i) {
            solution[i][placement[i]] = 'Q';
        }

        solutions.push_back(solution);
        return;
    }

    for (int col = 0; col < n; ++col) {
        if (isSafe(row, col, placement)) {
            placement[row] = col;
            nQueens(n, row + 1, placement, solutions);
        }
    }
}

vector<vector<string>> nQueens(int n) {
    vector<vector<string>> solutions;
    vector<int> placement(n, 0);  // Store the column position of each queen in each row
    nQueens(n, 0, placement, solutions);
    return solutions;
}

int main() {
    int n;
    cout << "Enter the number of queens (n): ";
    cin >> n;

    vector<vector<string>> solutions = nQueens(n);

    cout << "Number of solutions: " << solutions.size() << endl;
    for (const auto& solution : solutions) {
        for (const string& row : solution) {
            cout << row << endl;
        }
        cout << endl;
    }

    return 0;
}
