#include <iostream>
#include <chrono>
#include <ctime>
using namespace std;

// Define an enumeration type for days of the week
enum Day {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
};

// Function to convert tm_day to Day enum
Day tmDayToDayOfWeek(int tm_day) {
    switch (tm_day) {
    case 0:
        return Sunday;
    case 1:
        return Monday;
    case 2:
        return Tuesday;
    case 3:
        return Wednesday;
    case 4:
        return Thursday;
    case 5:
        return Friday;
    case 6:
        return Saturday;
    default:
        return Monday; // Default to Monday if the day is invalid
    }
}

// Function to print the day of the week
void printDayOfWeek(Day today) {
    switch (today) {
    case Monday:
        cout << "Today is Monday." << endl;
        break;
    case Tuesday:
        cout << "Today is Tuesday." << endl;
        break;
    case Wednesday:
        cout << "Today is Wednesday." << endl;
        break;
    case Thursday:
        cout << "Today is Thursday." << endl;
        break;
    case Friday:
        cout << "Today is Friday." << endl;
        break;
    case Saturday:
        cout << "Today is Saturday." << endl;
        break;
    case Sunday:
        cout << "Today is Sunday." << endl;
        break;
    }
}

// Define an alias for chrono::system_clock::time_point
typedef chrono::system_clock::time_point time_point;

int main() {
    // Get current time
    time_point now = chrono::system_clock::now();
    time_t time_now = chrono::system_clock::to_time_t(now);

    // Convert current time to struct tm using localtime_s
    struct tm time_info;
    localtime_s(&time_info, &time_now);

    // Get day of the week (0 for Sunday, 1 for Monday, ..., 6 for Saturday)
    int day_of_week = time_info.tm_wday;

    // Convert day of the week to Day enum
    Day today = tmDayToDayOfWeek(day_of_week);

    // Print the day of the week
    printDayOfWeek(today);

    return 0;
}
