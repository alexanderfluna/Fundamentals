// Alexander Luna | Iterative Deepening A* algorithm (IDA*)
#include <iostream>
#include <vector>
#include <algorithm>
#include <limits>
using namespace std;

// A node is composed of a(n)
//   f_score
        /* In the IDA* algorithm, f_score is a heuristic function used to 
        estimate the cost of reaching the goal state from a given state. It 
        is a combination of two other heuristic functions g(n) and h(n).
        Simply it is f(n) = g(n) + h(n). */
//   pointer to its parent node
//   vector of pointers to its children nodes (algo not limited to bst)
struct Node {
    int f_score; // already computed for us in this problem
    Node* parent;
    vector<Node*> children;
    Node(int h, Node* p) : f_score(h), parent(p) {}
};

// Function declarations
void ida_star(Node* start, Node* goal);
Node* ida_star_pruning(Node* start, Node* goal, int threshold);
void printPath(Node* node);
void printTree(Node* node, int depth = 0);

int main() {
    // First we load the tree with the nodes

    // Row 1: 
    // 2
    Node* start = new Node(2, nullptr);

    // Row 2: 
    // 4, 5
    Node* n2 = new Node(4, start);
    Node* n3 = new Node(5, start);
    start->children.push_back(n3);
    start->children.push_back(n2);

    // Row 3: 
    // 5, 4 | 6, 6
    Node* n4 = new Node(5, n2);
    Node* n5 = new Node(4, n2);
    n2->children.push_back(n5);
    n2->children.push_back(n4);

    Node* n6 = new Node(6, n3);
    Node* n7 = new Node(6, n3);
    n3->children.push_back(n7);
    n3->children.push_back(n6);

    // Row 4: 
    // 7, 8 | 8, 7 | 6, 8 | 7, 9
    Node* n8 = new Node(7, n4);
    Node* n9 = new Node(8, n4);
    n4->children.push_back(n9);
    n4->children.push_back(n8);

    Node* n10 = new Node(8, n5);
    Node* n11 = new Node(7, n5);
    n5->children.push_back(n11);
    n5->children.push_back(n10);

    Node* n12 = new Node(6, n6);
    Node* n13 = new Node(8, n6);
    n6->children.push_back(n13);
    n6->children.push_back(n12);

    Node* n14 = new Node(7, n7);
    Node* n15 = new Node(9, n7);
    n7->children.push_back(n15);
    n7->children.push_back(n14);

    // Print the structure of the tree
    cout << "Tree structure:" << endl;
    printTree(start);

    // Uncomment the goal state you would like to use:
    //Node* goal = n2;
    //Node* goal = n3;
    //Node* goal = n4;
    //Node* goal = n5;
    //Node* goal = n6;
    //Node* goal = n7;
    //Node* goal = n8;
    //Node* goal = n9;
    //Node* goal = n10;
    //Node* goal = n11;
    //Node* goal = n12;
    //Node* goal = n12;
    //Node* goal = n13;
    //Node* goal = n14;
    Node* goal = n15;

    // Call ida_star algorithm with start node and goal node
    ida_star(start, goal);

    return 0;
}

// Function to print the tree structure
void printTree(Node* node, int depth) {
    if (node == nullptr)
        return;
    cout << string(depth * 4, ' ') << node->f_score << endl;
    for (Node* child : node->children)
        printTree(child, depth + 1);
}

// Input: start node
// Input: goal node
void ida_star(Node* start, Node* goal) {

    // Set the threshold to the f_score of the start node
    int threshold = start->f_score;

    // Continue until we reach the goal node or return nullptr
    while (true) {

        // Call ida_star_pruning helper function, which
        // returns the node with the smallest f_score
        // still greater than the threshold or returns nullptr
        Node* result = ida_star_pruning(start, goal, threshold);

        // If the returned node is the goal node, print the path to it
        if (result == goal) {
            cout << "\n"  << "Path found for node with f-score: " << goal->f_score << endl;
            printPath(result);
            cout << endl;
            return;
        }

        // If we returned nullptr, that path does not exist
        if (result == nullptr) {
            cout << "No path found." << endl;
            return;
        }

        // Set the threshold to the f_score of the returned node
        threshold = result->f_score;
    }
}

// Input: start node
// Input: goal node
// Input: threshold
// Output: node with the smallest f_score still greater than the threshold
Node* ida_star_pruning(Node* start, Node* goal, int threshold) {

    // If the current node is the goal node, return it
    if (start == goal)
        return start;

    // If the f_score of the current node is less than the threshold, return nullptr
    if (start->f_score < threshold)
        return nullptr;

    // Stores the min f_score; initially set to INT_MAX
    int min_f_score = numeric_limits<int>::max();

    // Node to be returned; initially set to nullptr
    Node* min_child = nullptr;

    // Iterate through the current node's children nodes
    for (Node* child : start->children) {

        // Recursively call ida_star_pruning for each child
        Node* result = ida_star_pruning(child, goal, threshold);

        // If any one of the child nodes are the goal node, return it
        if (result == goal)
            return goal;

        // Find which child node has the smallest f_score
        if (result != nullptr && result->f_score < min_f_score) {
            min_f_score = result->f_score;
            min_child = result;
        }
    }

    // Returns the node with the smallest f_score still greater than the threshold
    return min_child;
}

// Function to print the path from  the start node to goal node
void printPath(Node* node) {
    if (node == nullptr)
        return;

    // Recursively call the parent node of the 
    // goal node until we reach the root
    printPath(node->parent);

    cout << node->f_score << " ";
}