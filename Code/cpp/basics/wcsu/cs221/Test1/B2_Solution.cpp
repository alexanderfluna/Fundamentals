#include <iostream>
#include <string>
#include <list>

using namespace std;

void getInput(list<string>&);
void printList(list<string>, list<string>::iterator from, 
	                                  list<string>::iterator to);
void insertSort(list<string>&);

int main() 
{
	list<string> theList;
	getInput(theList);
	cout << "Insertion Sort, original list is ";
	printList(theList, theList.begin(), theList.end());
	insertSort(theList);
	cout << "The sorted list is ";
	printList(theList,theList.begin(), theList.end() );
	return 0;
}

void insertSort(list<string>& aList){
	//iterator over unsorted part
	list<string>::iterator firstUnsorted = aList.begin();
	//The beginning of the unsorted part is the second element
	firstUnsorted++;
	while (firstUnsorted != aList.end()){
		cout << "Sorted part ";
		printList(aList, aList.begin(), firstUnsorted);
		cout << "Unsorted part ";
		printList(aList, firstUnsorted, aList.end());

		//iterator to move down the sorted part
		list<string>::iterator sorted = firstUnsorted;
		// Find the correct position and insert first unsorted element
		while (sorted != aList.begin()) {
			//going down
			sorted--;
			if (*firstUnsorted > *sorted){
				// should insert above this sorted element
				// but need to point to the first larger
				sorted++;
				
				if (sorted == firstUnsorted){
					//Unsorted element is larger than all sorted. 
					//Will remains in place, just increment iterator.
					firstUnsorted++;
				}
				else{
					//insert in the new position and remove from the old
					aList.insert(sorted, *firstUnsorted);
					firstUnsorted = aList.erase(firstUnsorted);
					//iterator now points to the position after the erased element
					//no need to increment firstUnsorted
				}
				//Insertion done. No need to look further
				break;
			}// end of if(*firstUnsorted < *sorted)

		} //end of while (sorted != aList.begin())

		// If sorted points to the beginning, there was no
		// insertion - must insert in the beginning. 
		if (sorted == aList.begin()){
			aList.insert(sorted, *firstUnsorted);
			firstUnsorted = aList.erase(firstUnsorted);
		}
		
		if (firstUnsorted == aList.end()){			
			cout << "End of sorting. The list is ";
			printList(aList, aList.begin(), aList.end());
			system("pause");
			return;
		}
		system("pause");
	}
}
	
	
//Get the list of strings to be sorted
void getInput(list<string> &namelist)
{
	string input;
	bool i= true;
	int num = 1;
	
	cout << "Input a string (^Z to end): " << endl;
	do {
		cout << num << ". ";
		cin >> input;
		if (cin.eof())
			break;
		namelist.push_back(input);
		num++;
	} while (true);
}

//Print a portion of a list
void printList(list<string> alist, list<string>::iterator from, 
	                                       list<string>::iterator to)
{
	for (list<string>::iterator it = from; it != to; ++it)
		cout << ' ' << *it;
	cout << '\n';
}
