/*UsePredefinedMethods.cs   Author: Doyle
 * Demonstrates use of methods from the
 * System.Array class.
 */
using System;
using System.Windows.Forms;
namespace UsePredefinedMethods
{
	class UsePredefinedMethods
	{
		static void Main( )
		{
            double [ ] waterDepth = {45, 19, 2, 16.8, 
                                      190, 0.8, 510, 6, 18 };
            string outputMsg = "";
            string caption = "System.Array Methods Illustrated";
            double [ ] w = new double [20];
            

            //Displays Array waterDepth
            outputMsg += "waterDepth Array\n\n";
            foreach(double wVal in waterDepth)
                outputMsg += wVal  
                          + "\n";
            MessageBox.Show(outputMsg, caption);

            // Copies 5 values from waterDepth,
            // beginning at indexed location 2. 
            // Place values in Array w, starting
            // at index location 0. 
            Array.Copy(waterDepth, 2, w, 0, 5);

            //Sorts Array w in ascending order
            Array.Sort (w);

            //Displays Array w sorted 
            outputMsg = "Array w Sorted\n\n";
            foreach(double wVal in w)
            {
                if (wVal > 0)
                    outputMsg += wVal  
                        + "\n";
            }
            MessageBox.Show(outputMsg, caption);

            
            // Reverses the elements in Array w
            Array.Reverse(w);

            //Displays Array w in descending order
            outputMsg = "Array w Reversed\n\n";
            foreach(double wVal in w)
            {
                if (wVal > 0)
                    outputMsg += wVal  
                        + "\n";
            }
            MessageBox.Show(outputMsg, caption);
		}
	}
}