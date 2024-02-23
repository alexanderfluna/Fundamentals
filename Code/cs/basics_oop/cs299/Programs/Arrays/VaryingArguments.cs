/* VaryingArguments.cs      Author:  Doyle
 * This example demonstrates the use
 * of the params keyword. A varying
 * number of arguments can be sent
 * to a method.
 */
using System;
namespace VaryingArguments
{
	class VaryingArguments
	{
		    public static void Main() 
            {
                DisplayItems(1, 2, 3, 5);

                int[] anArray = new int[5] {100, 200, 300, 400, 500};

                DisplayItems(anArray);
                DisplayItems(1500, anArray[1] * anArray [2]);
            }


            public static void DisplayItems(params int[] item) 
            {
                for ( int i = 0 ; i < item.Length ; i++ )
                {
                    Console.Write(item[i] + "\t");
                }
                Console.WriteLine();
            }

			
	
	}
}
