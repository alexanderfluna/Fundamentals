using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment3
{
    public class OrderIterator : IEnumerable<LineItem>
    {
        private Order order;

        public OrderIterator(Order order)
        {
            this.order = order;
        }

        public IEnumerator<LineItem> GetEnumerator()
        {
            return GetProducts(order.GetLineItems()).GetEnumerator();
        }

        private IEnumerable<LineItem> GetProducts(IEnumerable<LineItem> lineItems)
        {
            foreach (LineItem item in lineItems)
            {
                if (item is Product product)
                {
                    yield return product;
                }
                else if (item is Bundle bundle)
                {
                    foreach (var bundleProduct in GetProducts(bundle.GetLineItems()))
                    {
                        yield return bundleProduct;
                    }
                }
                else if (item is DiscountedItem discountedItem)
                {
                    yield return discountedItem;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}