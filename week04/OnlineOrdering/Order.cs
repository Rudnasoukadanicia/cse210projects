using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class Order
{
    private Customer _customer;
    private List<Product> _product;

    public Order(Customer customer)
    {
        _customer = customer;
        _product = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public float GetTotalPrice()
    {
        float total = 0;
        foreach (Product product in _product)
        {
            total += product.GetTotalPrice();
        }
        if (_customer.GetAddress().GetFullAddress().ToLower().Contains("usa"))
        {
            total += 5;
        }
        else
        {
            total += 35;

        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _product)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}