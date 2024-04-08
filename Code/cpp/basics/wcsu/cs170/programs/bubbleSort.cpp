// SelectionSort.cpp
//
// This program demonstrates the selection sort algorithm for sorting an array.
//

#include <iostream>
#include <iomanip>
using namespace std;

const int SIZE = 100;

void inputValues (int values[], int &n);
void outputValues (int values[], int n);
void bubbleSort (int values[], int n);

void main ()
{
	int count;
	int data[SIZE];

	// Prompt for and enter values.

	cout << "This program demonstrates the bublesort.\n";
    inputValues (data, count);
	cout << endl << endl << count << " values were entered." << endl << endl;
    cout << "The orginal array is:" << endl;
    outputValues (data, count);

    // Do the sort and output the results.

    bubbleSort (data, count);
    cout << endl << "The sorted array is:" << endl;
    outputValues (data, count);

}

void inputValues (int values[], int &n)
// This function inputs the values and determines how many values were entered.
{
    int value;

    n = 0;
	cout << "Please enter the values, using CTRL-Z to end input.\n\n";
	cout << "Value (CTRL-Z to end)? ";
	while ((cin >> value) && (n < SIZE))
	{
		values[n++] = value;
		cout << "Value (CTRL-Z to end)? ";
	}
}

void outputValues (int values[], int n)
// This function outputs the values in the array.
{
   int i;

   for (i=0; i<n; i++)
	   cout << values[i] << ' ';
   cout << endl;
}

// This function performs the bubble sort algorithm on the first n values in
// the array values.
void bubbleSort (int values[], int n)
{
   int endLoc, index, temp;
   for (endLoc = n-1; endLoc >= 0; endLoc--)
   {
      bool swapped = false;
      for (index=0; index < endLoc; index++)
		  if (values[index] > values[index+1]){
			// swap the values at index and index + 1
            temp = values[index];
			values[index] = values[index+1];
			values[index+1] = temp;
			// and note that there was a swap
			swapped = true;
		  }
	  if (! swapped)
		  break;
   }
}

