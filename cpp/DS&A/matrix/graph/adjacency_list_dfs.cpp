#include <iostream>
#include <vector>
#include <unordered_set>

class Graph {
public:
    Graph(int vertices);
    void addEdge(int v, int w);
    void DFS(int startVertex);

private:
    int vertices;
    std::vector<std::vector<int>> adjacencyList;

    void DFSUtil(int vertex, std::unordered_set<int>& visited);
};

Graph::Graph(int vertices) : vertices(vertices) {
    adjacencyList.resize(vertices);
}

void Graph::addEdge(int v, int w) {
    adjacencyList[v].push_back(w);
    adjacencyList[w].push_back(v);
}

void Graph::DFSUtil(int vertex, std::unordered_set<int>& visited) {
    visited.insert(vertex);
    std::cout << vertex << " ";

    for (int adjacentVertex : adjacencyList[vertex]) {
        if (visited.find(adjacentVertex) == visited.end()) {
            DFSUtil(adjacentVertex, visited);
        }
    }
}

void Graph::DFS(int startVertex) {
    std::unordered_set<int> visited;

    std::cout << "DFS starting from vertex " << startVertex << ": ";
    DFSUtil(startVertex, visited);

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

    myGraph.DFS(0);

    return 0;
}
