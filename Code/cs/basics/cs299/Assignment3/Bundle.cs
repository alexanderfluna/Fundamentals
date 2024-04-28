// Alexander Luna | Assignment 3 | Bundle.cs
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    /// <summary>
    /// 3. Products are sometimes offered in bundles. Make a class Bundle to also implement LineItem. 
    /// A bundle representing a composition of LineItem objects. For example, a bundle “stereo system” 
    /// may contain a tuner, amplifier, CD player and speakers.The price of a bundle is exactly the 
    /// total of the prices of the line items in the bundle. Design the ToString method appropriately. 
    /// </summary>
    public class Bundle : LineItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        private List<LineItem> items;

        public Bundle(string name)
        {
            Name = name;
            Price = 0;
            items = new List<LineItem>();
        }

        public void AddItem(LineItem item)
        {
            items.Add(item);
            Price += item.Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Bundle: {Name}");
            foreach (LineItem item in items)
                sb.AppendLine($"\t{item}");
            sb.AppendLine($"Total: {Price:C}");
            return sb.ToString();
        }
    }
}