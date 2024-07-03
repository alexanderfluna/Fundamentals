#include <iostream>
#include <vector>
#include <algorithm>

template <typename T>
class Heap {
private:
    std::vector<T> heap;

    // Helper functions
    void heapifyUp(int index) {
        while (index > 0) {
            int parentIndex = (index - 1) / 2;
            if (heap[index] > heap[parentIndex]) {
                std::swap(heap[index], heap[parentIndex]);
                index = parentIndex;
            } else {
                break;
            }
        }
    }

    void heapifyDown(int index) {
        int leftChild = 2 * index + 1;
        int rightChild = 2 * index + 2;
        int largest = index;

        if (leftChild < heap.size() && heap[leftChild] > heap[largest]) {
            largest = leftChild;
        }

        if (rightChild < heap.size() && heap[rightChild] > heap[largest]) {
            largest = rightChild;
        }

        if (largest != index) {
            std::swap(heap[index], heap[largest]);
            heapifyDown(largest);
        }
    }

public:
    // Add an element to the heap
    void addElement(const T& value) {
        heap.push_back(value);
        heapifyUp(heap.size() - 1);
    }

    // Display the contents of the heap
    void displayHeap() const {
        std::cout << "Heap contents: ";
        for (const auto& element : heap) {
            std::cout << element << " ";
        }
        std::cout << std::endl;
    }

    // Remove an element from the heap
    void removeElement(const T& value) {
        auto it = std::find(heap.begin(), heap.end(), value);
        if (it != heap.end()) {
            *it = heap.back();
            heap.pop_back();
            heapifyDown(std::distance(heap.begin(), it));
        }
    }

    // Find an element in the heap
    bool findElement(const T& value) const {
        return std::find(heap.begin(), heap.end(), value) != heap.end();
    }

    // Check if the heap is empty
    bool isEmpty() const {
        return heap.empty();
    }

    // Get the size of the heap
    size_t size() const {
        return heap.size();
    }
};

int main() {
    // Create a heap of integers
    Heap<int> intHeap;

    intHeap.addElement(30);
    intHeap.addElement(20);
    intHeap.addElement(40);
    intHeap.addElement(10);

    std::cout << "Heap of Integers:" << std::endl;
    intHeap.displayHeap();

    // Remove an element
    intHeap.removeElement(20);
    std::cout << "After removing 20:" << std::endl;
    intHeap.displayHeap();

    // Find an element
    int elementToFind = 30;
    if (intHeap.findElement(elementToFind)) {
        std::cout << "Element " << elementToFind << " found in the heap." << std::endl;
    } else {
        std::cout << "Element " << elementToFind << " not found in the heap." << std::endl;
    }

    // Create a heap of strings
    Heap<std::string> stringHeap;

    stringHeap.addElement("apple");
    stringHeap.addElement("banana");
    stringHeap.addElement("orange");
    stringHeap.addElement("grape");

    std::cout << "\nHeap of Strings:" << std::endl;
    stringHeap.displayHeap();

    // Remove an element
    stringHeap.removeElement("banana");
    std::cout << "After removing 'banana':" << std::endl;
    stringHeap.displayHeap();

    // Find an element
    std::string elementToFindString = "orange";
    if (stringHeap.findElement(elementToFindString)) {
        std::cout << "Element '" << elementToFindString << "' found in the heap." << std::endl;
    } else {
        std::cout << "Element '" << elementToFindString << "' not found in the heap." << std::endl;
    }

    return 0;
}
