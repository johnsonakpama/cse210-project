using System;

public class Customer
{
    private string _name;
    private Address _address;

    puublic Customer(string name,Address address)
    {
        this.name = name;
        this.address = address;
    }
    public string Name
    {
        get{return name;}
    }
    public Address Address
    {
        get{return address;}
    }
    public bool IsUSResident()
    {
        return address.Country == "UnitedStates";
    }
}