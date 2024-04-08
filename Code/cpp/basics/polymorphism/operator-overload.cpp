/* Compile-time polymorphism: This type of polmorphism
 is achieved by function overloading or operator overloading */

/* Operator overloading: You can make use of the addition operator
(+) for string class to concatenate two strings. We know that the
task of this operator is to add two operands. So a single operator
'+', when placed between integer operands, adds them and when
placed between string operands concatenates them */

// c++ program for operator overloading
#include <iostream>
using namespace std;

class Complex {
    private:
        int real, imag;
    public:
        // Inline declaration
        Complex(int r = 0, int i = 0) {real = r; imag=i;}

        // This is automatically called when '+' is used with
        // between to Complex objects
        Complex operator + (Complex const &obj) {
            Complex res;
            res.real = real + obj.real;
            res.imag = imag + obj.imag;
            return res;
        }

        void print() { cout << real << " + i" << imag << endl; }
};

int main() {
    Complex c1(10, 5), c2(2, 4);
    Complex c3 = c1 + c2; // An example call to "operator+"
    c3.print();
    cout << "Good" << endl;
}