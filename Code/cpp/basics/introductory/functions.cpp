#include <iostream>

// Calls prototype
int multiply(int a, int b);

int main()
{
    // Creates variables
    int a, b;

    // Asks for first number & stores in a
    std::cout << "First number to multiply: ";
    std::cin >> a;

    // Asks for second number & stores in b
    std::cout << "Second number to multiply: ";
    std::cin >> b;

    // Calls multiply function
    int result = multiply(a, b);

    // Prints result. You only need "std::endl"
    // when you won't ask for user input
    std::cout << a << " * " << b << " = " << result << std::endl;
}

// multiply function after main
int multiply(int a, int b)
{
    return a * b;
}