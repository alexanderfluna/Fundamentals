// Alexander Luna | Assignment 3 | Product.cs

namespace Assignment3
{
    /// <summary>
    /// 2. Make a class Product that implements the LineItem interface, and has an additional 
    /// property Name. It should be possible to change the price or the name of a product. 
    /// </summary>
    public class Product : LineItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"\tProduct: {Name}, Price: {Price:c}";
        }
    }
}

