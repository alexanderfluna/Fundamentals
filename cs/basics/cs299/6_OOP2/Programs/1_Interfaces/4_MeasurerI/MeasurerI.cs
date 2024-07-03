using System;

namespace ConsoleApplication
{
    public interface MeasurerI
    {
        // This method Measure() takes in an Object object
        // and returns a double of the object's measure.
        // This method must be implemented by any class
        // implementing the MeasurerI interface
        double Measure(Object obj);
    }
}