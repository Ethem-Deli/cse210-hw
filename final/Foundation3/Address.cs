public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string Street { get => _street; set => _street = value; }
    public string City { get => _city; set => _city = value; }
    public string StateProvince { get => _stateProvince; set => _stateProvince = value; }
    public string Country { get => _country; set => _country = value; }

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}
 