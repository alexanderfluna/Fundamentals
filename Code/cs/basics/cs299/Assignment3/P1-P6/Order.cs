// Alexander Luna | Assignment 3 | Order.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    /// <summary>
    /// 5. Make a class Order that will represent a collection of LineItem objects. An order should contain an array list 
    /// of line items and have a Price property calculated as the sum of the prices of its line items. The method ToString of 
    /// Order should make a ready to print string having the names and the prices of all items, with the bundles visually separated 
    /// (for example by empty lines or horizontal rules), and with the subtotal prices of each bundle. 
    /// </summary>
    public class Order
    {

        public double Price
        {
            get { return items.Sum(i => i.Price); }
            set { throw new NotImplementedException(); }
        }

        private List<LineItem> items;

        public Order()
        {
            items = new List<LineItem>();
        }

        public void AddItem(LineItem item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            string output = "";
            foreach (LineItem item in items)
                output += $"{item}\n";
            output += $"Order Total: ${Price}";
            return output;
        }
    }
}
