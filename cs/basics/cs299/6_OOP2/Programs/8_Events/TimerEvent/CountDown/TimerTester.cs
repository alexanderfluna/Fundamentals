using System;
using System.Timers;

namespace TestingProject
{
	/// <summary>
	/// This program tests the Timer class.
	/// </summary>
	
	public class TimerTester
	{
		public static void Main() {
			

			CountDown listener = new CountDown(10);

			const int DELAY = 1000; // Milliseconds between timer ticks
			Timer t = new Timer(DELAY);
			t.Elapsed += new ElapsedEventHandler(listener.Action);
			t.Enabled = true;

			Console.WriteLine("Press the Enter key to exit the program.");
			Console.ReadLine();

			// Keep the timer alive until the end of Main.
			GC.KeepAlive(t);
		}
}
 


}
