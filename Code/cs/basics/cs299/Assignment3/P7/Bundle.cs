// Alexander Luna | Assignment 3 | Bundle.cs
using System;
using System.Collections.Generic;
using System.Linq;

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
        public double Price
        {
            get { return items.Sum(item => item.Price); }
            set { throw new NotImplementedException(); }
        }

        private List<LineItem> items;

        public Bundle()
        {
            items = new List<LineItem>();
        }

        public void AddItem(LineItem item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            string output = "\tBundle:";
            foreach (LineItem item in items)
                output += $"\n\t{item}";
            return output + "\n\t";
        }

        public IEnumerable<LineItem> GetProducts()
        {
            foreach (LineItem item in items)
            {
                if (item is Product)
                {
                    yield return (Product)item;
                }
                if (item is DiscountedItem)
                {
                    yield return (DiscountedItem)item;
                }
                else if (item is Bundle)
                {
                    foreach (LineItem bundleItem in ((Bundle)item).GetProducts())
                    {
                        yield return bundleItem;
                    }
                }
            }
        }
    }
}