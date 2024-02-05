using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// This class simulates a needle in the Buffon needle experiment.
    /// </summary>
    public class Needle
    {
        ///   Constructs a needle
        public Needle()
        {
            hits = 0;
            tries = 0;
            generator = new Random();
        }

        ///   Drops the needle on the grid of lines and 
        ///   remembers whether the needle hit a line.
        public void Drop()
        {
            double ylow = 2 * generator.NextDouble();
            double angle = 180 * generator.NextDouble();

            // Computes high point of needle

            double yhigh = ylow + Math.Sin(angle* Math.PI/180);
            if (yhigh >= 2) hits++;
            tries++;
        }

        /// Gets the number of times the needle hit a line.
        /// @return the hit count
        public int GetHits()
        {
            return hits;
        }

        /// Gets the total number of times the needle was dropped.
        /// @return the try count
        public int GetTries()
        {
            return tries;
        }

        private Random generator;
        private int hits;
        private int tries;
    }


}
