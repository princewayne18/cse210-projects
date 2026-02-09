using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("210 W 4th S", "Rexburg", "ID 83460", "USA");
        Customer customer1 = new Customer("Prince Anderson", usaAddress);


        Product p1 = new Product("Iphone 17 Promax", "A3257 ", 1500.99, 2);
        Product p2 = new Product("Macbook Pro M2", "A2681", 1599.55, 2);


        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);


        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine();



        Address internationalAddress = new Address("1827 New Magwegwe", "Bulawayo", "BYO", "Zimbabwe");
        Customer customer2 = new Customer("Zandile Dube", internationalAddress);

        Product p3 = new Product("Nike Airmax", "A2288", 100.26, 2);
        Product p4 = new Product("Pens", "X2254", 1.25, 10);
        Product p5 = new Product("Joggers", "J2500", 10.25, 2);


        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);


        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
