using System;

namespace ElapsedTime
{
	/// Used for benchmarking code segments

	public class Timing {
		// Fields
		private long startTicks, endTicks;

		public void StartTiming () {
			DateTime t = DateTime.Now;
			startTicks = t.Ticks;
		}

		public void EndTiming () {
			DateTime t = DateTime.Now;
			endTicks = t.Ticks;
		}

		public double ElapsedTime () {
			return (endTicks - startTicks) / 10000000.0;
		}
	}
}



