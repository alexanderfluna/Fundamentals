// Alexander Luna
#include <string>
#include <list>
#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;
void insertionSort(list<int>&);
void print(list<int>);
int main()
{
	srand(time(0));
	list<int> numbers;

	for (int i = 0; i < 10; i++){
		int num = rand() % 100;
		numbers.push_back(num);
	}
	cout << "Unsorted list: " << endl;
	print(numbers);
	
	insertionSort(numbers);

	cout << "\nSorted list: " << endl;
	print(numbers);
}

void insertionSort(list<int> &numbers){
	list<int>::iterator firstOutOfOrder = numbers.begin();
	list<int>::iterator currentSorted = numbers.end();	
	int counter = 0;
	while (firstOutOfOrder != numbers.end()){
		currentSorted = numbers.begin();		
		while (currentSorted != firstOutOfOrder){
			if (*currentSorted <= *firstOutOfOrder)
				++currentSorted;
			else {
				break;
			}			
		}		
		numbers.insert(currentSorted, *firstOutOfOrder);
		list<int>::iterator temp;
		temp = firstOutOfOrder;
		if (temp != numbers.end()){
			temp++;
		}
		numbers.erase(firstOutOfOrder);
		firstOutOfOrder = temp;
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