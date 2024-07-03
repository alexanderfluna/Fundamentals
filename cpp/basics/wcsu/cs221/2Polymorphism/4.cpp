// C++ Program to demonstrate 
// the Virtual Function
#include <iostream>
using namespace std;
  
// Declaring a Base class
class GFG_Base {
  
public:
    // virtual function
    virtual void display()
    {
        cout << "Called virtual Base Class function" << 
                "\n\n";
    }
  
    void print()
    {
        cout << "Called GFG_Base print function" << 
                "\n\n";
    }
};
  
// Declaring a Child Class
class GFG_Child : public GFG_Base {
  
public:
    void display()
    {
        cout << "Called GFG_Child Display Function" << 
                "\n\n";
    }
  
    void print()
    {
        cout << "Called GFG_Child print Function" << 
                "\n\n";
    }
};
  
// Driver code
int main()
{
    // Create a reference of class bird
    GFG_Base* base;
  
    GFG_Child child;
  
    base = &child;
  
    // This will call the virtual function
    base->GFG_Base::display();

    // This will call the non-virtual function
    base->display();

    // Will only do base function because it's not virtual
    base->GFG_Base::print();
    base->print();
}