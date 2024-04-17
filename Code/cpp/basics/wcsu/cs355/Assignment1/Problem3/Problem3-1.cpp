// Alexander Luna | Assignment 1 | Problem3-1.cpp
#include <iostream>
using namespace std;

enum Shape {
    Circle,
    Triangle,
    Square,
    Rectangle
};

/* Case 1: Is an enumeration constant allowed to appear in more than one type definition?

    enum Quadrilateral {
        Square,
        Rectangle
    };

    If you uncomment the enum above, we get Compiler Error C2365
    for trying to redefine a member of the Shape enum.
*/

// Case 9: Using enumeration type as function parameter
void printArea(Shape shape, double dimension1, double dimension2 = 0);

int main() {
    // Case 2: Assigning an enumeration type to a variable
    Shape shape = Circle;

    // Case 3: Using enumeration types in switch statement
    switch (shape) {
    case Circle:
        cout << "The shape is a circle" << endl;
        break;
    case Triangle:
        cout << "The shape is a triangle" << endl;
        break;
    case Square:
        cout << "The shape is a square" << endl;
        break;
    case Rectangle:
        cout << "The shape is a rectangle" << endl;
        break;
    default:
        cout << "Unknown shape." << endl;
    }

    // Case 4: Error handling for invalid enumeration value
    if (shape == Triangle)
        cout << "The shape is a triangle." << endl;
    else
        cout << "The shape is not a triangle." << endl;

    // Case 5: Comparison of enumeration values
    Shape shape2 = Square;
    if (shape == shape2)
        cout << "The shapes are the same." << endl;
    else
        cout << "The shapes are not the same." << endl;

    // Case 6: Are enumeration values coerced to integer?
    cout << "The value of the shape is: " << shape << endl;

    // Case 7: The enumeration constants are implicitly assigned the integer
    // values 0, 1, ... but can be explicitly assigned any integer literal
    shape = (Shape)100;
    cout << "The new value of the shape is: " << shape << endl;

    // Case 8: Are other types coerced to an enumeration type?
    char character;
    character = Rectangle;
    cout << "The value of character is: " << (Shape)character << endl;

    // Case 9: Using enumeration type as function parameter
    printArea(Circle, 3);        // Radius
    printArea(Triangle, 4, 5);   // Base and Height
    printArea(Square, 4);        // Side
    printArea(Rectangle, 4, 6);  // Length and Width

    // Case 10: Enumerations in arrays
    Shape shapes[] = { Circle, Triangle, Square, Rectangle };

    // Case 11: Using enumeration types in loops
    for (int i = 0; i < 4; i++) {
        switch (shapes[i]) {
        case Circle:
            cout << "Circle" << endl;
            break;
        case Triangle:
            cout << "Triangle" << endl;
            break;
        case Square:
            cout << "Square" << endl;
            break;
        case Rectangle:
            cout << "Rectangle" << endl;
            break;
        default:
            cout << "Unknown shape." << endl;
        }
    }

    // Case 12: Using enumeration type as class member
    class Class {
    public:
        Shape shape;
        Class(Shape s) : shape(s) {}
    };
    Class myHouse(Rectangle);

    // Case 13: Combining enum values using bitwise OR
    enum Permission {
        Read = 1,
        Write = 2,
    };
    Permission userPermissions = static_cast<Permission>(static_cast<int>(Permission::Read) | static_cast<int>(Permission::Write));

    if (static_cast<int>(userPermissions) & static_cast<int>(Permission::Read))
        cout << "User has read permission." << endl;
    if (static_cast<int>(userPermissions) & static_cast<int>(Permission::Write))
        cout << "User has write permission." << endl;

    return 0;
}

// Case 9: Using enumeration type as function parameter
const double PI = 3.14159;
void printArea(Shape shape, double dimension1, double dimension2) {
    double area = 0;
    switch (shape) {
    case Circle:
        area = PI * pow(dimension1, 2);
        cout << "Area of the circle is: " << area << endl;
        break;
    case Triangle:
        area = 0.5 * dimension1 * dimension2;
        cout << "Area of the triangle is: " << area << endl;
        break;
    case Square:
        area = pow(dimension1, 2);
        cout << "Area of the square is: " << area << endl;
        break;
    case Rectangle:
        area = dimension1 * dimension2;
        cout << "Area of the rectangle is: " << area << endl;
        break;
    default:
        cout << "Unknown shape." << endl;
    }
}