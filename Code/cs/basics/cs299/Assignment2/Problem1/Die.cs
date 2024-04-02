// Alexander Luna | Assignment 2 | Problem 1
using System;

namespace C_SharpConsoleProject
{
    // Class Die implements the interface IComparable
    public class Die : IComparable<Die>
    {
        private int numberOfEyes;
        private Random randomNumberSupplier;
        private const int maxNumberOfEyes = 6;

        public Die()
        {
            randomNumberSupplier = Random.Instance();
            numberOfEyes = NewTossHowManyEyes();
        }

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

        public int CompareTo(Die other)
        {
            if (other == null)
                return 1;
            return this.numberOfEyes.CompareTo(other.numberOfEyes);
        }
    }
}
