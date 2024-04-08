// Use if you need ordered traversal or a specfiic order of elements

#include <iostream>
#include <map>

// Function to add key-value pair to the map
void addToMap(std::map<int, std::string>& myMap, int key, const std::string& value) {
    myMap[key] = value;
}

// Function to display the contents of the map
void displayMap(const std::map<int, std::string>& myMap) {
    std::cout << "Map contents:" << std::endl;
    for (const auto& pair : myMap) {
        std::cout << pair.first << ": " << pair.second << std::endl;
    }
}

// Function to remove an element from the map by key
void removeFromMap(std::map<int, std::string>& myMap, int key) {
    auto it = myMap.find(key);
    if (it != myMap.end()) {
        myMap.erase(it);
        std::cout << "Element with key " << key << " removed from the map." << std::endl;
    } else {
        std::cout << "Element with key " << key << " not found in the map." << std::endl;
    }
}

// Function to check if an element is in the map
bool isInMap(const std::map<int, std::string>& myMap, int key) {
    return myMap.find(key) != myMap.end();
}

int main() {
    std::map<int, std::string> myMap;

    // Add elements to the map
    addToMap(myMap, 1, "One");
    addToMap(myMap, 2, "Two");
    addToMap(myMap, 3, "Three");

    // Display the map
    displayMap(myMap);

    // Remove an element from the map
    removeFromMap(myMap, 2);

    // Display the map after removal
    displayMap(myMap);

    // Check if an element is in the map
    int keyToCheck = 3;
    if (isInMap(myMap, keyToCheck)) {
        std::cout << "Element with key " << keyToCheck << " is present in the map." << std::endl;
    } else {
        std::cout << "Element with key " << keyToCheck << " is not present in the map." << std::endl;
    }

    return 0;
}
