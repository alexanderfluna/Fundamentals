// Alexander Luna | Assignment 1 | Problem 3-2.cpp (C++/CLI)
#include <iostream>
using namespace System;

enum class Shape {
    Circle,
    Triangle,
    Square,
    Rectangle
};

// Case 1: Is an enumeration constant allowed to appear in more than one type definition?
// In C++/CLI, this is allowed
enum class Quadrilateral {
    Square,
    Rectangle
};

// Case 12: Using enumeration type as class member
ref class Class {
public:
    Quadrilateral quadrilateral;
    Class(Quadrilateral q) : quadrilateral(q) {}
};

// Case 9: Using enumeration type as function parameter
void printArea(Shape shape, double dimension1, double dimension2 = 0);

int main(array<System::String^>^ args) {
    // Case 2: Assigning an enumeration type to a variable
    Shape shape = Shape::Circle;

    // Case 3: Using enumeration types in switch statement
    switch (shape) {
    case Shape::Circle:
        Console::WriteLine("The shape is a circle");
        break;
    case Shape::Triangle:
        Console::WriteLine("The shape is a triangle");
        break;
    case Shape::Square:
        Console::WriteLine("The shape is a square");
        break;
    case Shape::Rectangle:
        Console::WriteLine("The shape is a rectangle");
        break;
    default:
        Console::WriteLine("Unknown shape.");
    }

    // Case 4: Error handling for invalid enumeration value
    if (shape == Shape::Triangle)
        Console::WriteLine("The shape is a triangle.");
    else
        Console::WriteLine("The shape is not a triangle.");

    // Case 5: Comparison of enumeration values
    Shape shape2 = Shape::Square;
    if (shape == shape2)
        Console::WriteLine("The shapes are the same.");
    else
        Console::WriteLine("The shapes are not the same.");



    // Case 6: Are enumeration values coerced to integer?
    
    // Uncommenting the line below gives us an error
    // Console::WriteLine("The value of the shape is: {0}", shape);

    // Instead, we must explicitiy cast to an integer
    Console::WriteLine("The value of the shape is: {0}", static_cast<int>(shape));



    // Case 7: The enumeration constants are implicitly assigned the integer
    // values 0, 1, ... but can be explicitly assigned any integer literal
    shape = static_cast <Shape>(100);
    Console::WriteLine("The new value of the shape is: {0}", static_cast<int>(shape));



    // Case 8: Are another other types coerced to an enumeration type?
    char character;

    // If you uncomment the line below, you get an error that a value
    // type "Shape" cannot be assigned to an entity of type "char"
    //character = Shape::Rectangle;

    // Instead, we must explicitiy cast to the enuemration type
    character = static_cast<char>(Shape::Rectangle);
    Console::WriteLine("The value of character is: {0} ", static_cast<char>(character));



    // Case 9: Using enumeration type as function parameter
    printArea(Shape::Circle, 3);        // Radius
    printArea(Shape::Triangle, 4, 5);   // Base and Height
    printArea(Shape::Square, 4);        // Side
    printArea(Shape::Rectangle, 4, 6);  // Length and Width

    // Case 10: Enumerations in arrays
    array<Shape>^ shapes = { Shape::Circle, Shape::Triangle, Shape::Square, Shape::Rectangle };

    // Case 11: Using enumeration types in loops
    for each (Shape s in shapes) {
        switch (s) {
        case Shape::Circle:
            Console::WriteLine("Circle");
            break;
        case Shape::Triangle:
            Console::WriteLine("Triangle");
            break;
        case Shape::Square:
            Console::WriteLine("Square");
            break;
        case Shape::Rectangle:
            Console::WriteLine("Rectangle");
            break;
        default:
            Console::WriteLine("Unknown shape.");
        }
    }

    // Case 12: Using enumeration type as class member
    Class^ myHouse = gcnew Class(Quadrilateral::Square);

    // Case 13: Combining enum values using bitwise OR
    enum class Permission {
        Read = 1,
        Write = 2,
    };
    Permission userPermissions = static_cast<Permission>(static_cast<int>(Permission::Read) | static_cast<int>(Permission::Write));

    if ((static_cast<int>(userPermissions) & static_cast<int>(Permission::Read)) != 0)
        Console::WriteLine("User has read permission.");
    if ((static_cast<int>(userPermissions) & static_cast<int>(Permission::Write)) != 0)
        Console::WriteLine("User has write permission.");

    return 0;
}

// Case 9: Using enumeration type as function parameter
const double PI = 3.14159;
void printArea(Shape shape, double dimension1, double dimension2) {
    double area = 0;
    switch (shape) {
    case Shape::Circle:
        area = PI * Math::Pow(dimension1, 2);
        Console::WriteLine("Area of the circle is: {0}", area);
        break;
    case Shape::Triangle:
        area = 0.5 * dimension1 * dimension2;
        Console::WriteLine("Area of the triangle is: {0}", area);
        break;
    case Shape::Square:
        area = Math::Pow(dimension1, 2);
        Console::WriteLine("Area of the square is: {0}", area);
        break;
    case Shape::Rectangle:
        area = dimension1 * dimension2;
        Console::WriteLine("Area of the rectangle is: {0}", area);
        break;
    default:
        Console::WriteLine("Unknown shape.");
    }
}
