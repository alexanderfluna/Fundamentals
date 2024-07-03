#include <iostream>

int main()
{
    // GENERAL

    // Can use 'unsigned' before any variable to have the first
    // bit be a sign.

    // sizeof() will give you how many bytes the variable stores

    ///////////////////////////////////////////////////////////

    // INTEGER
    // 4 bytes(32 bits)(-2b -> 2b)

    // Because it's a signed varible(first bit is for the sign),
    // 31 bits are left for the actual number. Therefore, 2^31=2b.
    int variable = 8;

    // Prints variable
    std::cout << "int variable:" << std::endl;
    std::cout << variable << std::endl;

    // Changes value of variable to 20
    variable = 20;
    std::cout << "int variable after change:" << std::endl;
    std::cout << variable << std::endl;

    // An unsigned variable does not have the sign bit,
    // so it can range 2^32=4b.
    unsigned int variable2 = 8;
    std::cout << "int variable2:" << std::endl;
    std::cout << variable2 << std::endl;

    std::cout << "sizeof(int):" << std::endl;
    std::cout << sizeof(int) << std::endl;

    ///////////////////////////////////////////////////////////

    // CHAR
    // One byte (-127 to 127 or 0 to 255)
    // Used for characters. If stored as a number, a character
    // will be printed out.

    char a = 'A';
    std::cout << "char a:" << std::endl;
    std::cout << a << std::endl;

    char b = 65;
    std::cout << "char b:" << std::endl;
    std::cout << b << std::endl;

    std::cout << "sizeof(char):" << std::endl;
    std::cout << sizeof(char) << std::endl;

    ///////////////////////////////////////////////////////////

    // SHORT: Two bytes

    // LONG: Four bytes

    // LONG LONG: Eight bytes

    ///////////////////////////////////////////////////////////

    // FLOAT & DOUBLES
    // Used for decimals
    // FLOAT: Four bytes
    // DOUBLE: Eight bytes

    // 'float fly = 5.5;' is actually saved as a double
    // This is the way to make it a float & only four bytes
    float fly = 5.5f;

    double dragon = 5.5;

    std::cout << "float fly:" << std::endl;
    std::cout << fly << std::endl;


    std::cout << "double dragon:" << std::endl;
    std::cout << dragon << std::endl;

    std::cout << "sizeof(float):" << std::endl;
    std::cout << sizeof(float) << std::endl;

    std::cout << "sizeof(double):" << std::endl;
    std::cout << sizeof(double) << std::endl;

    ///////////////////////////////////////////////////////////

    // BOOL
    // One byte
    // 0 means false. Anything except for 0 is true.

    bool bowling = true;

    std::cout << "bool bowling:" << std::endl;
    std::cout << bowling << std::endl;

    std::cout << "sizeof(bool)" << std::endl;
    std::cout << sizeof(bool) << std::endl;
}