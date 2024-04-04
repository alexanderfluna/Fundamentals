#include <iostream>
#include <cmath>

enum Shape {
    Circle,
    Triangle,
    Square,
    Rectangle,
};

const double PI = 3.14159;

double calculateArea(Shape shape, double dimension1, double dimension2 = 0) {
    switch (shape) {
    case Circle:
        return PI * dimension1 * dimension1;
    case Triangle:
        return 0.5 * dimension1 * dimension2;
    case Square:
        return dimension1 * dimension1;
    case Rectangle:
        return dimension1 * dimension2;
    default:
        std::cerr << "Invalid shape!" << std::endl;
        return 0.0;
    }
}

int main() {
    std::cout << "Area of circle with radius 3.0: " << calculateArea(Circle, 3.0) << std::endl;
    std::cout << "Area of triangle with base 5.0 and height 6.0: " << calculateArea(Triangle, 5.0, 6.0) << std::endl;
    std::cout << "Area of square with side length 4.0: " << calculateArea(Square, 4.0) << std::endl;
    std::cout << "Area of rectangle with length 5.0 and width 7.0: " << calculateArea(Rectangle, 5.0, 7.0) << std::endl;

    return 0;
}
