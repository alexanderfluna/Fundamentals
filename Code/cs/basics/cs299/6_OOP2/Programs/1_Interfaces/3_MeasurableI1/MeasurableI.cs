namespace ConsoleApplication
{
    public interface MeasurableI
    {

        // This method GetMeasure() returns the measure of whatever
        // MeasurableI object calls it. This method must be implemented
        // by any class that implements MeasurableI.
        double GetMeasure();
    }
}