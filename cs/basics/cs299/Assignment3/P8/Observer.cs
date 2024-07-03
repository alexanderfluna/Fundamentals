// Alexander Luna | Assignment 3 | Observer.cs

namespace Assignment3
{
    /// <summary>
    /// c. Make an interface Observer with a method void StateChanged (ChangeEvent event)
    /// </summary>
    public interface Observer
    {
        /* This will be the method in each observer that the invoice will call to notify the observers 
        that a change occurred. The purpose of this method in the classes that implement this interface 
        will be to handle the change in the way you design, possibly different for each concrete observer. 
        For example, an observer may print the invoice after the change, or somehow summarize the change, 
        or do both. In a comment before each implementation of the method state the way the event is handled.*/
        void StateChanged(ChangeEvent changeEvent);
    }
}
