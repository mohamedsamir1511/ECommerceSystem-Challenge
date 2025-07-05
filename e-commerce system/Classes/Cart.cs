using e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Classes
{
    public class Cart
    {
        private List<CartItem> items=new();
        public IReadOnlyList<CartItem> Items => items;

        public void Add_Product(Product product,int quantity)
        {
            if (quantity > product.Quantity)
            {
                throw new InvalidOperationException("Requested Quantity exceeds stock quantity");

            }
                items.Add(new CartItem(product, quantity));
                product.Quantity-= quantity;

        }
        public decimal CalculatePrice()
        {

            return items.Sum(i => i.TotalPrice);

        }
        public double CalculateShippingFees()
        {
            return items
                .Where(item => item.Product is IShippable)
                .Sum(item => ((IShippable)item.Product).Weight * 5);

        }
        public bool IsEmpty()
        {
            return !items.Any();
        }

    }
}
