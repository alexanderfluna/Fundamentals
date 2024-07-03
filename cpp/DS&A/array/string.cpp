#include <iostream>
#include <string>
#include <algorithm>

int main() {
    // Initialization
    std::string str1 = "Hello, ";
    std::string str2 = "world!";

    // Concatenation
    std::string result = str1 + str2;
    std::cout << "Concatenation: " << result << std::endl;

    // Length
    std::cout << "Length of str1: " << str1.length() << std::endl;
    std::cout << "Length of str2: " << str2.length() << std::endl;

    // Comparison
    if (str1 == str2) {
        std::cout << "str1 is equal to str2" << std::endl;
    }
    else {
        std::cout << "str1 is not equal to str2" << std::endl;
    }

    // Substring
    std::string substring = result.substr(0, 5); // Extracts "Hello"
    std::cout << "Substring: " << substring << std::endl;

    // Find substring
    size_t pos = result.find("world");
    if (pos != std::string::npos) {
        std::cout << "Substring 'world' found at position: " << pos << std::endl;
    }
    else {
        std::cout << "Substring 'world' not found" << std::endl;
    }

    // Replace substring
    result.replace(7, 5, "Universe");
    std::cout << "After replacement: " << result << std::endl;

    // Convert to uppercase and lowercase
    std::string uppercaseStr = result;
    std::transform(uppercaseStr.begin(), uppercaseStr.end(), uppercaseStr.begin(), ::toupper);
    std::cout << "Uppercase: " << uppercaseStr << std::endl;

    std::string lowercaseStr = result;
    std::transform(lowercaseStr.begin(), lowercaseStr.end(), lowercaseStr.begin(), ::tolower);
    std::cout << "Lowercase: " << lowercaseStr << std::endl;

    // Find position of a character
    char searchChar = 'o';
    size_t charPos = result.find(searchChar);
    if (charPos != std::string::npos) {
        std::cout << "Position of '" << searchChar << "': " << charPos << std::endl;
    }
    else {
        std::cout << "'" << searchChar << "' not found" << std::endl;
    }

    // Erase a portion of the string
    result.erase(3, 5); // Erase 5 characters starting from position 3
    std::cout << "After erasing: " << result << std::endl;

    // Insert a substring at a specific position
    result.insert(3, "###"); // Insert "###" at position 3
    std::cout << "After insertion: " << result << std::endl;

    // Append characters to the end
    result.append("!!!"); // Append "!!!" to the end
    std::cout << "After appending: " << result << std::endl;

    // Resize the string
    str1.resize(3); // Resize to 3 characters
    std::cout << "After resizing: " << str1 << std::endl;

    return 0;
}