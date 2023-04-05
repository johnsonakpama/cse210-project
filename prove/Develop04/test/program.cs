using System;
namespace productInformation
{
    public class program
    {
        Static void Main(string[]args)
        {
            string productName = "Apple";
            int productID = 234563;
            int productQty = 10;
            decimal pricePerProduct = $ 8.85

            Console.WriteLine($"Product name:{ProductName}");
            Console.WriteLine($"Product ID:{ProductID}");
            Console.WriteLine($"Product Quantity:{ProductQty}");
            Console.WriteLine($"Price per Product:{PricePerProduct}");
        }
        public class program
        {
            Product product = new Order("P001","Widget","10.oom");
            Customer customer = new Cuctomer();

            Order order = new Order(Product,Customer,2);
            decimal totalPrice = order.GetTotalPrice();
            decimal shippingFee = order.GetShippingFee();
            
            Console.WriteLine($"Total price:{totalPrice:c}");
            Console.WriteLine($"shippingFee:{shippingFee:c}");

            order.GeneratePackingLabel();
            order.GenerateShippinglabel();
        }
    }
}