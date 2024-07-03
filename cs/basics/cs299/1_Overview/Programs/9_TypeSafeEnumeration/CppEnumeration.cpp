# include <iostream>
using namespace std;

// declares the enum
enum Volume
{
   Low,
   Medium,
   High
};
 
int main() {    
   // create and initialize instance of enum type
  Volume myVolume = Medium;
  
  // make decision based on enum value
  switch (myVolume)
  {
     case Low:
        cout << "The volume has been turned Down."<< endl;
        break;
     case Medium:
        cout << "The volume is in the middle." << endl;
        break;
     case High:
        cout << "The volume has been turned up." << endl;
        break;
  }

  //int n = Low + Medium - 2 + High * 3;
  //Volume temp = (Volume) n;
  cout << myVolume << endl;
  //cout << temp << endl;
}
