// FILE: QuickSort.cpp
// An implementation of the algorithm of the quicksort function
// described in Data Structurs and Other Objects by Savitch et al.

#include <algorithm>  // Provides swap
#include <cstdlib>    // Provides EXIT_SUCCESS, size_t
#include <iostream>   // Provides cout and cin
#include <ctime>
using namespace std;

// PROTOTYPES of the functions used in this test program:
// Precondition: data is an array with at least n components.
// Postcondition: The elements of data have been rearranged so
// that data[0] <= data[1] <= ... <= data[n-1].
void quicksort(int data[ ], size_t n);

// Precondition: n > 1, and data is an array (or subarray)
// with at least n elements.
// Postcondition: The function has selected some "pivot value"
// that occurs in data[0]..data[n-1]. The elements of data
// have then been rearranged, and the pivot index set so that:
//   -- data[pivot_index] is equal to the pivot;
//   -- Each item before data[pivot_index] is <= the pivot;
//   -- Each item after data[pivot_index] is >= the pivot.
void partition(int data[ ], size_t n, size_t& pivot_index);


int main()
{
	int randomArray[10];
	int bestCaseArray[10] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	int worstCaseArray[10] = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
	
	srand((int)time(0));
	for (int i = 0; i < 10; i++) {
		randomArray[i] = rand() % 100;
	}
	cout << "\nBefore the sort:" << endl;
	cout << endl << "Random Array: ";
	for (int i = 0; i < 10; i++) {
		cout << randomArray[i] << "  ";
	}
	cout << " " << endl << "Best Case Array: ";
	for (int i = 0; i < 10; i++) {
		cout << bestCaseArray[i] << "  ";
	}
	cout << " " << endl << "Worst Case Array: ";
	for (int i = 0; i < 10; i++) {
		cout << worstCaseArray[i] << "  ";
	}
	quicksort(randomArray, 10);
	quicksort(bestCaseArray, 10);
	quicksort(worstCaseArray, 10);
	cout << endl;
	cout << "\nAfter the sort:" << endl;
	cout << endl <<  "Random Array: ";
	for (int i = 0; i < 10; i++) {
		cout << randomArray[i] << "  ";
	}
	cout << " " << endl << "Best Case Array: ";
	for (int i = 0; i < 10; i++) {
		cout << bestCaseArray[i] << "  ";
	}
	cout << " " << endl << "Worst Case Array: ";
	for (int i = 0; i < 10; i++) {
		cout << worstCaseArray[i] << "  ";
	}
	cout <<  endl;
}
void quicksort(int data[ ], size_t n)
// Library facilities used: cstdlib
{
    size_t pivot_index=0; // Array index for the pivot element
    size_t n1;  // Number of elements before the pivot element
    size_t n2;  // Number of elements after the pivot element

    if (n > 1)
    {
        // Partition the array, and set the pivot index.
        partition(data, n, pivot_index);

        // Compute the sizes of the subarrays.
        n1 = pivot_index;
        n2 = n - n1 - 1;

        // Recursive calls will now sort the subarrays.
        quicksort(data, n1);
        quicksort((data + pivot_index + 1), n2);
    }
}

void partition(int data[ ], size_t n, size_t& pivot_index)
{	
	int too_big_index, too_small_index, temp;
	
	// Place pivot in position 0  --
	// Will swap it with the element that is currently at position 0
	temp = data[0];
	data[0] = data[pivot_index];
	//data[pivot_index] = data[0];
	data[pivot_index] = temp;
	pivot_index = 0;

	too_big_index = 1;
	too_small_index = n-1;
	// NOTES FROM THE IMPLEMENTOR:
	// How the partition works on small arrays:
	//
	// Notice that n=0 is not permitted by the precondition.
	//

	// If n=1, then too_big_index is initialized as 1, and too_small_index is
	// initialized as 0. Therefore, the body of the loop is never executed,
	// and after the loop pivot_index is set to zero.
	while (too_big_index <= too_small_index) {
		// If n=2, then both too_big_index and too_small_index are initialized as 1.
		// The loop is entered, and there are two cases to consider:
		// -- if data[1] <= pivot, then too_big_index increases to 2, and
		//    too_small_index stays at 1. The if-statement at the bottom of the loop
		//    is then skipped, and after the loop we copy data[1] down to data[0],
		//    and copy the pivot into data[0]. Thus, the smaller element is in
		//    data[0], and the larger element (the pivot) is in data[1].
		// -- if data[1] > pivot, then too_big_index stays at 1, and too_small_index
		//    decreases to 0. The if-statement at the bottom of the loop is then
		//    skipped, and after the loop we end up copying the pivot onto data[0]
		//    (leaving data[1] alone). Thus, the smaller element (the pivot) remains
		//    at data[0], leaving the larger element at data[1].
		while (data[too_big_index] <= data[0])
		{
			++too_big_index;
		}
		while (data[too_small_index] > data[0])
		{
			--too_small_index;
		}
		// cannot move indexes further -- 
		// data @ too_small is <= pivot
		// data @ too_big is > pivot
		// -- swap them to continue
		// but only if areas for big and small numbers 
		// don't overlap
		if (too_big_index < too_small_index){
			temp = data[too_big_index];
			data[too_big_index] = data[too_small_index];
			data[too_small_index] = temp;
		}
	}

	// Now place the pivot in its correct position.
	// It is currently at position 0.
	// too_small_index points to an element <= pivot.
	// Swap pivot with this element
	temp = data[0];
	data[0] = data[too_small_index];
	data[too_small_index] = temp;
	pivot_index = too_small_index;
}
