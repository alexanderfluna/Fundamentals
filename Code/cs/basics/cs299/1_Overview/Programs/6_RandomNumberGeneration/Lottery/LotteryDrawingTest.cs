using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class LotteryDrawingTest
    {
        public static void Main(){
		  Console.Write("How many numbers do you need to draw? ");
		  string temp = Console.ReadLine();
          int numbers = int.Parse(temp);
		  Console.Write("What is the highest number you can draw? ");
		  temp = Console.ReadLine();
            int topNumber = int.Parse(temp);

		  int[] a = LotteryDrawing.Draw(topNumber, numbers);
		  ShellSort.Sort(a);
		  Console.WriteLine("Bet the following combination. " +
		                     "It'll make you rich!");
		  for (int i = 0; i < a.Length; i++)
			 Console.WriteLine(a[i]);
       }
    }
}
