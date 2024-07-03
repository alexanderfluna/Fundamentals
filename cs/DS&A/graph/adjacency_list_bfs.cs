using System;
using System.Collections.Generic;
using System.Linq;

class Graph
{
    private Dictionary<int, List<int>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<int, List<int>>();
    }

    public void AddEdge(int vertex, int neighbor)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<int>();
        }

        adjacencyList[vertex].Add(neighbor);

        // For undirected graph, add the reverse edge
        if (!adjacencyList.ContainsKey(neighbor))
        {
            adjacencyList[neighbor] = new List<int>();
        }

        adjacencyList[neighbor].Add(vertex);
    }

    public void BFS(int startVertex)
    {
        Queue<int> queue = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();

        // Enqueue the start vertex and mark it as visited
        queue.Enqueue(startVertex);
        visited.Add(startVertex);

        Console.WriteLine("BFS Traversal:");

        while (queue.Count > 0)
        {
            int currentVertex = queue.Dequeue();
            Console.Write(currentVertex + " ");

            // Enqueue all unvisited neighbors
            foreach (int neighbor in adjacencyList[currentVertex].Where(n => !visited.Contains(n)))
            {
                queue.Enqueue(neighbor);
                visited.Add(neighbor);
            }
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph();

        // Adding edges to the graph
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 5);
        graph.AddEdge(2, 6);

        // Perform BFS starting from vertex 0
        graph.BFS(0);
    }
}
