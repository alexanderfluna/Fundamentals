#include <iostream>
using namespace std;

// Determines the size of the 2d and 1d arrays
#define ROW 100
#define COLUMN 100
#define SIZE (ROW*COLUMN)

int *makeOneDimArray(int arr2d[ROW][COLUMN]);
double measure(int *arr1d, void(*func)(int*));
void selectionSort(int *arr1d);
void bubbleSort(int *arr1d);
void mergeSort(int *arr1d);
void mergeSorting(int *arr1d, int low, int high);
void merge(int *arr1d, int low, int mid, int high);

int main()
{
    cout << "This program will create a two dimensional array and copy it into "
            "a one dimensional array. Then, it will use three different sorting "
            "methods to sort the array and print the time it took in milliseconds.\n" << endl;

    int arr2d[ROW][COLUMN];
    double milliseconds;

    // Populates the 2d array with random numbers between 1-100
    srand(time(0));
    for (int i = 0; i < ROW; i++)
    {
        for (int j = 0; j < COLUMN; j++)
        {
            arr2d[i][j] = rand() % (100) + 1;
        }
    }

    // Creates new 1d array, calls function to sort it, and returns time it took
    int *arr1d = makeOneDimArray(arr2d);
    cout << "Selection sort:" << endl;
    milliseconds = measure(arr1d, selectionSort);
    cout << "It took " << milliseconds << " milliseconds to sort\n" << endl;

    arr1d = makeOneDimArray(arr2d);
    cout << "Bubble sort: "<< endl;
    milliseconds = measure(arr1d, bubbleSort);
    cout << "It took " << milliseconds << " milliseconds to sort\n" << endl;

    arr1d = makeOneDimArray(arr2d);
    cout << "Merge sort: "<< endl;
    milliseconds = measure(arr1d, mergeSort);
    cout << "It took " << milliseconds << " milliseconds to sort\n" << endl;
}

/** 
    Copies 2d array into a 1d array
    @param arr2d 2d array
    @return the 1d array
*/
int *makeOneDimArray(int arr2d[ROW][COLUMN])
{
    // Initializes dynamically allocated 1d array
    int *arr1d = new int[SIZE];

    // Copies elements from 2d array into 1d array
    int k = 0;
    for (int i = 0; i < ROW; i++)
    {
        for (int j = 0; j < COLUMN; j++)
        {
            arr1d[k++] = arr2d[i][j];
        }
    }

    return arr1d;
}

/** 
    Calls sorting function to sort 1d array & returns the time it took
    @param arr1d dynamically allocated 1d array
    @param func sorting function
    @return time that it took to sort the 1d array in milliseconds
*/
double measure(int *arr1d, void(*func)(int*))
{
    clock_t start, end, clockTicks;
    start = clock();
    (*func)(arr1d);
    end = clock();
    clockTicks = end - start;
    double milliseconds = (clockTicks / (double) CLOCKS_PER_SEC) * 1000;
    return milliseconds;   
}

/** 
    Uses selection sort to sort the 1d array
    The code was taken from Arrays.pptx in the N Drive
    @param arr1d dynamically allocated 1d array
*/
void selectionSort(int *arr1d)
{
    int loc, index, min, temp;
    for (loc = 0; loc < SIZE-1; loc++)
    {
        min = loc;

        for (index = loc+1; index < SIZE; index++)
        {
            if (arr1d[index] < arr1d[min])
            {
                min = index;
            }
        }
        temp = arr1d[loc];
        arr1d[loc] = arr1d[min];
        arr1d[min] = temp;
    }
}

/** 
    Uses bubble sort to sort the 1d array
    The code was taken from bubbleSort.cpp in the N Drive
    @param arr1d dynamically allocated 1d array
*/
void bubbleSort(int *arr1d)
{
   int endLoc, index, temp;
   for (endLoc = SIZE-1; endLoc >= 0; endLoc--)
   {
      bool swapped = false;
      for (index=0; index < endLoc; index++)
		  if (arr1d[index] > arr1d[index+1]){
            temp = arr1d[index];
			arr1d[index] = arr1d[index+1];
			arr1d[index+1] = temp;
			swapped = true;
		  }
	  if (! swapped)
		  break;
   }
}

/** 
    Intermediate function that will call mergeSorting()
    @param arr1d dynamically allocated 1d array
*/
void mergeSort(int *arr1d)
{
    mergeSorting(arr1d, 0, SIZE-1);
}

/** 
    Uses merge sort to sort the 1d array
    The code was taken from MergeSort.cpp in the N Drive
    @param arr1d dynamically allocated 1d array
    @param low the smallest value within the elements
    @param high the largest value within the elements
*/
void mergeSorting(int *arr1d, int low, int high)
{
	int mid;

	if (low < high)
	{
		mid = (low + high) / 2;
		mergeSorting (arr1d, low, mid);
		mergeSorting (arr1d, mid+1, high);
		merge (arr1d, low, mid, high);
	}
}

/** 
    Uses merge sort to sort the 1d array
    The code was taken from MergeSort.cpp in the N Drive
    @param arr1d dynamically allocated 1d array
    @param low the smallest value within the elements
    @param mid the median within the elements
    @param high the largest value within the elements
*/
void merge (int *arr1d, int low, int mid, int high)
{
	int first_half_loc = low, second_half_loc = mid + 1;
	int merged_list_loc = low;
	static int merged_list[SIZE];

	// While each half list still has at least one value in it, there are
	// numbers to compare. Take the smaller number and put it in the merged
	// list, updating the location pointers only for the half list that the
	// number was taken from and the merged list.

	while ((first_half_loc <= mid) && (second_half_loc <= high))
		if (arr1d[first_half_loc] <= arr1d[second_half_loc])
			merged_list[merged_list_loc++] = arr1d[first_half_loc++];
		else
			merged_list[merged_list_loc++] = arr1d[second_half_loc++];

	// One half list is empty and the other half list has at least one data value
	// still in it. Move the remaining values in the latter half list to the merged
	// list. Note that only one of the following two while loops will be executed.

	while (first_half_loc <= mid)
		merged_list[merged_list_loc++] = arr1d[first_half_loc++];
	while (second_half_loc <= high)
		merged_list[merged_list_loc++] = arr1d[second_half_loc++];

	// The merged (and sorted) data is now in merged_list. It needs to be put back
	// in the parameter list.

	for (int i=low; i<=high; i++) arr1d[i] = merged_list[i];
}