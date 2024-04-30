// Alexander Luna | Assignment 3 | ChangeEvent.cs

namespace Assignment3 
{
    public enum ChangeType
    {
        ItemAdded,
        ItemRemoved
    }

    public class ChangeEvent
    {
        public ChangeType changeType { get; }
        public LineItem item { get; }

        public string description = "description";

        public ChangeEvent(ChangeType changeType, LineItem item)
        {
            this.changeType = changeType;
            this.item = item;
        }
    }
}