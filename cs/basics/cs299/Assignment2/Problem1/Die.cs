// Alexander Luna | Assignment 2 | Problem 1
using System;

namespace C_SharpConsoleProject
{
    // Class Die implements the interface IComparable
    public class Die : IComparable<Die>
    {
        // Fields
        private int numberOfEyes;
        private Random randomNumberSupplier;
        private const int maxNumberOfEyes = 6;

        // Constructor
        public Die()
        {
            randomNumberSupplier = Random.Instance();
            numberOfEyes = NewTossHowManyEyes();
        }

        // Die methods
        public void Toss()
        {
            numberOfEyes = NewTossHowManyEyes();
        }

        private int NewTossHowManyEyes()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int NumberOfEyes()
        {
            return numberOfEyes;
        }

        public override string ToString()
        {
            return string.Format("[{0}]", numberOfEyes);
        }

        // IComparable CompareTo method
        // Input: Die object
        // Output: - Less than zero if the current instance precedes the object
        //         - Zero if the current instance is in the same position as the object
        //         - Greater than zero if the current instance follows the object
        public int CompareTo(Die other)
        {
            // Return 1 if the Die object is null
            if (other == null)
                return 1;

            // Else compare the number of eyes of the current instance 
            // to the number of eyes of the Die object
            return this.numberOfEyes.CompareTo(other.numberOfEyes);
        }
    }
}
