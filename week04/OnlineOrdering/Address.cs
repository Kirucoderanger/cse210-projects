using System.Runtime.InteropServices;
public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string StateOrProvince { get; set; }
    public string Country { get; set; }

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
