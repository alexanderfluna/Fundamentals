using System;
using System.Collections;

namespace TestingProject
{
    /// <summary>
    /// A purse holds a collection of coins.
    /// </summary>
    public class Purse
    {
        ///  Constructs an empty purse.
        public Purse()
        {
            coins = new ArrayList();
        }

        ///   Add a coin to the purse.
        ///   @param aCoin the coin to add
        public void Add(Coin aCoin)
        {
            coins.Add(aCoin); // adds an object to the end of an array list
        }

        ///  Get the total value of the coins in the purse.
        ///  @return the sum of all coin values
        public double GetTotal()
        {
            // Iterate through coins array list
            double total = 0;
            for (int i = 0; i < coins.Count; i++) // .Count returns the size of the array list
            {
                Coin aCoin = (Coin)coins[i]; // get the coin
                total += aCoin.GetValue(); // add the coin's value to total
            }
            return total;
        }

        public override string ToString()
        {
            // Print out the name of each coin in the array list
            String result = "Purse[";
            for (int i = 0; i < coins.Count; i++)
            {
                result += ((Coin)coins[i]).GetName();
                if (i < coins.Count - 1)
                    result += ", ";
            }
            result += "]";

            return result;
        }

        public void Reverse()
        {
            coins.Reverse(); // reverses the order of an array list
        }


        private ArrayList coins;
    }



}
