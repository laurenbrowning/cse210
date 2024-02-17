using System;

class Program
{
    static void Main(string[] args)
    {
        //1st Order
        Address address1 = new Address("Apt. 315 4907 Kuhlman Orchard", "West Marianna", "GA 73857", "USA");
        Customer customer1 = new Customer("Jenna Organta", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1of1 = new Product("Wool Jacket", "WJ100", 65.99, 1);
        Product p2of1 = new Product("Maternity Leggings", "ML510", 33.50, 5);

        productsList1.Add(p1of1);
        productsList1.Add(p2of1);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // 2nd Order
        Address address2 = new Address("699 Smith Plains", "Wolfside", "NY 00648", "USA");
        Customer customer2 = new Customer("Blake Forkey", address2);
        List<Product> productsList2 = new List<Product>();

        Product p1of2 = new Product("4-blade Razor", "RB30", 14.99, 1);
        Product p2of2 = new Product("Shaving Cream", "SC22", 7.75, 2);
        Product p3of2 = new Product("Aftershave", "AS800", 12.50, 1);

        productsList2.Add(p1of2);
        productsList2.Add(p2of2);
        productsList2.Add(p3of2);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // 3rd Order
        Address address3 = new Address("Esc. 550 Riera Monica 87", "San Fernando", "Man 41824", "Mexico");
        Customer customer3 = new Customer("Maria L. Ruez", address3);
        List<Product> productsList3 = new List<Product>();

        Product p1of3 = new Product("Hightop Sneakers", "HS111", 48.99, 2);
        Product p2of3 = new Product("Neon Socks", "NS33", 4.99, 4);

        productsList3.Add(p1of3);
        productsList3.Add(p2of3);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}