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

    public void DFS(int startVertex)
    {
        HashSet<int> visited = new HashSet<int>();
        Console.WriteLine("DFS Traversal:");

        DFSRecursive(startVertex, visited);
    }

    private void DFSRecursive(int currentVertex, HashSet<int> visited)
    {
        visited.Add(currentVertex);
        Console.Write(currentVertex + " ");

        foreach (int neighbor in adjacencyList[currentVertex].Where(n => !visited.Contains(n)))
        {
            DFSRecursive(neighbor, visited);
        }
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

        // Perform DFS starting from vertex 0
        graph.DFS(0);
    }
}
