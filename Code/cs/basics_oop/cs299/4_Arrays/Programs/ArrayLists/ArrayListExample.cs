/*ArrayListExample.cs     Author:  Doyle
 * Instantiates the ArrayList class.
 * Add and removes values. Demonstrates
 * displaying items using an index.
 */

using System;
using System.Collections;
public class ArrayListExample  
{
    public static void Main( )  
    {
        ArrayList anArray = new ArrayList();

        anArray.Add("Today is the first day of the rest of your life!");
        anArray.Add("Live it to the fullest!");
        anArray.Add("ok");
        anArray.Add("You may not get a second chance.");

        Console.WriteLine("Count of elements in array:    {0}", anArray.Count );
        anArray.RemoveAt(2);
        Console.WriteLine("New Count (after removing ok): {0}", anArray.Count );
        Console.WriteLine( );
        DisplayContents(anArray );
    }

    public static void DisplayContents(ArrayList ar)  
    {
       for(int i = 0; i < ar.Count; i ++)
            Console.WriteLine(ar[i] );
        Console.WriteLine();
    }
}
