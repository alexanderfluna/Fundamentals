#include <iostream>
#include <set>

int main() {
    // Create a set of integers
    std::set<int> mySet;

    // Add elements to the set
    mySet.insert(10);
    mySet.insert(20);
    mySet.insert(30);
    mySet.insert(40);

    // Display the size of the set
    std::cout << "Size of the set: " << mySet.size() << std::endl;

    // Display the contents of the set
    std::cout << "Set contents: ";
    for (const auto& element : mySet) {
        std::cout << element << " ";
    }
    std::cout << std::endl;

    // Check if an element is present in the set
    int elementToFind = 20;
    auto it = mySet.find(elementToFind);
    if (it != mySet.end()) {
        std::cout << "Element " << elementToFind << " found in the set." << std::endl;
    } else {
        std::cout << "Element " << elementToFind << " not found in the set." << std::endl;
    }

    // Remove an element from the set
    int elementToRemove = 30;
    size_t elementsRemoved = mySet.erase(elementToRemove);
    if (elementsRemoved > 0) {
        std::cout << "Element " << elementToRemove << " removed from the set." << std::endl;
    } else {
        std::cout << "Element " << elementToRemove << " not found in the set." << std::endl;
    }

    // Display the contents of the set after removal
    std::cout << "Set contents after removal: ";
    for (const auto& element : mySet) {
        std::cout << element << " ";
    }
    std::cout << std::endl;

    return 0;
}
