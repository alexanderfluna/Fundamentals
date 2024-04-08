#include <iostream>
#include <vector>

template <typename T>
class MyVector {
private:
    std::vector<T> elements;

public:
    // Constructor
    MyVector(const std::vector<T>& initialElements) : elements(initialElements) {}

    // Function to display vector elements
    void displayVector() const {
        std::cout << "Vector: ";
        for (const T& element : elements) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    // Function to add an element to the vector
    void addElement(const T& element) {
        elements.push_back(element);
    }

    // Function to get the size of the vector
    size_t getSize() const {
        return elements.size();
    }

    // Function to access an element at a specific index
    T getElementAt(size_t index) const {
        if (index < elements.size()) {
            return elements[index];
        }
        else {
            throw std::out_of_range("Index out of range");
        }
    }

    // Function to find the index of a specific element
    size_t findElementIndex(const T& element) const {
        auto it = std::find(elements.begin(), elements.end(), element);
        if (it != elements.end()) {
            return std::distance(elements.begin(), it);
        }
        else {
            return std::numeric_limits<size_t>::max(); // Element not found
        }
    }

    // Function to remove an element at a specific index
    void removeElementAt(size_t index) {
        if (index < elements.size()) {
            elements.erase(elements.begin() + index);
        }
        else {
            throw std::out_of_range("Index out of range");
        }
    }

    // Function to clear all elements from the vector
    void clearVector() {
        elements.clear();
    }
};

int main() {
    // Example usage of the MyVector class
    std::vector<int> initialElements = { 1, 2, 3, 4, 5 };
    MyVector<int> vectorInstance(initialElements);

    vectorInstance.displayVector();

    vectorInstance.addElement(6);
    vectorInstance.displayVector();

    std::cout << "Vector size: " << vectorInstance.getSize() << std::endl;

    size_t indexToAccess = 2;
    std::cout << "Element at index " << indexToAccess << ": " << vectorInstance.getElementAt(indexToAccess) << std::endl;

    int elementToFind = 4;
    size_t elementIndex = vectorInstance.findElementIndex(elementToFind);
    if (elementIndex != std::numeric_limits<size_t>::max()) {
        std::cout << "Index of element " << elementToFind << ": " << elementIndex << std::endl;
    }
    else {
        std::cout << "Element not found in the vector." << std::endl;
    }

    size_t indexToRemove = 1;
    vectorInstance.removeElementAt(indexToRemove);
    vectorInstance.displayVector();

    vectorInstance.clearVector();
    vectorInstance.displayVector();

    return 0;
}
