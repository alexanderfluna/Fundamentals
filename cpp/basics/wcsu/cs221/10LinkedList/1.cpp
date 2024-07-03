#include <iostream>
using namespace std;
 
class node {
public:
    int data;
    node* next;
 
    // A constructor is called here
    node(int value)
    {
 
        // It automatic assigns the
        // value to the data
        data = value;
 
        // Next pointer is pointed to NULL
        next = NULL;
    }
};
 
// Function to insert an element
// at head position
void insertathead(node*& head, int val)
{
    node* n = new node(val);
    n->next = head;
    head = n;
}
 
// Function to insert a element
// at a specified position
void insertafter(node* head, int key, int val)
{
    node* n = new node(val);
    if (key == head->data) {
        n->next = head->next;
        head->next = n;
        return;
    }
 
    node* temp = head;
    while (temp->data != key) {
        temp = temp->next;
        if (temp == NULL) {
            return;
        }
    }
    n->next = temp->next;
    temp->next = n;
}
 
// Function to insert an
// element at the end
void insertattail(node*& head, int val)
{
    node* n = new node(val);
    if (head == NULL) {
        head = n;
        return;
    }
 
    node* temp = head;
    while (temp->next != NULL) {
        temp = temp->next;
    }
    temp->next = n;
}

// Given a reference (pointer to pointer)
// to the head of a list and a key, deletes
// the first occurrence of key in linked list
void deleteNodeValue(node** head_ref, int key)
{
 
    // Store head node
    node* temp = *head_ref;
    node* prev = NULL;
 
    // If head node itself holds
    // the key to be deleted
    if (temp != NULL && temp->data == key) {
       
      // Changed head
        *head_ref = temp->next;
       
      // free old head
        delete temp;
        return;
    }
 
    // Else Search for the key to be
    // deleted, keep track of the
    // previous node as we need to
    // change 'prev->next'
    else {
        while (temp != NULL && temp->data != key) {
            prev = temp;
            temp = temp->next;
        }
 
        // If key was not present in linked list
        if (temp == NULL)
            return;
 
        // Unlink the node from linked list
        prev->next = temp->next;
 
        // Free memory
        delete temp;
    }
}

// Given a reference (pointer to pointer) to
// the head of a list and a position, deletes
// the node at the given position
void deleteNodePosition(node** head_ref, int position)
{
  
    // If linked list is empty
    if (*head_ref == NULL)
        return;
  
    // Store head node
    node* temp = *head_ref;
  
    // If head needs to be removed
    if (position == 0) {
  
        // Change head
        *head_ref = temp->next;
  
        // Free old head
        free(temp);
        return;
    }
  
    // Find previous node of the node to be deleted
    for (int i = 0; temp != NULL && i < position - 2; i++)
        temp = temp->next;
  
    // If position is more than number of nodes
    if (temp == NULL || temp->next == NULL)
        return;
  
    // Node temp->next is the node to be deleted
    // Store pointer to the next of node to be deleted
    node* next = temp->next->next;
  
    // Unlink the node from linked list
    free(temp->next); // Free memory
  
    // Unlink the deleted node from list
    temp->next = next;
}
 
// Function to print the
// singly linked list
void print(node*& head)
{
    node* temp = head;
 
    while (temp != NULL) {
        cout << temp->data << " -> ";
        temp = temp->next;
    }
    cout << "NULL" << "\n" << endl;
}
 
// Main function
int main()
{
 
    // Declaring an empty linked list
    node* head = NULL;
 
    insertathead(head, 1);
    insertathead(head, 0);
    cout << "After insertion at head: ";
    print(head);
 
    insertattail(head, 4);
    insertattail(head, 5);
    cout << "After insertion at tail: ";
    print(head);
 
    insertafter(head, 1, 2);
    insertafter(head, 2, 3);
    cout << "After insertion at a given position: ";
    print(head);

    deleteNodeValue(&head, 2);
    deleteNodeValue(&head, 5);
    cout << "After node value deletion: ";
    print(head);

    deleteNodePosition(&head, 0);
    deleteNodePosition(&head, 1);
    cout << "After node position deletion: ";
    print(head);
    return 0;
}