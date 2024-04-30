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

        public void AddItem(LineItem item)
        {
            items.Add(item);
            NotifyObservers(new ChangeEvent(ChangeType.ItemAdded, item));
        }

        public void RemoveItem(LineItem item)
        {
            items.Remove(item);
            NotifyObservers(new ChangeEvent(ChangeType.ItemRemoved, item));
        }

        public void AttachObserver(Observer observer)
        {
            observers.Add(observer);
        }

        private void NotifyObservers(ChangeEvent changeEvent)
        {
            foreach (Observer observer in observers)
            {
                observer.StateChanged(changeEvent);
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach (LineItem item in items)
                output += $"{item}\n";
            output += $"Order Total: ${Price}";
            return output;
        }

        public IEnumerable<LineItem> GetLineItems()
        {
            return items;
        }
    }
}