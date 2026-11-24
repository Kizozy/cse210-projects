using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double productsTotal = 0;
        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.IsInUsa() ? 5.0 : 35.0;
        return productsTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("PACKING LABEL");
        foreach (Product product in _products)
        {
            sb.AppendLine($"- {product.GetName()} (ID: {product.GetProductId()}) x{product.GetQuantity()}");
        }
        return sb.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("SHIPPING LABEL");
        sb.AppendLine(_customer.GetName());
        sb.AppendLine(_customer.GetAddress().GetFullAddressString());
        return sb.ToString().TrimEnd();
    }
}