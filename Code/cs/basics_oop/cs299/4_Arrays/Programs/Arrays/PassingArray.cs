/* PassingArray.cs      Author:  Doyle
 * Demonstrates passing
 * arrays to methods - references
 */

using System;
namespace PassingArray
{
    class PassingArray
    {
        static void Main( )
        {
            int [ ] temperature = new int[5];
            int [ ] t = new int[5];

            InputValues(temperature);
            
            //Array t will reference the same array 
            //as the temperature array
            t = temperature;

            t[1] = 44;

            foreach (int temp in t)
            {
                Console.WriteLine(temp);
            }
			
        }
        public static void InputValues(int [ ] temp)
        {
            string inValue;
            
            for(int i = 0; i < temp.Length; i ++)
            {
                Console.Write("Enter Temperature {0}: ", i + 1);
                inValue = Console.ReadLine( );
                temp[i] = int.Parse(inValue);
            }
        }
    }
}
