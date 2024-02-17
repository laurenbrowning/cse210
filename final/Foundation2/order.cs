using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalcShipping() 
    {
        double shippingCost = _customer.isFromUSA() ? 5 : 35;
        return shippingCost;
    }

    public double TotalPrice()
    {
        double totalprice = 0;

        foreach (Product p in _products) 
        {
            double price = p.CalcPrice();
            totalprice += price;
        }

        double shippingCost = CalcShipping();
        totalprice += shippingCost;
        return totalprice;
    }

    public string PackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product p in _products) 
        {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += _customer.GetName() + "\n" + _customer.GenerateAddress();
        return shippingLabel;
    }

    public string GenerateTotalCost()
    {
        string totalCost = "\nProducts:\n";
        double totalPrice = TotalPrice();
        foreach (Product p in _products) 
        {
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalcPrice() + "\n";
        }
        
        totalCost += "Shipping Cost: $" + CalcShipping() + "\n";
        totalCost += "Total: $" + TotalPrice();
        
        return totalCost;
    }

    public void DisplayResults()
    {
        string packingLabel = PackingLabel();
        string shippingLabel = ShippingLabel();
        string totalCost = GenerateTotalCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }
}