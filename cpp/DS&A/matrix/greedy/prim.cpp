#include <iostream>
#include <vector>
#include <climits>

using namespace std;

// Function to find the vertex with the minimum key value, from the set of vertices not yet included in MST
int minKey(const vector<int>& key, const vector<bool>& mstSet) {
    int minKey = INT_MAX;
    int minIndex = -1;

    for (int v = 0; v < key.size(); ++v) {
        if (!mstSet[v] && key[v] < minKey) {
            minKey = key[v];
            minIndex = v;
        }
    }

    return minIndex;
}

// Function to print the constructed MST stored in parent array
void printMST(const vector<int>& parent, const vector<vector<int>>& graph) {
    cout << "Edge \tWeight\n";
    for (int i = 1; i < parent.size(); ++i) {
        cout << parent[i] << " - " << i << "\t" << graph[i][parent[i]] << "\n";
    }
}

// Prim's algorithm to find the minimum spanning tree
void prim(const vector<vector<int>>& graph) {
    int numVertices = graph.size();

    // Key values used to pick the minimum weight edge in cut
    vector<int> key(numVertices, INT_MAX);

    // To represent the constructed MST
    vector<int> parent(numVertices, -1);

    // To represent set of vertices included in MST
    vector<bool> mstSet(numVertices, false);

    // Start with the first vertex
    key[0] = 0;

    for (int count = 0; count < numVertices - 1; ++count) {
        // Pick the minimum key vertex from the set of vertices not yet included in MST
        int u = minKey(key, mstSet);

        // Mark the picked vertex as included
        mstSet[u] = true;

        // Update key value and parent index of the adjacent vertices
        for (int v = 0; v < numVertices; ++v) {
            if (graph[u][v] && !mstSet[v] && graph[u][v] < key[v]) {
                parent[v] = u;
                key[v] = graph[u][v];
            }
        }
    }

    // Print the constructed MST
    printMST(parent, graph);
}

int main() {
    // Example usage
    vector<vector<int>> graph = {
        {0, 2, 0, 6, 0},
        {2, 0, 3, 8, 5},
        {0, 3, 0, 0, 7},
        {6, 8, 0, 0, 9},
        {0, 5, 7, 9, 0}
    };

    prim(graph);

    return 0;
}
