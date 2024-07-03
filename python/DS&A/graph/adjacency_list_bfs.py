# BFS uses a queue

# Adjacency list
graph = {
    5 : [3, 7],
    3 : [2, 4],
    7 : [8],
    2 : [],
    4 : [8],
    8: []
}

def bfs(graph, node):
    visited = []
    queue = []

    visited.append(node)
    queue.append(node)

    while queue:
        m = queue.pop(0)
        print(m, end = " ")

        for neighbor in graph[m]:
            if neighbor not in visited:
                visited.append(neighbor)
                queue.append(neighbor)

if __name__ == "__main__":
    bfs(graph, 5)