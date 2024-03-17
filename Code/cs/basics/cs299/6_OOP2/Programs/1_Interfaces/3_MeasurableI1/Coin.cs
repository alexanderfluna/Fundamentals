using System;

namespace ConsoleApplication
{
    public class Coin : MeasurableI
    {
        private double value;
        private String name;

        // Constructor
        public Coin(double value, String name)
        {
            this.value = value;
            this.name = name;
        }

        // Returns the coin's name
        public String GetName()
        {
            return name;
        }

        // Implementing the GetMeasure() function from MeasurableI
        public double GetMeasure()
        {
            return value;
        }
    }
}