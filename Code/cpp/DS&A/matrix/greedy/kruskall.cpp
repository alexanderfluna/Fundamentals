#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

// Structure to represent an edge in the graph
struct Edge {
    int src, dest, weight;
};

// Structure to represent a disjoint set
struct DisjointSet {
    vector<int> parent, rank;

    DisjointSet(int n) {
        parent.resize(n);
        rank.resize(n, 0);
        // Initialize each element as a separate set with rank 0
        for (int i = 0; i < n; ++i) {
            parent[i] = i;
        }
    }

    // Find the set to which an element belongs (with path compression)
    int find(int x) {
        if (parent[x] != x) {
            parent[x] = find(parent[x]);
        }
        return parent[x];
    }

    // Union of two sets (with rank optimization)
    void unionSets(int x, int y) {
        int rootX = find(x);
        int rootY = find(y);

        if (rootX != rootY) {
            if (rank[rootX] < rank[rootY]) {
                parent[rootX] = rootY;
            }
            else if (rank[rootX] > rank[rootY]) {
                parent[rootY] = rootX;
            }
            else {
                // If ranks are the same, arbitrarily choose one as the root
                parent[rootX] = rootY;
                rank[rootY]++;
            }
        }
    }
};

// Comparison function to sort edges by weight in ascending order
bool compareEdges(const Edge& a, const Edge& b) {
    return a.weight < b.weight;
}

// Kruskal's algorithm to find the minimum spanning tree
void kruskal(vector<Edge>& edges, int numVertices) {
    // Sort the edges by weight in ascending order
    sort(edges.begin(), edges.end(), compareEdges);

    // Initialize a disjoint set to keep track of connected components
    DisjointSet disjointSet(numVertices);

    // Resulting minimum spanning tree
    vector<Edge> minimumSpanningTree;

    // Iterate through sorted edges
    for (const Edge& edge : edges) {
        int rootSrc = disjointSet.find(edge.src);
        int rootDest = disjointSet.find(edge.dest);

        // If including this edge doesn't create a cycle, add it to the MST
        if (rootSrc != rootDest) {
            minimumSpanningTree.push_back(edge);
            disjointSet.unionSets(rootSrc, rootDest);
        }
    }

    // Print the minimum spanning tree
    for (const Edge& edge : minimumSpanningTree) {
        cout << edge.src << " -- " << edge.dest << " : " << edge.weight << "\n";
    }
}

int main() {
    // Example usage
    int numVertices = 4;
    vector<Edge> edges = {
        {0, 1, 1},
        {0, 2, 3},
        {1, 2, 2},
        {1, 3, 4},
        {2, 3, 5}
    };

    kruskal(edges, numVertices);

    return 0;
}
