using System;

public class Product
{
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;

    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public float GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"Name: {_name}, ID: {_id}, Unit Price: {_price}, Quantity: {_quantity}, Total: {GetTotalPrice()}";
    }

}   