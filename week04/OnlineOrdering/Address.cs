using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;

    private string _contry;

    public Address(string street, string city, string state, string contry)
    {
        _street = street;
        _city = city;
        _state = state;
        _contry = contry;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_contry}";
    }
}
