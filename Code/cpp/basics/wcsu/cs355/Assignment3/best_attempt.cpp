// Alexandwer Luna | Assignment 3 | RuntimeStack.cpp
#include <iostream>
#include <vector>
#include <string>
#include <stdexcept>
#include <unordered_map>

class Sub
{
private:
    std::string name;
    Sub* parent;
    std::vector<Sub*> children;
    int numArgs;
    int numLocals;
    int static_depth;
    static std::vector<int> runtimeStack;
    static std::vector<int> display;
    static std::unordered_map<int, std::string> nameEncodings;
    static std::vector<std::string> printStack;

public:
    Sub(std::string _name, Sub* _parent, int _numArgs, int _numLocals) :
        // Initialize fields
        name(_name), parent(_parent), numArgs(_numArgs), numLocals(_numLocals) {

        // Initialize static_depth
        static_depth = (parent == nullptr) ? 0 : parent->static_depth + 1;

        if (parent != nullptr)
            parent->children.push_back(this); // If sub isn't main_, add this object to its parent's children
    }

    void call_()
    {
        bool visible = false;

        if (runtimeStack.empty() && parent == nullptr) // Ensure that main_ must be called first
        {
            display.push_back(0);
            visible = true;
        }

        else if (!runtimeStack.empty()) // If main_ is on the stack, check the called sub's visibility
        {
            // Get the index of the top sub on the stack
            int topSubIndex = 0;
            int max = 0;
            for (int i = display.size() - 1; i > 0; i--) // Iterate through display
            {
                max = std::max(display[i], display[i - 1]); // Grab the largest index
                if (max > topSubIndex)
                    topSubIndex = max;
            }


            // CHANGE THIS SO THAT IT WORKS WITH ALL STATIC ANCESTORS
            if (runtimeStack[topSubIndex] == (int)&parent->name) // If the top sub is the parent of the called sub (Case 1: Caller has a lower static depth)
            {
                display.push_back(runtimeStack.size()); // Add a block in the display that will point to the index of the called sub
                visible = true;
            }
            else
            {
                int topSubName = runtimeStack[topSubIndex]; // Store the encoded name of the top sub

                for (int i = 0; i < parent->children.size(); i++)  // Look through each of the siblings of the called sub
                {
                    if (topSubName == (int)&parent->children[i]->name) // If the top sub is a sibling of the called sub (Case 2: Caller has equal static depth)
                    {
                        display[static_depth] = runtimeStack.size(); // The block in the display that was pointing to the top sub will now point to the called sub
                        visible = true;
                        break;
                    }
                    
                    for (int j = 0; j < parent->children[i]->children.size(); j++)  // Look through each of the children of the current sibling
                    {
                        if (topSubName == (int)&parent->children[i]->children[j]->name) // If the top sub is a niece/nephew of the called sub (Case 3: Caller has higher static depth)
                        {
                            display[static_depth] = runtimeStack.size(); // The block in the display that was pointing to the top sub will now point to the called sub
                            visible = true;
                            break;
                        }
                    }
                }
            }
        }

        // If the sub is visible, create the ARI and push it onto the stack
        if (visible) {

            // Integer encoding of the subprogram name
            int nameEncoding = (int)&name;
            nameEncodings[nameEncoding] = name;
            printStack.push_back("Sub " + name);

            // Saved display link (The position/index in the runtimeStack that was stored in the display earlier in the call)
            int savedDisplayLink = display[static_depth];
            printStack.push_back("Saved Link: " + std::to_string(savedDisplayLink));

            // Dynamic link: (The position/index in the runtimeStack of the last element of the old top sub's ARI)
            int dynamicLink = runtimeStack.empty() ? -1 : runtimeStack.size() - 1;
            printStack.push_back("Dynamic Link: " + std::to_string(dynamicLink));

            runtimeStack.push_back(nameEncoding);
            runtimeStack.push_back(savedDisplayLink);
            runtimeStack.push_back(dynamicLink);

            // One integer element for each argument (I used the value 8 for arguments)
            for (int i = 0; i < numArgs; ++i)
            {
                runtimeStack.push_back(8);
                printStack.push_back("Arg: 8");
            }
                
            // One integer element for each local variable (I used the value 9 for local variables)
            for (int i = 0; i < numLocals; ++i)
            {
                runtimeStack.push_back(9);
                printStack.push_back("Local: 9");
            }

            // Print runtimeStack and display
            std::cout << "\nRuntime stack after calling subprogram " << name << ":\n";
            printRuntimeStack();
            std::cout << "\nDisplay after calling subprogram " << name << ":\n";
            printDisplay();
        }
        // If the sub is not visible, print an error message
        else {
            std::cout << "\nERROR: Sub " << name << " is not in the scope." << std::endl;
            return;
        }
    }

    void return_() {
        // If the sub isn't empty
        if (!runtimeStack.empty()) {

            // Integer encoding of the subprogram name
            int nameEncoding = (int)&name;

            // Get the index of the top sub on the stack
            int topSubIndex = 0;
            int max = 0;
            for (int i = display.size() - 1; i > 0; i--) // Iterate through display
            {
                max = std::max(display[i], display[i - 1]); // Grab the largest index
                if (max > topSubIndex)
                    topSubIndex = max;
            }

            int topSubName = runtimeStack[topSubIndex]; // Store the encoded name of the top sub

            // If the name of the top sub matches the name of the called sub
            if (topSubName == (int)&name) 
            {
                // Remove activation record from runtime stack
                for (int i = 0; i < numArgs + numLocals + 3; ++i) {
                    runtimeStack.pop_back();
                    printStack.pop_back();
                }

                // Erase the block with the top sub from the display
                display.erase(std::remove(display.begin(), display.end(), topSubIndex), display.end());

                // Print runtime stack and display
                std::cout << "\nRuntime stack after returning from subprogram " << name << ":\n";
                printRuntimeStack();
                std::cout << "\nDisplay after returning from subprogram " << name << ":\n";
                printDisplay();
            }
            else // Print an error message

            {
                std::cout << "\nERROR: Sub " << name << " is not the last sub in the stack." << std::endl;
            }
        }
        // Print an error message
        else {
            std::cout << "\nERROR: There are no subprograms on the stack." << std::endl;
        }
    }

    void printRuntimeStack() {
        for (int i = printStack.size() - 1; i >= 0; i--)
        {
            std::cout << i << ": " << printStack[i] << std::endl;
        }
            
    }

    void printDisplay() {
        for (int i = display.size() - 1; i >= 0; i--) {
            std::cout << i << ": Index " << display[i] << std::endl;
        }
    }
};

std::vector<int> Sub::runtimeStack;
std::vector<int> Sub::display;
std::unordered_map<int, std::string> Sub::nameEncodings;
std::vector<std::string> Sub::printStack;

int main() {
    // Declare Sub objects
    Sub main_("main_", nullptr, 0, 1); // 0
    Sub bigsub("BIGSUB", &main_, 1, 0); // 1
    Sub sub1("Sub1", &bigsub, 1, 2); // 2
    Sub sub2("Sub2", &bigsub, 2, 1);  // 2
    Sub sub3("Sub3", &sub2, 3, 3); // 3

    // Provide a sufficient number of suitable calls of their call_ and return_ 
    // methods to demonstrate in full the rules of static scoping visibility    
    
    
    main_.call_();
    std::cout << "\n==========================================================\n";

    bigsub.call_();
    std::cout << "\n==========================================================\n";

    sub1.call_();
    std::cout << "\n==========================================================\n";

    sub2.call_();
    std::cout << "\n==========================================================\n";

    sub3.call_();
    std::cout << "\n==========================================================\n";

    sub1.call_();
    std::cout << "\n==========================================================\n";

    //////////////////////////////////////////////////////////////////////////////////
    
    //sub3.return_();
    //std::cout << "\n==========================================================\n";

    //sub2.return_();
    //std::cout << "\n==========================================================\n";

    sub1.return_();
    //std::cout << "\n==========================================================\n";

    //bigsub.return_();
    //std::cout << "\n==========================================================\n";

    //main_.return_();
}
