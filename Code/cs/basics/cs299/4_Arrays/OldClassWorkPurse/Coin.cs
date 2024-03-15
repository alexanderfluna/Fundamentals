using System;
using System.Collections;

namespace TestingProject
{
    /// <summary>
    /// A coin with a monetary value.
    /// </summary>
    public class Coin
    {

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

        // Override built-in C# Equals function
        public override bool Equals(Object otherObject)
        {
            Coin other = (Coin)otherObject; // get the coin
            return name == other.name // return true if the names and values of the fcoins match
                && value == other.value;
        }

        // C# requirement: 
        // since we override Equals, MUST also override GetHashCode ( !! )
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Private fields
        private double value;
        private string name;
    }
}
