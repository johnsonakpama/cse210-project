using System;
public class Product
{
    private string _name;
    private int _id;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name,int id,double pricePerUnit)
    {
        this name = name;
        this id = id;
        this pricePerUnit = pricePerUnit;
        this quantity = 0
    }
    public string Name
    {
        get{return name;}
    }
    public int id
    {
        get{return id;}
    }
    public double pricePerUnit
    {
        get{return pricePerUnit;}
    }
    public int quantity
    {
        get{return quantity;}
        set{quantity = value;}

    }
    public double GetTotalPrice()
    {
        return pricePerUnit*quantity
    }
}