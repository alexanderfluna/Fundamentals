// Use if you need fast lookups and don't care about the order of elements
#include <iostream>
#include <unordered_map>

// Function to add key-value pair to the unordered_map
void addToUnorderedMap(std::unordered_map<int, std::string>& myUnorderedMap, int key, const std::string& value) {
    myUnorderedMap[key] = value;
}

// Function to display the contents of the unordered_map
void displayUnorderedMap(const std::unordered_map<int, std::string>& myUnorderedMap) {
    std::cout << "Unordered Map contents:" << std::endl;
    for (const auto& pair : myUnorderedMap) {
        std::cout << pair.first << ": " << pair.second << std::endl;
    }
}

// Function to remove an element from the unordered_map by key
void removeFromUnorderedMap(std::unordered_map<int, std::string>& myUnorderedMap, int key) {
    auto it = myUnorderedMap.find(key);
    if (it != myUnorderedMap.end()) {
        myUnorderedMap.erase(it);
        std::cout << "Element with key " << key << " removed from the unordered_map." << std::endl;
    } else {
        std::cout << "Element with key " << key << " not found in the unordered_map." << std::endl;
    }
}

// Function to check if an element is in the unordered_map
bool isInUnorderedMap(const std::unordered_map<int, std::string>& myUnorderedMap, int key) {
    return myUnorderedMap.find(key) != myUnorderedMap.end();
}

int main() {
    std::unordered_map<int, std::string> myUnorderedMap;

    // Add elements to the unordered_map
    addToUnorderedMap(myUnorderedMap, 1, "One");
    addToUnorderedMap(myUnorderedMap, 2, "Two");
    addToUnorderedMap(myUnorderedMap, 3, "Three");

    // Display the unordered_map
    displayUnorderedMap(myUnorderedMap);

    // Remove an element from the unordered_map
    removeFromUnorderedMap(myUnorderedMap, 2);

    // Display the unordered_map after removal
    displayUnorderedMap(myUnorderedMap);

    // Check if an element is in the unordered_map
    int keyToCheck = 3;
    if (isInUnorderedMap(myUnorderedMap, keyToCheck)) {
        std::cout << "Element with key " << keyToCheck << " is present in the unordered_map." << std::endl;
    } else {
        std::cout << "Element with key " << keyToCheck << " is not present in the unordered_map." << std::endl;
    }

    return 0;
}