using System;
using System.Collections;

namespace TestingProject
{
	/// <summary>
	/// A coin with a monetary value.
	/// </summary>
	public class Coin	{

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
		public double GetValue() 	
		{
			return value;
		}

		///	Gets the coin name.
		/// @return the name
		public String GetName() 
		{
			return name;
		}
		
		public override bool Equals(Object otherObject)
		{
			Coin other = (Coin)otherObject;
			return name==other.name
				&& value == other.value;
		}

		// C# requirement: 
		// since we override Equals, MUST also override GetHashCode ( !! )
		public override int GetHashCode()
		{
			return base.GetHashCode ();
		}		

		private double value;
		private string name;
	}
}
