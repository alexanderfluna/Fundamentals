// Alexander Luna | Assignment 1 | Problem3-1.cpp
#include <iostream>
using namespace std;

enum Shape {
    Circle,
    Triangle,
    Square,
    Rectangle
};
const double PI = 3.14159;
void printArea(Shape shape, double dimension1, double dimension2 = 0);

int main() {

    // Case 1: Assigning enumeration values
    Shape shape = Shape::Circle;

    // Case 2: Using enumeration values in switch statement
    switch (shape) {
        case Shape::Circle:
            cout << "Circle" << endl;
            break;
        case Shape::Triangle:
            cout << "Triangle" << endl;
            break;
        case Shape::Square:
            cout << "Square" << endl;
            break;
        case Shape::Rectangle:
            cout << "Rectangle" << endl;
            break;
        default:
            cout << "Unknown shape." << endl;
    }

    // Case 3: Using enumeration type as function parameter
    printArea(Shape::Circle, 3);        // Radius
    printArea(Shape::Triangle, 4, 5);   // Base and Height
    printArea(Shape::Square, 4);        // Side
    printArea(Shape::Rectangle, 4, 6);  // Length and Width

    // Case 4: Error handling for invalid enumeration value
    if (shape == Shape::Rectangle)
        cout << "The shape is a rectangle." << endl;
    else
        cout << "The shape is not a rectangle." << endl;

    // Case 5: Comparison of enumeration values
    Shape shape2 = Shape::Square;
    if (shape == shape2)
        cout << "The shapes are the same." << endl;
    else
        cout << "The shapes are not the same." << endl;

    // Case 6: Incrementing the enumeration value
    shape = static_cast<Shape>(static_cast<int>(shape) + 1);

    // Case 7: Enumerations in arrays
    Shape shapes[] = { Shape::Circle, Shape::Triangle, Shape::Square, Shape::Rectangle };

    // Case 8: Using enumeration types in loops
    for (int i = 0; i < 4; i++) {
        switch (shapes[i]) {
        case Shape::Circle:
            cout << "Circle" << endl;
            break;
        case Shape::Triangle:
            cout << "Triangle" << endl;
            break;
        case Shape::Square:
            cout << "Square" << endl;
            break;
        case Shape::Rectangle:
            cout << "Rectangle" << endl;
            break;
        default:
            cout << "Unknown shape." << endl;
        }
    }

    // Case 9: Using enumeration type as class member
    class Class {
    public:
        Shape shape;
        Class(Shape s) : shape(s) {}
    };
    Class myHouse(Shape::Rectangle);

    // Case 10: Combining enum values using bitwise OR
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

// Case 3: Using enumeration type as function parameter
void printArea(Shape shape, double dimension1, double dimension2) {
    double area = 0;
    switch (shape) {
    case Shape::Circle:
        area = PI * pow(dimension1, 2);
        cout << "Area of the circle is: " << area << endl;
        break;
    case Shape::Triangle:
        area = 0.5 * dimension1 * dimension2;
        cout << "Area of the triangle is: " << area << endl;
        break;
    case Shape::Square:
        area = pow(dimension1, 2);
        cout << "Area of the square is: " << area << endl;
        break;
    case Shape::Rectangle:
        area = dimension1 * dimension2;
        cout << "Area of the rectangle is: " << area << endl;
        break;
    default:
        cout << "Unknown shape." << endl;
    }
}