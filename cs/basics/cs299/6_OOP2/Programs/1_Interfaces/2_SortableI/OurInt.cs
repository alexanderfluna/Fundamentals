using System;

namespace ConsoleApplication
{
    public class OurInteger : SortableI
    {
        // Private value field
        private int value;

        // Value property
        public int Value
        {
            get
            {
                return value;
            }
        }

        // Constructor
        public OurInteger(int value)
        {
            this.value = value;
        }

        // Implements the LessThan method from SortableI
        public bool LessThan(SortableI a)
        {
            // Cast the SortableI object a to an OurInteger object i
            OurInteger b = (OurInteger)a;
            
            // Return true or false based on this condition
            return (value < b.value);
        }
    }
}