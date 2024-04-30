// Alexander Luna | Assignment 3 | LineItem.cs

namespace Assignment3 
{
    /// <summary>
    /// 1. Make an interface LineItem with a read-write property Price 
    /// and a method ToString that overrides the Object method ToString. 
    /// </summary>
    public interface LineItem
    {
        double Price { get; set; }

        string ToString();
    }
}

