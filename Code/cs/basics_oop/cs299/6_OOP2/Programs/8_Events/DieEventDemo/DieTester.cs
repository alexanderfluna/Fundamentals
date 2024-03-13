// DieTester.cs - A client of die that reports 'two sixes in a row'
// via an event. 


using System;

namespace ConsoleApplication1
{
	class DieTester 
	{

		public static void Main()
		{

			Die d1 = new Die();
			
			// add a method to the delegate
			d1.dieNotifier += new Die.Notifier(WriteMessage);
			//d1.dieNotifier += new Die.Notifier(WriteMessage);

			for(int i = 1; i < 100; i++)
			{
				d1.Toss();
				Console.WriteLine("{0}: {1}", i, d1.NumberOfEyes);  
			}
		}

 		public static void WriteMessage(string mes)
		{
			Console.WriteLine(mes);
		}
	}
}




