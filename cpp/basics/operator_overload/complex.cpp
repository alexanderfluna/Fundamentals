#include <iostream>

class Complex {
private:
    double real;
    double imaginary;

public:
    // Constructor
    Complex(double r = 0.0, double i = 0.0) : real(r), imaginary(i) {}

    // Getter functions
    double getReal() const { return real; }
    double getImaginary() const { return imaginary; }

    // Overloading binary + operator
    Complex operator+(const Complex& other) const {
        return Complex(real + other.real, imaginary + other.imaginary);
    }

    // Overloading binary - operator
    Complex operator-(const Complex& other) const {
        return Complex(real - other.real, imaginary - other.imaginary);
    }

    // Overloading binary * operator
    Complex operator*(const Complex& other) const {
        double resultReal = real * other.real - imaginary * other.imaginary;
        double resultImaginary = real * other.imaginary + imaginary * other.real;
        return Complex(resultReal, resultImaginary);
    }

    // Overloading binary / operator
    Complex operator/(const Complex& other) const {
        double denominator = other.real * other.real + other.imaginary * other.imaginary;
        double resultReal = (real * other.real + imaginary * other.imaginary) / denominator;
        double resultImaginary = (imaginary * other.real - real * other.imaginary) / denominator;
        return Complex(resultReal, resultImaginary);
    }

    // Overloading unary - operator
    Complex operator-() const {
        return Complex(-real, -imaginary);
    }

    // Overloading += operator
    Complex& operator+=(const Complex& other) {
        real += other.real;
        imaginary += other.imaginary;
        return *this;
    }

    // Overloading -= operator
    Complex& operator-=(const Complex& other) {
        real -= other.real;
        imaginary -= other.imaginary;
        return *this;
    }

    // Overloading *= operator
    Complex& operator*=(const Complex& other) {
        double resultReal = real * other.real - imaginary * other.imaginary;
        double resultImaginary = real * other.imaginary + imaginary * other.real;
        real = resultReal;
        imaginary = resultImaginary;
        return *this;
    }

    // Overloading /= operator
    Complex& operator/=(const Complex& other) {
        double denominator = other.real * other.real + other.imaginary * other.imaginary;
        double resultReal = (real * other.real + imaginary * other.imaginary) / denominator;
        double resultImaginary = (imaginary * other.real - real * other.imaginary) / denominator;
        real = resultReal;
        imaginary = resultImaginary;
        return *this;
    }

    // Overloading == operator
    bool operator==(const Complex& other) const {
        return (real == other.real) && (imaginary == other.imaginary);
    }

    // Overloading != operator
    bool operator!=(const Complex& other) const {
        return !(*this == other);
    }

    // Overloading << operator for easy printing
    friend std::ostream& operator<<(std::ostream& os, const Complex& c) {
        os << c.real << " + " << c.imaginary << "i";
        return os;
    }
};

int main() {
    Complex a(1.0, 2.0);
    Complex b(3.0, 4.0);

    // Using overloaded operators
    Complex sum = a + b;
    Complex difference = a - b;
    Complex product = a * b;
    Complex quotient = a / b;

    std::cout << "a + b = " << sum << std::endl;
    std::cout << "a - b = " << difference << std::endl;
    std::cout << "a * b = " << product << std::endl;
    std::cout << "a / b = " << quotient << std::endl;

    // Using other overloaded operators
    Complex negation = -a;
    a += b;
    b -= a;
    a *= b;
    b /= a;

    std::cout << "-a = " << negation << std::endl;
    std::cout << "a += b: a = " << a << std::endl;
    std::cout << "b -= a: b = " << b << std::endl;
    std::cout << "a *= b: a = " << a << std::endl;
    std::cout << "b /= a: b = " << b << std::endl;

    // Using == and != operators
    std::cout << "a == b: " << (a == b) << std::endl;
    std::cout << "a != b: " << (a != b) << std::endl;

    return 0;
}
