using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{

    public class LotteryDrawing
    {
        public static int[] Draw(int high, int number){
		int[] numbers = new int[high];
        int[] result = new int[number];
        Random random = new Random();
        // fill an array with numbers 1 2 3 . . . high
        for (int i = 0; i < high; i++) numbers[i] = i + 1;
        for (int i = 0; i < number; i++){
			int j = (int)random.Next(0,high - i);
            result[i] = numbers[j];
            numbers[j] = numbers[high - 1 - i];
        }
        return result;
   }


    }
}
