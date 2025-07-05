using e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system.Classes
{
    public class OrderService
    {
       public static void Checkout(Customer customer, Cart cart)
    {
        if (cart.IsEmpty())
        {
            Console.WriteLine("❌ Cart is empty.");
            return;
        }

        decimal subtotal = cart.CalculatePrice();

        double totalWeight = cart.Items
            .Where(i => i.Product is IShippable)
            .Sum(i => ((IShippable)i.Product).Weight * i.Quantity);

        decimal shippingFees = (decimal)(totalWeight * 5);
        decimal total = subtotal + shippingFees;

        if (customer.Balance < total)
        {
            Console.WriteLine("❌ Insufficient balance.");
            return;
        }

       
        Console.WriteLine("\n** Shipment notice **");
        foreach (var item in cart.Items.Where(i => i.Product is IShippable))
        {
            var shipProduct = (IShippable)item.Product;
            Console.WriteLine($"{item.Quantity}x {item.Product.Name} {(shipProduct.Weight * item.Quantity)}kg");
        }
        Console.WriteLine($"Total package weight {totalWeight}kg");

        Console.WriteLine("\n** Checkout receipt **");
        foreach (var item in cart.Items)
        {
            Console.WriteLine($"{item.Quantity}x {item.Product.Name} {(item.Product.Price * item.Quantity)}");
        }

        Console.WriteLine("----------------------");
        Console.WriteLine($"Subtotal     {subtotal}");
        Console.WriteLine($"Shipping     {shippingFees}");
        Console.WriteLine($"Amount       {total}");

        customer.Balance -= total;
        Console.WriteLine($"Remaining Balance: {customer.Balance}");
    }











}
}
