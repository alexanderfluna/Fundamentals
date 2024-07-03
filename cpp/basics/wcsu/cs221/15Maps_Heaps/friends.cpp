#include <iostream>
#include <map>
#include <utility>
#include <string>
#include <vector>

using namespace std;

class Friends 
{
public:
   
   void addFriend(string name, string friendName);
         
   vector<string> find_entries(string name);

   /**
      Print all entries.
   */
   void print_all();
private:
  
   multimap<string, string> friendsDatabase;
};

void Friends::addFriend(string name, string friendName)
{   
   friendsDatabase.insert(make_pair(name, friendName));
}

vector<string> Friends::find_entries(string name) 
{
   multimap<string, string>::iterator lower 
      = friendsDatabase.lower_bound(name);
   multimap<string, string>::iterator upper 
      = friendsDatabase.upper_bound(name);
   
   vector<string> result;
   
   for (multimap<string, string>::iterator pos = lower; 
        pos != upper; pos++)
      result.push_back(pos->second);
   return result;
}

void Friends::print_all()
{
   for (multimap<string, string>::iterator pos = friendsDatabase.begin();
        pos != friendsDatabase.end(); pos++)
   {
      cout << pos->first << ": " << pos->second << "\n";
   }
}

int main()
{
   Friends data;
   data.addFriend("Fred", "7235591");
   data.addFriend("Mary", "3841212");
   data.addFriend("Sarah", "3841212");
   data.addFriend("Sarah", "5841212");
   vector<string> result = data.find_entries("Fred");
   cout << "Friends of Fred:\n";
   for (int cnt = 0; cnt < result.size(); cnt++)
	   cout << result[cnt] << endl;
   
   result = data.find_entries("Sarah");
   cout << "Friends of Sarah:\n";
   for (int cnt = 0; cnt < result.size(); cnt++)
	   cout << result[cnt] << endl;
   
   cout << "All names and their friends:\n";
   data.print_all();
   return 0;
}

