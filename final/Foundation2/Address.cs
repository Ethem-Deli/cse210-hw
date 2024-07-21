using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsUSAddress()
    {
        return _country.ToLower() == "us" || _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }

    public override string ToString()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}
