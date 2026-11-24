using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Jordan Taylor", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mechanical Keyboard", "KB-104", 65.00, 1));
        order1.AddProduct(new Product("USB-C Multiport Hub", "HB-209", 28.50, 2));
        order1.AddProduct(new Product("Desk Cable Organizer", "CB-012", 12.00, 1));

        Address address2 = new Address("221B Baker Street", "London", "Greater London", "United Kingdom");
        Customer customer2 = new Customer("Clara Bennett", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Insulated Stainless Tumbler", "TM-410", 24.00, 2));
        order2.AddProduct(new Product("Canvas Field Notebook", "NB-305", 9.50, 3));

        Order[] orders = { order1, order2 };

        for (int i = 0; i < orders.Length; i++)
        {
            Console.WriteLine($"==================== ORDER #{i + 1} ====================");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${orders[i].CalculateTotalCost():F2}");
            Console.WriteLine();
        }
    }
}