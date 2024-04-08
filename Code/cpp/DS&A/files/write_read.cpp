#include <iostream>
#include <fstream>
#include <string>

int main() {
    std::string fileName;

    // Ask the user for the name of the file
    std::cout << "Enter the name of the file: ";
    std::getline(std::cin, fileName);

    // Open the file in append mode
    std::ofstream outputFile(fileName, std::ios::app);

    if (!outputFile.is_open()) {
        std::cerr << "Error opening the file." << std::endl;
        return 1; // Exit with an error code
    }

    // Ask the user what to add to the file
    std::string userInput;
    std::cout << "Enter what to add to the file: ";
    std::getline(std::cin, userInput);

    // Add the input into the file
    outputFile << userInput << std::endl;

    // Close the file
    outputFile.close();

    // Open the file again to display its contents
    std::ifstream inputFile(fileName);

    if (!inputFile.is_open()) {
        std::cerr << "Error opening the file." << std::endl;
        return 1; // Exit with an error code
    }

    // Display the contents of the file
    std::cout << "Contents of the file:" << std::endl;
    std::string fileContents;
    while (std::getline(inputFile, fileContents)) {
        std::cout << fileContents << std::endl;
    }

    // Close the file
    inputFile.close();

    return 0;
}
