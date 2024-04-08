#include <iostream>

int main()
{
    // For loop
    for (int i = 0; i < 5; i++)
    {
        std::cout << "Hello: " << i << std::endl;
    }

    // While loop
    int i = 0;
    while (i < 5)
    {
        std::cout << "World: " << i << std::endl;
        i++;
    }

    // Do while loop (will execute code at least once)
    i = 6;
    do
    {
        std::cout << "i is not less than 5" << std::endl;
    } while (i < 5);
}