namespace ConsoleApplication
{
    public interface SortableI
    {
        // This method LessThan takes in a a SortableI object
        // and returns true or false. It must be implemented
        // by any class that implements this interface.
        bool LessThan(SortableI a);
    }
}