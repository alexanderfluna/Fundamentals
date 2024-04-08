// This program searches a text file to find the GPA of a student whose ID
// number is known. The data file is named 'students.dat' and the data is
// arranged one student per line with each line containing an ID number
// (5 digits), GPA, credits earned, and name.
//

#include <iostream>
#include <fstream>
#include <sstream>
using namespace std;

const int namelength = 20;
const char filename[] = "students.dat";

void main ()
{
	ifstream dataFile;
	int IDtoFind, id, credits;
	double gpa;
	char space, name[namelength];

	// Open the data file.

	dataFile.open (filename);
	if (dataFile.fail())
	{
		cout << "File '" << filename << "' not found." << endl;
        cin.get();
		exit (-1);
	}

	// Determine the ID to search for. Entering 0 will end the program.

	cout << "Enter the ID number to search for (0 to end): ";
	cin >> IDtoFind;
	while (IDtoFind != 0)
	{

		// Keep reading the data file until we find the student we're looking
		// for or we reach the end of the file.

         // dataFile >> id >> gpa >> credits;
		char line [80];
		dataFile.getline(line, 80);
		while (!dataFile.eof())
		{
			stringstream in;
			in << line;
			in.seekg(0);
			in >> id >> gpa >> credits;
            in.get (space);
 		    in.getline (name, namelength);
			cout << "Reading " << id << " " << gpa << " " << credits
				<< " " << name << endl;
			in.seekp(0);
			dataFile.getline(line, 80);
			if (id == IDtoFind)	break;
    		//dataFile >> id >> gpa >> credits;
		}

		// Print results on the screen.

		cout << endl;
		if (dataFile.eof())
		{
			cout << "Student with ID number " << IDtoFind << " not found." << endl;
			dataFile.clear();  // clear the state bits so eof is not set any more
		}
		else
		{
			cout << "Name    : " << name << endl;
			cout << "ID      : " << id << endl;
			cout << "GPA     : " << gpa << endl;
			cout << "Credits : " << credits << endl;
		}

		// Reposition file at beginning so next search can be made.

		dataFile.seekg (0, ios::beg);

		// Get next ID to search for. A zero will stop the program.

		cout << endl;
		cout << "Enter the ID number to search for (0 to end): ";
		cin >> IDtoFind;
	}

	// Close the file and exit the program.

	dataFile.close ();
}
