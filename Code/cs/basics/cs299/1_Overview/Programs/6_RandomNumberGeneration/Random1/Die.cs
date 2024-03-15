using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// This class models a die that, when cast, lands on a random
    /// face.
    /// </summary>
    public class Die
    {
        /// Constructs a die with a given number of sides.
        /// @param s the number of sides, e.g. 6 for a normal die
        public Die(int s)
        {
            sides = s;
            generator = new Random();
        }

        /// Simulates a throw of the die
        /// @return the face of the die 
        public int Cast()
        {
            return 1 + generator.Next(sides);
        }

        private Random generator;
        private int sides;
    }


}
