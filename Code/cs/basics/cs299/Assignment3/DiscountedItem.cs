// Alexander Luna | Assignment 3 | DiscountedItem.cs

namespace Assignment3
{
    /// <summary>
    /// 4. Make another class DiscountedItem to implement LineItem. This class will “decorate” line items 
    /// like products or bundles or other line items by applying discounts to them. To achieve this, construct 
    /// a discounted item from a LineItem and a discount (represented as a double number) passed to the constructor. 
    /// Design the ToString method appropriately.
    /// </summary>
    public class DiscountedItem : LineItem
    {
        private LineItem item;
        private double discount;

        public DiscountedItem(LineItem item, double discount)
        {
            this.item = item;
            this.discount = discount;
        }

        public double Price
        {
            get { return item.Price * (1 - discount); }
            set { item.Price = value / (1 - discount); }
        }

        public override string ToString()
        {
            return $"{item} (Discounted {discount * 100}%): {Price:C}";
        }
    }
}