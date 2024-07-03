#include <stdio.h>
#include <stdlib.h>

// Define the structure of a node in the binary search tree
struct Node {
    int data;
    struct Node* left;
    struct Node* right;
};

// Function to create a new node
struct Node* createNode(int data) {
    struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
    newNode->data = data;
    newNode->left = NULL;
    newNode->right = NULL;
    return newNode;
}

// Function to insert a new node into the BST
struct Node* insert(struct Node* root, int data) {
    if (root == NULL) {
        return createNode(data);
    } else {
        if (data <= root->data) {
            root->left = insert(root->left, data);
        } else {
            root->right = insert(root->right, data);
        }
        return root;
    }
}

// Function to perform preorder traversal of the BST
void preorder(struct Node* root) {
    if (root == NULL) {
        return;
    }
    printf("%d ", root->data);
    preorder(root->left);
    preorder(root->right);
}

// Function to perform inorder traversal of the BST
void inorder(struct Node* root) {
    if (root == NULL) {
        return;
    }
    inorder(root->left);
    printf("%d ", root->data);
    inorder(root->right);
}

// Function to perform postorder traversal of the BST
void postorder(struct Node* root) {
    if (root == NULL) {
        return;
    }
    postorder(root->left);
    postorder(root->right);
    printf("%d ", root->data);
}

// Function to deallocate memory for nodes of the BST
void deallocate(struct Node* root) {
    if (root == NULL) {
        return;
    }
    deallocate(root->left);
    deallocate(root->right);
    free(root);
}

int main() {
    struct Node* root = NULL;
    
    // Insert elements into the BST
    root = insert(root, 10);
    root = insert(root, 5);
    root = insert(root, 15);
    root = insert(root, 3);
    root = insert(root, 7);
    root = insert(root, 12);
    root = insert(root, 18);
    
    // Perform preorder traversal
    printf("Preorder traversal: ");
    preorder(root);
    printf("\n");
    
    // Perform inorder traversal
    printf("Inorder traversal: ");
    inorder(root);
    printf("\n");
    
    // Perform postorder traversal
    printf("Postorder traversal: ");
    postorder(root);
    printf("\n");

    // Deallocate memory for the nodes of the BST
    deallocate(root);

    return 0;
}
