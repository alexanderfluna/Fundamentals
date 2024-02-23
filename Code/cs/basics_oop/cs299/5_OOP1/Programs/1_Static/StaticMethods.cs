/* StaticMethods.cs   Author: Doyle
 * Demonstrates use of methods from the
 * System.Array class.
 */
using System;

namespace StaticMethods
{
    class StaticMethods
    {
        public const string TITLE = "System.Array Methods Illustrated\n";

        static void Main( )
        {
            double [ ] waterDepth = {45, 19, 2, 16.8, 
                                        190, 0.8, 510, 6, 18 };
            double [ ] w = new Double [20];
            
            DisplayOutput(waterDepth, "waterDepth Array:" );
            
            // Copies values from waterDepth to w
            Array.Copy(waterDepth, 2, w, 0, 5);

            //Sorts Array w in ascending order
            Array.Sort (w);
            DisplayOutput(w, "Array w Sorted:" );
       
            // Reverses the elements in Array w
            Array.Reverse(w);
            DisplayOutput(w, "Array w Reversed:");
            
        }
 
        // Displays an array in a MessageBox 
        public static void DisplayOutput(double [ ] anArray, 
                                   string msg)
        {
            Console.WriteLine(TITLE);
            Console.WriteLine(msg);
            foreach (double wVal in anArray)
                if (wVal > 0)
                    Console.WriteLine(wVal);
            Console.WriteLine("\n");    
            
        }

    }
}