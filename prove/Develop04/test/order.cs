using System;

namespace OrderMangement
{
    class Product
    {
        private string _productId;
        private string _Name;
        private decimal _price;
    
    public Product(string productid,string name,decimal price)
    {
        ProductId = productid;
        Name = name;
        Price = price;

    }

    }
   public class Customer
    {
        private string _Name;
        private string _Address;
        private string _City;
        private string _State;
        private string _Country;
        private decimal _TotalSpent;
    }
    public Customer():base();
    {

    }
    public class Order
    {
        public Product product;
        public Cuctomer customer;
        public int Quantity;
    }
    public Order(Product product,Customer customer,int quantity)
    {
        Product = product;
        Customer = customer;
        Quantity = quantity;
    }
    public decimal GetTotalPrice()
    {
        decimal totalPrice = Product.price*Quantity;
        Customer.TotalSpect += totalPrice;
        return totalPrice;
    }
    public decimal GetShippingFee()
    {
        const decimal feeWithinUsa = $5;
        const decimal feeOutsideUsa =$35;
    }
    if (Customer.country == "USA")
    {
        return feeWithinUsa;
    }
    else
    {
        return feeOutsideUsa;
    }
    public void GeneratePackingLabel()
    {
        Console.WriteLine($"PackingLabel:\nTO:{Customer:Name}\nAddress:{Customer.Address}\nCity:{Customer.City}\nState:{Customer.State}\nCountry:{Customer.Country}"):
    }

}

