// BasicCollectionDemo.cs - Basic operations on a Collection of characters. 

using System;
using System.Collections.ObjectModel;

class BasicCollectionDemo
{

    public static void Main()
    {

        Collection<char> lst = new Collection<char>();

        // Add elements to the end of the empty list:
        lst.Add('a'); lst.Add('b'); lst.Add('c');
        ReportList("Initial List", lst);

        // Mutate existing elements in the list
        lst[0] = 'z'; lst[1]++;
        ReportList("lst[0] = 'z'; lst[1]++;", lst);

        // Insert and push towards the end
        lst.Insert(0, 'n');
        ReportList("lst.Insert(0,'n');", lst);

        // Insert at end - with Insert
        lst.Insert(lst.Count, 'x');      // equivalent to lst.Add('x');
        ReportList("lst.Insert(lst.Count,'x');", lst);

        // Remove element 0 and push toward the beginning
        lst.RemoveAt(0);
        ReportList("lst.RemoveAt(0);", lst);

        // Remove first occurrence of 'c'
        lst.Remove('c');
        ReportList("lst.Remove('c');", lst);

        // Remove remaining elements
        lst.Clear();
        ReportList("lst.Clear(); ", lst);

    }

    public static void ReportList<T>(string explanation, Collection<T> list)
    {
        Console.WriteLine(explanation);
        foreach (T el in list)
            Console.Write("{0, 3}", el);
        Console.WriteLine(); Console.WriteLine();
    }
}




