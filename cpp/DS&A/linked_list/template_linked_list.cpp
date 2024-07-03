#include <iostream>

template <typename T>
class LinkedList {
private:
    struct Node {
        T data;
        Node* next;
        Node(const T& value) : data(value), next(nullptr) {}
    };

    Node* head;

public:
    LinkedList() : head(nullptr) {}

    ~LinkedList() {
        while (head) {
            Node* temp = head;
            head = head->next;
            delete temp;
        }
    }

    // Append an element to the start
    void appendToStart(const T& value) {
        Node* newNode = new Node(value);
        newNode->next = head;
        head = newNode;
    }

    // Append an element to the end
    void appendToEnd(const T& value) {
        Node* newNode = new Node(value);
        if (!head) {
            head = newNode;
            return;
        }

        Node* current = head;
        while (current->next) {
            current = current->next;
        }

        current->next = newNode;
    }

    // Remove the first element
    void removeFirst() {
        if (head) {
            Node* temp = head;
            head = head->next;
            delete temp;
        }
    }

    // Remove the last element
    void removeLast() {
        if (!head) {
            return;
        }

        if (!head->next) {
            delete head;
            head = nullptr;
            return;
        }

        Node* current = head;
        while (current->next->next) {
            current = current->next;
        }

        delete current->next;
        current->next = nullptr;
    }

    // Find an element in the list
    bool findElement(const T& value) const {
        Node* current = head;
        while (current) {
            if (current->data == value) {
                return true;
            }
            current = current->next;
        }
        return false;
    }

    // Display the linked list
    void display() const {
        Node* current = head;
        while (current) {
            std::cout << current->data << " ";
            current = current->next;
        }
        std::cout << std::endl;
    }
};

int main() {
    LinkedList<int> myList;

    myList.appendToStart(3);
    myList.appendToStart(2);
    myList.appendToStart(1);

    myList.display(); // Output: 1 2 3

    myList.appendToEnd(4);
    myList.appendToEnd(5);

    myList.display(); // Output: 1 2 3 4 5

    myList.removeFirst();

    myList.display(); // Output: 2 3 4 5

    myList.removeLast();

    myList.display(); // Output: 2 3 4

    std::cout << "Is 3 in the list? " << (myList.findElement(3) ? "Yes" : "No") << std::endl; // Output: Yes
    std::cout << "Is 5 in the list? " << (myList.findElement(5) ? "Yes" : "No") << std::endl; // Output: No

    LinkedList<std::string> stringList;

    stringList.appendToEnd("world");
    stringList.appendToStart("hello");
    stringList.display();

    return 0;
}