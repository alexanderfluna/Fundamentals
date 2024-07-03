#include <iostream>
#include <vector>
#include <queue>
#include <unordered_set>

class Graph {
public:
    Graph(int vertices);
    void addEdge(int v, int w);
    void BFS(int startVertex);

private:
    int vertices;
    std::vector<std::vector<int>> adjacencyList;
};

Graph::Graph(int vertices) : vertices(vertices) {
    adjacencyList.resize(vertices);
}

void Graph::addEdge(int v, int w) {
    adjacencyList[v].push_back(w);
    adjacencyList[w].push_back(v);
}

void Graph::BFS(int startVertex) {
    std::vector<bool> visited(vertices, false);
    std::queue<int> q;

    visited[startVertex] = true;
    q.push(startVertex);

    while (!q.empty()) {
        int currentVertex = q.front();
        std::cout << currentVertex << " ";
        q.pop();

        for (int adjacentVertex : adjacencyList[currentVertex]) {
            if (!visited[adjacentVertex]) {
                visited[adjacentVertex] = true;
                q.push(adjacentVertex);
            }
        }
    }

    std::cout << std::endl;
}

int main() {
    // Create a simple graph
    Graph myGraph(6);

    myGraph.addEdge(0, 1);
    myGraph.addEdge(0, 2);
    myGraph.addEdge(1, 3);
    myGraph.addEdge(2, 4);
    myGraph.addEdge(2, 5);

    std::cout << "BFS starting from vertex 0: ";
    myGraph.BFS(0);

    return 0;
}
