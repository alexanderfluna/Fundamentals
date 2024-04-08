#include <iostream>
#include <unordered_map>

template <typename KeyType, typename ValueType>
class MyMap {
private:
    std::unordered_map<KeyType, ValueType> myUnorderedMap;

public:
    // Method to add an element to the map
    void addElement(const KeyType& key, const ValueType& value) {
        myUnorderedMap[key] = value;
    }

    // Method to display the contents of the map
    void displayMap() const {
        std::cout << "Map contents:" << std::endl;
        for (const auto& pair : myUnorderedMap) {
            std::cout << pair.first << ": " << pair.second << std::endl;
        }
    }

    // Method to delete an element from the map
    void deleteElement(const KeyType& key) {
        auto it = myUnorderedMap.find(key);
        if (it != myUnorderedMap.end()) {
            myUnorderedMap.erase(it);
            std::cout << "Element with key " << key << " removed from the map." << std::endl;
        } else {
            std::cout << "Element with key " << key << " not found in the map." << std::endl;
        }
    }

    // Method to find an element in the map
    bool findElement(const KeyType& key) const {
        return myUnorderedMap.find(key) != myUnorderedMap.end();
    }
};

int main() {
    // Create a map of ints
    MyMap<int, std::string> intMap;

    // Add elements to the intMap
    intMap.addElement(1, "One");
    intMap.addElement(2, "Two");
    intMap.addElement(3, "Three");

    // Display the intMap
    intMap.displayMap();

    // Delete an element from the intMap
    intMap.deleteElement(2);

    // Display the intMap after deletion
    intMap.displayMap();

    // Find an element in the intMap
    int keyToFind = 3;
    if (intMap.findElement(keyToFind)) {
        std::cout << "Element with key " << keyToFind << " is present in the intMap." << std::endl;
    } else {
        std::cout << "Element with key " << keyToFind << " is not present in the intMap." << std::endl;
    }

    // Create a map of strings
    MyMap<std::string, double> stringMap;

    // Add elements to the stringMap
    stringMap.addElement("apple", 2.5);
    stringMap.addElement("banana", 1.8);
    stringMap.addElement("orange", 3.2);

    // Display the stringMap
    stringMap.displayMap();

    // Delete an element from the stringMap
    stringMap.deleteElement("banana");

    // Display the stringMap after deletion
    stringMap.displayMap();

    // Find an element in the stringMap
    std::string keyToFindString = "orange";
    if (stringMap.findElement(keyToFindString)) {
        std::cout << "Element with key " << keyToFindString << " is present in the stringMap." << std::endl;
    } else {
        std::cout << "Element with key " << keyToFindString << " is not present in the stringMap." << std::endl;
    }

    return 0;
}