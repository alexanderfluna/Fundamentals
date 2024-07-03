// Alexander Luna | Assignment 3 | ChangeEvent.cs

namespace Assignment3 
{
    public enum ChangeType
    {
        ItemAdded,
        ItemRemoved
    }

    /// <summary>
    /// 8b. Make an event ChangeEvent reflecting a change in an invoice.
    /// </summary>
    public class ChangeEvent
    {
        public ChangeType changeType { get; }
        public LineItem item { get; }

        public ChangeEvent(ChangeType changeType, LineItem item)
        {
            this.changeType = changeType;
            this.item = item;
        }
    }
}