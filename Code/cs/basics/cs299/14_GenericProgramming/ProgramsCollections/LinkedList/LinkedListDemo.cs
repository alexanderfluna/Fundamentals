// LinkedListDemo.cs - Basic operations on a LinkedList of integers.

using System;
using System.Collections.Generic;

class LinkedListDemo
{

    public static void Main()
    {

        LinkedList<int> lst = new LinkedList<int>(
                                   new int[] { 5, 3, 2, 7, -4, 0 });

        ReportList("Initial LinkedList", lst);

        // Using Add.
        // Compile-time error: 'LinkedList<int>' does not contain a 
        //                                      definition for 'Add'
        // lst.Add(17);
        // ReportList("lst.Add(17);" lst);

        // Add is implemented as an explicit interface implementation
        ((ICollection<int>)lst).Add(17);
        ReportList("((ICollection<int>)lst).Add(17);", lst);

        // Using AddFirst and AddLast
        lst.AddFirst(-88);
        lst.AddLast(88);
        ReportList("lst.AddFirst(-88); lst.AddFirst(88);", lst);

        // Using Remove.
        lst.Remove(17);
        ReportList("lst.Remove(17);", lst);

        // Using RemoveFirst and RemoveLast
        lst.RemoveFirst(); lst.RemoveLast();
        ReportList("lst.RemoveFirst(); lst.RemoveLast();", lst);

        // Using Clear
        lst.Clear();
        ReportList("lst.Clear();", lst);

    }

    public static void ReportList<T>(string explanation, LinkedList<T> list)
    {
        Console.WriteLine(explanation);
        foreach (T el in list)
            Console.Write("{0, 4}", el);
        Console.WriteLine(); Console.WriteLine();
    }

}