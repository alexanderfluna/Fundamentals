// BasicListDemo.cs - Basic operations on a List of characters

using System;
using System.Collections.Generic;

/* Very similar our illustration of class Collection<char> */
class BasicListDemo{

  public static void Main(){

    List<char> lst = new List<char>();

    // Add elements to the end of the empty list:
    lst.Add('a'); lst.Add('b'); lst.Add('c'); 
    ReportList("Initial List", lst);

    // Mutate existing elements in the list
    lst[0] = 'z'; lst[1]++; 
    ReportList("lst[0] = 'z'; lst[1]++;", lst);

    // Insert and push towards the end
    lst.Insert(0,'n'); 
    ReportList("lst.Insert(0,'n');", lst);

    // Insert at end - with Insert
    lst.Insert(lst.Count,'x');      // equivalent to lst.Add('x');
    ReportList("lst.Insert(lst.Count,'x');", lst);

    // Insert a new list into existing list, at position 2.
    lst.InsertRange(2, new List<char>(new char[]{'1', '2', '3', '4'})); 
    ReportList("lst.InsertRange(2, new List<char>(new char[]{'1', '2', '3', '4'}));", lst);

    // Remove element 0 and push toward the beginning
    lst.RemoveAt(0);
    ReportList("lst.RemoveAt(0);", lst); 

    // Remove first occurrence of 'c'
    lst.Remove('c'); 
    ReportList("lst.Remove('c');", lst);

    // Remove 2 elements, starting at element 1
    lst.RemoveRange(1, 2); 
    ReportList("lst.RemoveRange(1, 2);", lst);
 
    // Remove all remaining digits
    lst.RemoveAll(delegate(char ch){return Char.IsDigit(ch);}); 
    ReportList("lst.RemoveAll(delegate(char ch){return Char.IsDigit(ch);});", lst);

    // Test of all remaining characters are letters
    if (lst.TrueForAll(delegate(char ch){return Char.IsLetter(ch);}))
      Console.WriteLine("All characters in lst are letters");
    else 
      Console.WriteLine("NOT All characters in lst are letters");
  }

  public static void ReportList<T>(string explanation, List<T> list){
    Console.WriteLine(explanation);
    foreach(T el in list)
      Console.Write("{0, 3}", el);
    Console.WriteLine(); Console.WriteLine();
  }

}


