/* Problem2.cpp | Assignment 3 | Alexander Luna | May 11, 2021
This program will maintain a binary random-access file hardware.dat and allow 
the user to initialize the file to 100 empty records, input the data concerning
each tool, list all tools, delete a record for a tool, and to update any
information in the file*/

#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>
#include <cstring>
using namespace std;
 
class Hardware
{
public:
    int recordNumber;
    char toolName[100];
    int quantity;
    double cost;
    bool exists;
    /**
        Initializes hardware.dat with 100 empty records
    */
    void initializeRecords();
    /**
        Updates the information of anything in the file
    */
    void updateInformation();
    /**
        Lists all the items in the file
    */
    void listItems() const;
};
Hardware records[99];
 
int main()
{
    // Loads array with values 1-100
    int recordNumber;
    for(int i = 0; i < 100; i++)
    {
        recordNumber++;
        records[i].recordNumber = recordNumber; 
    }
    Hardware hardware;

    // User's menu
    int choice; 
    while(true)
    {
        cout << "\nChoose an option" << endl;
        cout << "1: Input the data for a new tool or update an existing tool" << endl;
        cout << "2: Delete an existing tool" << endl;
        cout << "3: List all tools" << endl;
        cout << "4: Initialize the file to 100 empty records" << endl;
        cout << "5: Exit program" << endl;
        cin >> choice;
        int recordNumber;
        switch (choice)
        {
            case 1:
                cout << "Enter a record number from 1 to 100" << endl;
                cin >> recordNumber;
                cout << "Enter tool name (Use underscore for space)" << endl; 
                cin >> records[recordNumber-1].toolName;
                cout << "Enter quantity" << endl;
                cin >> records[recordNumber-1].quantity;
                cout << "Enter cost" << endl;
                cin >> records[recordNumber-1].cost;
                records[recordNumber-1].exists = 1;
                hardware.updateInformation();
                break;

            case 2:
                cout << "Enter a record number from 1 to 100" << endl;
                cin >> recordNumber;
                strcpy(records[recordNumber-1].toolName, "");
                records[recordNumber-1].quantity = 0;
                records[recordNumber-1].cost = 0; 
                records[recordNumber-1].exists = 0;
                hardware.updateInformation();
                break;

            case 3:
                hardware.listItems();
                break;

            case 4:
                hardware.initializeRecords();
                break;

            case 5:
                return 0;
        }  
    }
}

void Hardware::initializeRecords()
{
    fstream file("hardware.dat", ios::out|ios::binary);
    file.write( (char*)&records, sizeof(Hardware)*100 );
    file.close();
}
 
void Hardware::updateInformation()
{ 
    fstream file("hardware.dat", ios::out|ios::binary);
    file.write( (char*)&records, sizeof(Hardware)*100 );
    file.close();
}
 
void Hardware::listItems() const
{
    cout << setw(15) << "Record #"
    << setw(30) << "Tool name"
    << setw(15) << "Quantity"
    << setw(15) << "Cost" << endl;

    cout << "----------------------------------------------------------------------------" << endl;

    fstream file("hardware.dat", ios::in|ios::out|ios::binary); 

    Hardware item;
    while(file.read( (char*)&item, sizeof(Hardware)))
    { 
        if (item.exists)
        {
            cout << setw(15) << item.recordNumber
            << setw(30) << item.toolName
            << setw(15) << item.quantity
            << setw(15) << item.cost << endl;
        }
    }
    file.close();
}