#include <iostream>
#include <string>

template <typename T>
class BinarySearchTree {
private:
    struct Node {
        T data;
        Node* left;
        Node* right;

        Node(const T& value) : data(value), left(nullptr), right(nullptr) {}
    };

    Node* root;

    // Helper functions for recursive traversal
    void preorderTraversal(Node* node) const {
        if (node) {
            std::cout << node->data << " ";
            preorderTraversal(node->left);
            preorderTraversal(node->right);
        }
    }

    void inorderTraversal(Node* node) const {
        if (node) {
            inorderTraversal(node->left);
            std::cout << node->data << " ";
            inorderTraversal(node->right);
        }
    }

    void postorderTraversal(Node* node) const {
        if (node) {
            postorderTraversal(node->left);
            postorderTraversal(node->right);
            std::cout << node->data << " ";
        }
    }

    // Helper functions for adding and removing nodes
    Node* insert(Node* node, const T& value) {
        if (!node) {
            return new Node(value);
        }

        if (value < node->data) {
            node->left = insert(node->left, value);
        } else if (value > node->data) {
            node->right = insert(node->right, value);
        }

        return node;
    }

    Node* findMin(Node* node) const {
        while (node->left) {
            node = node->left;
        }
        return node;
    }

    Node* remove(Node* node, const T& value) {
        if (!node) {
            return nullptr;
        }

        if (value < node->data) {
            node->left = remove(node->left, value);
        } else if (value > node->data) {
            node->right = remove(node->right, value);
        } else {
            // Node with only one child or no child
            if (!node->left) {
                Node* temp = node->right;
                delete node;
                return temp;
            } else if (!node->right) {
                Node* temp = node->left;
                delete node;
                return temp;
            }

            // Node with two children: Get the inorder successor (smallest in the right subtree)
            Node* temp = findMin(node->right);
            node->data = temp->data;
            node->right = remove(node->right, temp->data);
        }

        return node;
    }

public:
    BinarySearchTree() : root(nullptr) {}

    // Public functions for user interaction
    void addNode(const T& value) {
        root = insert(root, value);
    }

    void removeNode(const T& value) {
        root = remove(root, value);
    }

    void preorderTraversal() const {
        std::cout << "Preorder Traversal: ";
        preorderTraversal(root);
        std::cout << std::endl;
    }

    void inorderTraversal() const {
        std::cout << "Inorder Traversal: ";
        inorderTraversal(root);
        std::cout << std::endl;
    }

    void postorderTraversal() const {
        std::cout << "Postorder Traversal: ";
        postorderTraversal(root);
        std::cout << std::endl;
    }
};

int main() {
    // Create a BST of integers
    BinarySearchTree<int> intTree;
    intTree.addNode(50);
    intTree.addNode(30);
    intTree.addNode(70);
    intTree.addNode(20);
    intTree.addNode(40);

    std::cout << "Binary Search Tree of Integers:" << std::endl;
    intTree.preorderTraversal();
    intTree.inorderTraversal();
    intTree.postorderTraversal();

    // Remove a node
    intTree.removeNode(30);
    std::cout << "After removing 30:" << std::endl;
    intTree.inorderTraversal();

    // Create a BST of strings
    BinarySearchTree<std::string> stringTree;
    stringTree.addNode("apple");
    stringTree.addNode("banana");
    stringTree.addNode("orange");
    stringTree.addNode("grape");

    std::cout << "\nBinary Search Tree of Strings:" << std::endl;
    stringTree.preorderTraversal();
    stringTree.inorderTraversal();
    stringTree.postorderTraversal();

    // Remove a node
    stringTree.removeNode("banana");
    std::cout << "After removing 'banana':" << std::endl;
    stringTree.inorderTraversal();

    return 0;
}
