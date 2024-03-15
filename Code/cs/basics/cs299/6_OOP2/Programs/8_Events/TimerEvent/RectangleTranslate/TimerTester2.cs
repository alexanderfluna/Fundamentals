using System;
using System.Timers;

namespace TestingProject
{
	/// <summary>
	/// This program tests the Timer class.
	/// </summary>	
	
	public class TimerTester2
	{
		public static void Main()
		{
			box = new Rectangle(5, 10, 20, 30);
			const int DELAY = 500; // Milliseconds between timer ticks
			Timer t = new Timer(DELAY);
			t.Elapsed += new ElapsedEventHandler(Action);
			t.Enabled = true;
	
			Console.WriteLine("Press the Enter key to exit the program.");
			Console.ReadLine();

		}
		public static void Action(object source, ElapsedEventArgs e){
			box.Translate(1, 1);
			Console.WriteLine(box);
		}
		private static Rectangle box;
	}
}
