// Alexander Luna | Assignment 3 | Invoice.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    /// <summary>
    /// 8. Rename class Order to Invoice and change it to allow other classes to react on changes in any line item, like in the Observer pattern.
    /// </summary>
    public class Invoice
    {

        public double Price
        {
            get { return items.Sum(i => i.Price); }
            set { throw new NotImplementedException(); }
        }

        private List<LineItem> items;
        private List<Observer> observers;

        public Invoice()
        {
            items = new List<LineItem>();
            observers = new List<Observer>();
        }

        // 8a. An invoice will be the subject to be observed. 
        // To do this you need to add to class Invoice a method to attach observers.
        public void AttachObserver(Observer observer)
        {
            observers.Add(observer);
        }

        // 8a. Whenever a change occurs, the invoice will notify all observers.
        private void NotifyObservers(ChangeEvent changeEvent)
        {
            foreach (Observer observer in observers)
            {
                observer.StateChanged(changeEvent);
            }
        }

        public void AddItem(LineItem item)
        {
            items.Add(item);
            // 8b. Make an event ChangeEvent reflecting a change in an invoice.
            NotifyObservers(new ChangeEvent(ChangeType.ItemAdded, item));
        }

        public void RemoveItem(LineItem item)
        {
            items.Remove(item);
            // 8b. Make an event ChangeEvent reflecting a change in an invoice.
            NotifyObservers(new ChangeEvent(ChangeType.ItemRemoved, item));
        }

        public override string ToString()
        {
            string output = "";
            foreach (LineItem item in items)
                output += $"{item}\n";
            output += $"Order Total: ${Price}";
            return output;
        }

        // This function returns all products in the invoice including discounted items
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