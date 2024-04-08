#include <iostream>
#include "product.h"

using namespace std;

Product::Product()
{  
   price = 1;
   score = 0;
}

void Product::read()
{  
   cout << "Please enter the model name: ";
   getline(cin, name);
   cout << "Please enter the price: ";
   cin >> price;
   cout << "Please enter the score: ";
   cin >> score;
   string remainder; // Read remainder of line
   getline(cin, remainder);
}

bool Product::is_better_than(Product b) const
{  
   if (price == 0) return true;
   if (b.price == 0) return false;
   return score / price > b.score / b.price;
}

void Product::print() const
{  
   cout << name
      << " Price: " << price
      << " Score: " << score;
}

bool Product::operator > (Product other){
	if (price == 0) return true;
	if (other.price == 0) return false;
	return score / price > other.score / other.price;
}

ostream& operator << (ostream& out, Product p){
	
	out << "[" << p.name << ", " << p.price << ", "
		<< p.score << "]";
	return out;
}

