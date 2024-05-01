// Alexander Luna | Test 2 | Coin.cs

using System;
using System.Collections;

namespace TestingProject
{
	/// <summary>
	/// A coin with a monetary value.
	/// </summary>
	public class Coin : Measurable {

		///	Constructs a coin.
		///	@param aValue the monetary value of the coin
		///	@param aName the name of the coin
		public Coin(double aValue, String aName) 
		{ 
			value = aValue; 
			name = aName;
		}

		/// Gets the coin value.
		/// @return the value
		public double GetValue() 	{
			return value;
		}

		///	Gets the coin name.
		/// @return the name
		public String GetName() {
			return name;
		}

		public double GetMeasure() 	{
			return value;
		}

		private double value;
		private string name;
}
}
