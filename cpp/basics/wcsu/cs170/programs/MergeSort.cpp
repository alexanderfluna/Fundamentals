// MergeSort.cpp
//
// This program demonstrates the merge sort algorithm for sorting an array.
//


#include <iostream>
#include <iomanip>
using namespace std;

const int SIZE = 100;

void inputValues (int values[], int &n);
void outputValues (int values[], int n);
void Merge (int values[], int low, int mid, int high);
void MergeSort (int values[], int low, int high);

void main ()
{
	int count;
	int data[SIZE];

	// Prompt for and enter values.

	cout << "This program demonstrates the merge sort.\n";
    inputValues (data, count);
	cout << endl << endl << count << " values were entered." << endl << endl;
    cout << "The orginal array is:" << endl;
    outputValues (data, count);

    // Do the sort and output the results.

    MergeSort (data, 0, count - 1);
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

   for (i=0; i<n; i++) cout << values[i] << ' ';
   cout << endl;
}

void Merge (int values[], int low, int mid, int high)
// This routine does the merging of the two half lists that are
// sorted. The first list is from values[low] to values[mid],
// the second list is from values[mid+1] to values[high].

{
	int first_half_loc = low, second_half_loc = mid + 1;
	int merged_list_loc = low;
	static int merged_list[SIZE];

	// While each half list still has at least one value in it, there are
	// numbers to compare. Take the smaller number and put it in the merged
	// list, updating the location pointers only for the half list that the
	// number was taken from and the merged list.

	while ((first_half_loc <= mid) && (second_half_loc <= high))
		if (values[first_half_loc] <= values[second_half_loc])
			merged_list[merged_list_loc++] = values[first_half_loc++];
		else
			merged_list[merged_list_loc++] = values[second_half_loc++];

	// One half list is empty and the other half list has at least one data value
	// still in it. Move the remaining values in the latter half list to the merged
	// list. Note that only one of the following two while loops will be executed.

	while (first_half_loc <= mid)
		merged_list[merged_list_loc++] = values[first_half_loc++];
	while (second_half_loc <= high)
		merged_list[merged_list_loc++] = values[second_half_loc++];

	// The merged (and sorted) data is now in merged_list. It needs to be put back
	// in the parameter list.

	for (int i=low; i<=high; i++) values[i] = merged_list[i];
}

void MergeSort (int values[], int low, int high)
// This function sorts the items in array values via the merge sort algorithm.
// It sorts the part of the list whose subscripts are in the range [low, high].
{
	int mid;

	if (low < high)
	{
		mid = (low + high) / 2;
		MergeSort (values, low, mid);
		MergeSort (values, mid + 1 , high);
		Merge (values, low, mid, high);
	}
}

