// Alexander Luna | Assignemnt 1 | Problem3-2.cpp
#include <iostream>
using namespace System;

enum class Day {
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
};

// Case 1: Using enumeration type as class member
ref class Class {
public:
    Day day;
    Class(Day day) : day(day) {}
};

void printDay(Day day);


int main(array<System::String^>^ args) {

    // Case 1: Using enumeration type as class member
    Class^ myClass = gcnew Class(Day::Thursday);

    // Case 2: Assigning enumeration values
    Day day = Day::Monday;

    // Case 3: Using enumeration values in switch statement
    switch (day) {
        case Day::Sunday:
            Console::WriteLine("Sunday");
            break;
        case Day::Monday:
            Console::WriteLine("Monday");
            break;
        case Day::Tuesday:
            Console::WriteLine("Tuesday");
            break;
        case Day::Wednesday:
            Console::WriteLine("Wednesday");
            break;
        case Day::Thursday:
            Console::WriteLine("Thursday");
            break;
        case Day::Friday:
            Console::WriteLine("Friday");
            break;
        case Day::Saturday:
            Console::WriteLine("Saturday");
            break;
        default:
            Console::WriteLine("Invalid day.");
    }

    // Case 4: Using enumeration type as function parameter
    printDay(Day::Friday);

    // Case 5: Error handling for invalid enumeration value
    if (day == Day::Saturday)
        Console::WriteLine("It is Saturday");
    else
        Console::WriteLine("It is not Saturday.");

    // Case 6: Comparison of enumeration values
    Day day2 = Day::Monday;
    if (day == day2)
        Console::WriteLine("It is the same day.");
    else
        Console::WriteLine("I iss not the same day.");

    // Case 7: Enumerations in arrays
    array<Day>^ daysOfWeek = { Day::Sunday, Day::Monday, Day::Tuesday, Day::Wednesday, Day::Thursday, Day::Friday, Day::Saturday };

    // Case 8: Using enumeration types in loops
    for (int i = 0; i < 7; i++) {
        printDay(daysOfWeek[i]);
    }

    // Case 9: Incrementing the enumeration value
    day = static_cast<Day>(static_cast<int>(day) + 1);

    // Case 10: Combining enum values using bitwise OR
    enum class Permission {
        Read = 1,
        Write = 2,
    };

    Permission userPermissions = static_cast<Permission>(static_cast<int>(Permission::Read) | static_cast<int>(Permission::Write));

    if ((static_cast<int>(userPermissions) & static_cast<int>(Permission::Read)))
        Console::WriteLine("User has read permission.");

    if ((static_cast<int>(userPermissions) & static_cast<int>(Permission::Write)))
        Console::WriteLine("User has write permission.");
    
    return 0;
}

// Case 4: Using enumeration type as function parameter
void printDay(Day day) {
    switch (day) {
    case Day::Sunday:
        Console::WriteLine("Sunday");
        break;
    case Day::Monday:
        Console::WriteLine("Monday");
        break;
    case Day::Tuesday:
        Console::WriteLine("Tuesday");
        break;
    case Day::Wednesday:
        Console::WriteLine("Wednesday");
        break;
    case Day::Thursday:
        Console::WriteLine("Thursday");
        break;
    case Day::Friday:
        Console::WriteLine("Friday");
        break;
    case Day::Saturday:
        Console::WriteLine("Saturday");
        break;
    default:
        Console::WriteLine("Invalid day.");
    }
}
