/* UnknownSize.cs   Author: Doyle
 * Any number of scores, up to 100,
 * can be entered.
 */

using System;
namespace UnknownSize
{
	class UnknownSize
	{
		static void Main( )
		{
            int [ ] score = new int[100];
            string inValue;

            int scoreCnt = 0; 
            int total = 0;
            double avg;
            Console.Write("Enter Score{0}: " 
                          + "((-99 to exit)) ", 
                          scoreCnt + 1);
            inValue = Console.ReadLine( );
            
            while(inValue != "-99")
            {
                score[scoreCnt] = Convert.ToInt32(inValue);
                ++scoreCnt;
                Console.Write("Enter Score{0}: " 
                              + "((-99 to exit)) ", 
                              scoreCnt + 1);
                inValue = Console.ReadLine( );
            }

            Console.WriteLine("The number of scores: "
                               + scoreCnt);
            foreach(int val in score)
            {
                total += val;
            }
            Console.WriteLine("Total: " + total);
            avg = (double) total / scoreCnt;
            Console.WriteLine("Average: " + avg);


        }
	}
}
