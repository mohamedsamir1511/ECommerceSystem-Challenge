using e_commerce_system.Classes;

namespace e_commerce_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            var cheese = new Cheese("Cheese", 100, 10, DateTime.Now.AddDays(30), 0.5);
            var tv = new Tv("TV", 300, 5, 2.0);
            var scratchCard = new ScratchCard("Mobile Scratch Card", 50, 20);

            var customer = new Customer("Ahmed", 1000);

            customer.Cart.Add_Product(cheese, 2);
            customer.Cart.Add_Product(tv, 1);
            customer.Cart.Add_Product(scratchCard, 1);

            OrderService.Checkout(customer, customer.Cart);
        }
    }
}
