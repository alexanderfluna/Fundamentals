using System;

namespace TestingProject
{
	/// <summary>
	/// Objects of this class measure rectangles by area.
	/// </summary>
	public class CoinMeasurer : Measurer	{
		public double Measure(Object anObject)  {
			Coin aCoin = (Coin) anObject;
            return aCoin.GetValue();
		}
	}

}
