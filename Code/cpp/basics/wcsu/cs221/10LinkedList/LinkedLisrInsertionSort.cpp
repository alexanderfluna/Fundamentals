#include <string>
#include <list>
#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;
void insertionSort(list<int>&);
void print(list<int>);
void printArrow ();
int main()
{
	srand(time(0));
	list<int> numbers;

	for (int i = 0; i < 10; i++){
		int num = rand() % 10;
		numbers.push_back(num);
	}
	cout << "Unsorted list: " << endl;
	print(numbers);
	cout << endl;
	
	insertionSort(numbers);

	cout << "\nSorted list: " << endl;
	print(numbers);
	cout << endl;
}

void insertionSort(list<int> &numbers){
	cout << "Start of insertion sort" << endl;	
	list<int>::iterator firstOutOfOrder = numbers.begin();
	list<int>::iterator currentSorted = numbers.end();	
	int counter = 0;
	while (firstOutOfOrder != numbers.end()){
		cout << "The next element to insert is " << *firstOutOfOrder << ". ";
		currentSorted = numbers.begin();		
		while (currentSorted != firstOutOfOrder){
			if (*currentSorted <= *firstOutOfOrder)
				++currentSorted;
			else {
				cout << "Will insert " << *firstOutOfOrder << " before " << *currentSorted << ". ";
				break;
			}			
		}		
		// currentSorted points to the first element larger than *firstOutOfOrder
		// need to insert *nextUnsorted before currentSorted
		// and remove at nextUnsorted.
		numbers.insert(currentSorted, *firstOutOfOrder);
		// need to remember the next position in order to set nextUnsorted after erase
		list<int>::iterator temp;
		temp = firstOutOfOrder;
		if (temp != numbers.end()){		// Otherwise we are done.This is the last iteration.
			temp++;
		}
		numbers.erase(firstOutOfOrder); //now nextUnsorted has an invalid value
		cout << "After insertion: " << endl;
		print(numbers);		
		printArrow();
		cout << endl;
		firstOutOfOrder = temp;
		
		if (firstOutOfOrder == numbers.end()){
			print(numbers);
			printArrow();
			cout << "End of insertion sort\n" << endl;
		}
		
	}		
}

void print(list<int> l){	
	list<int>::iterator pos = l.begin();
	while (pos != l.end()){
		cout << *pos << " ";
		pos++;
	}
	cout << endl;
}

void printArrow(){
	static int counter = 0;
	for (int i = 0; i < counter; i++)
		cout << " ";
	cout << "^" << endl;
	counter += 2;
}
   
