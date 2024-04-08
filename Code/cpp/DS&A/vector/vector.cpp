#include <iostream>
#include <vector>

int main() {
    // Create a vector of integers
    std::vector<int> myVector;

    // Check if the vector is empty
    if (myVector.empty()) {
        std::cout << "Vector is empty." << std::endl;
    }

    // Add elements to the vector
    myVector.push_back(10);
    myVector.push_back(20);
    myVector.push_back(30);
    myVector.push_back(40);

    // Display the size of the vector
    std::cout << "Size of the vector: " << myVector.size() << std::endl;

    // Access elements in the vector
    std::cout << "First element: " << myVector[0] << std::endl;
    std::cout << "Last element: " << myVector.back() << std::endl;

    // Modify elements in the vector
    myVector[1] = 25;
    std::cout << "Modified vector: ";
    for (const auto& element : myVector) {
        std::cout << element << " ";
    }
    std::cout << std::endl;

    // Display the capacity of the vector
    std::cout << "Capacity of the vector: " << myVector.capacity() << std::endl;

    // Resize the vector
    myVector.resize(3);
    std::cout << "After resizing to 3 elements: ";
    for (const auto& element : myVector) {
        std::cout << element << " ";
    }
    std::cout << std::endl;

    // Check if the vector is empty after resizing
    if (myVector.empty()) {
        std::cout << "Vector is empty." << std::endl;
    }

    // Clear the vector
    myVector.clear();
    std::cout << "After clearing the vector, size: " << myVector.size() << std::endl;

    return 0;
}
