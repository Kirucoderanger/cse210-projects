using System.Runtime.InteropServices;
public class Customer
{
    private string _name;
    public Address Address { get; set; }

    public Customer(string name, Address address)
    {
        _name = name;
        Address = address;
        //_address = address;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    /*public string Address
    {
        get { return _address; }
        set { _address = value; }
    }*/
    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }
    public string GetAddress()
    {
        //return Address.ToString();
        return $"{Address.StreetAddress}\n{Address.City}, {Address.StateOrProvince}\n{Address.Country}";
    }
}
/*
    public bool LivesInUSA()
    {
        return _address.ToLower().Contains("usa");
    }
}*/
/*
public class Customer
{
    public string Name  { get; set; }
    public Address Address { get; set; }

    public Customer(string name, Address address)
    {
        this.Name = name;
        Address = address;
    }

    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }
}*/
/*
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }
}*/
