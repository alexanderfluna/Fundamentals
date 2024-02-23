/*ArrayListExample.cs     Author:  Doyle
 * Instantiates the ArrayList class.
 * Add and removes values. Demonstrates
 * displaying items using an index.
 */

using System;
using System.Collections;
public class ArrayListExample
{
    public static void Main()
    {
        // Create new array list
        ArrayList anArray = new ArrayList();

        /* Alternate way to instantiate the array list:
         * {
            "Today is the first day of the rest of your life!",
            "Live it to the fullest!",
            "ok",
            "You may not get a second chance."
        };*/

        // Add strings to the array list
        anArray.Add("Today is the first day of the rest of your life!");
        anArray.Add("Live it to the fullest!");
        anArray.Add("ok");
        anArray.Add("You may not get a second chance.");

        // Print out size of array
        Console.WriteLine("Count of elements in array:    {0}", anArray.Count);

        anArray.RemoveAt(2); // remove element at index 2

        // Print out size of array
        Console.WriteLine("New Count (after removing ok): {0}", anArray.Count);
        Console.WriteLine();
        DisplayContents(anArray);
    }

    // Print out contents of array
    public static void DisplayContents(ArrayList ar)
    {
        for (int i = 0; i < ar.Count; i++)
            Console.WriteLine(ar[i]);
        Console.WriteLine();
    }
}
