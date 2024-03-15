using System;

namespace ConsoleApplication1
{

	/// <summary>
	/// Alphabetize names...
	/// This program uses the bubble sort to
	/// sort an array of names
	/// </summary>
	
	class  Alphabetize 	{
      public static void Main() {

        string[]  presidentList =
            {"blank","Washington","Adams","Jefferson","Madison",
             "Monroe","Adams","Jackson","Van Buren","Harrison",
             "Tyler","Polk","Taylor","Fillmore","Pierce","Buchanan",
             "Lincoln"};

        int  n=presidentList.Length -1;  //number of names in list
        for  (int  i=1; i<=n-1; i++) {
          for  (int  j=1; j<=(n-i); j++) {
            bool  inorder=(presidentList[j].CompareTo(presidentList[j+1])<=0 );
            if  (!inorder) { // swap these two elements
                  string  temporaryString=presidentList[j];
                  presidentList[j]=presidentList[j+1];
                  presidentList[j+1]=temporaryString;
            } 
          } 
        } 

           //display the results
           for  (int  i=1; i<=n; i++) {
              Console.WriteLine(presidentList[i]);
           } 
         } 
        } // class
}// namespace
