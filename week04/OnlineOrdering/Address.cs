using System.Runtime.InteropServices;
public class Address
{
    private string StreetAddress { get; set; }
    private string City { get; set; }
    private string StateOrProvince { get; set; }
    private string Country { get; set; }

    public string GetStreetAddress()
    {
        return StreetAddress;
    }
    public void SetStreetAddress(string streetAddress)
    {
        StreetAddress = streetAddress;
    }
    public string GetCity()
    {
        return City;
    }
    public void SetCity(string city)
    {
        City = city;
    }
    public string GetStateOrProvince()
    {
        return StateOrProvince;
    }
    public void SetStateOrProvince(string stateOrProvince)
    {
        StateOrProvince = stateOrProvince;
    }
    public string GetCountry()
    {
        return Country;
    }
    public void SetCountry(string country)
    {
        Country = country;
    }
    public Address()
    {
        StreetAddress = string.Empty;
        City = string.Empty;
        StateOrProvince = string.Empty;
        Country = string.Empty;
    }
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa" || Country.ToLower() == "united states";
    }

    public string GetFullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateOrProvince}\n{Country}";
    }
}
