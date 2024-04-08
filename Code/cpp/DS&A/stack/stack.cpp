#include <iostream>
#include <stack>

int main() {
    // Create a stack of integers
    std::stack<int> myStack;

    // Check if the stack is empty
    if (myStack.empty()) {
        std::cout << "Stack is empty." << std::endl;
    }

    // Push elements onto the stack
    myStack.push(10);
    myStack.push(20);
    myStack.push(30);
    myStack.push(40);

    // Display the size of the stack
    std::cout << "Size of the stack: " << myStack.size() << std::endl;

    // Display the top element of the stack
    std::cout << "Top element of the stack: " << myStack.top() << std::endl;

    // Display the contents of the stack
    std::cout << "Stack contents: ";
    while (!myStack.empty()) {
        std::cout << myStack.top() << " ";
        myStack.pop();
    }
    std::cout << std::endl;

    // Check if the stack is empty after popping all elements
    if (myStack.empty()) {
        std::cout << "Stack is empty." << std::endl;
    }

    return 0;
}
