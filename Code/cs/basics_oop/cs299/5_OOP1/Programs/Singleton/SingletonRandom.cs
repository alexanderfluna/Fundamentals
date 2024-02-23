using System;
using System.Collections.Generic;
using System.Text;

namespace C_SharpConsoleProject
{
    public class Random
    {

        // Singleton pattern:
        // Keeps track of unique instance of this class
        private static Random uniqueInstance = null;

        // Holds the instance of System.Random
        private System.Random systemRandom;

        // Singleton pattern: Private constructor.
        private Random()
        {
            systemRandom = new System.Random(unchecked((int)DateTime.Now.Ticks));
        }

        public static Random Instance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Random();
            return uniqueInstance;
        }

        public int Next(int lower, int upper)
        {
            // delegate to systemRandom
            return systemRandom.Next(lower, upper);
        }

    }
}
