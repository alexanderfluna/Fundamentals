#include <iostream>
#include <queue>

int main() {
    // Create a queue of integers
    std::queue<int> myQueue;

    // Check if the queue is empty
    if (myQueue.empty()) {
        std::cout << "Queue is empty." << std::endl;
    }

    // Add elements to the queue
    myQueue.push(10);
    myQueue.push(20);
    myQueue.push(30);
    myQueue.push(40);

    // Display the front element of the queue
    std::cout << "Front element of the queue: " << myQueue.front() << std::endl;

    // Display the size of the queue
    std::cout << "Size of the queue: " << myQueue.size() << std::endl;

    // Display the contents of the queue
    std::cout << "Queue contents: ";
    while (!myQueue.empty()) {
        std::cout << myQueue.front() << " ";
        myQueue.pop();
    }
    std::cout << std::endl;

    // Check if the queue is empty after dequeueing all elements
    if (myQueue.empty()) {
        std::cout << "Queue is empty." << std::endl;
    }

    return 0;
}
