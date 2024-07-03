#include <iostream>
#include <vector>
#include <limits>
#include <queue>

using namespace std;

const int INF = numeric_limits<int>::max();

// Function to perform Dijkstra's algorithm
void dijkstra(const vector<vector<int>>& graph, int start) {
    int n = graph.size();

    // Initialize distance and visited arrays
    vector<int> distance(n, INF);
    vector<bool> visited(n, false);

    // Priority queue to store vertices with their distances
    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> pq;

    // Set the distance of the starting node to 0
    distance[start] = 0;

    // Add the starting node to the priority queue
    pq.push({ 0, start });

    while (!pq.empty()) {
        // Extract the vertex with the smallest distance
        int u = pq.top().second;
        pq.pop();

        // Mark the current vertex as visited
        visited[u] = true;

        // Update the distance of the adjacent vertices
        for (int v = 0; v < n; ++v) {
            if (!visited[v] && graph[u][v] != INF) {
                int newDistance = distance[u] + graph[u][v];
                if (newDistance < distance[v]) {
                    distance[v] = newDistance;
                    pq.push({ distance[v], v });
                }
            }
        }
    }

    // Print the shortest distances from the starting node
    cout << "Shortest distances from node " << start << ":\n";
    for (int i = 0; i < n; ++i) {
        cout << "To node " << i << ": ";
        if (distance[i] == INF)
            cout << "INF";
        else
            cout << distance[i];
        cout << endl;
    }
}

int main() {
    // Example graph represented by an adjacency matrix
    vector<vector<int>> graph = {
        {0, 1, 4, INF, INF},
        {1, 0, 4, 2, 7},
        {4, 4, 0, 3, 5},
        {INF, 2, 3, 0, 4},
        {INF, 7, 5, 4, 0}
    };

    // Start Dijkstra's algorithm from node 0
    dijkstra(graph, 0);

    return 0;
}
