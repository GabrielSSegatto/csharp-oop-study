using System;
using System.Collections.Generic;
using orders.Entities;
using orders.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter Client data:");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string clientEmail = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime clientBirthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine("Enter Order data:");
Console.Write("Status: ");
OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(clientName, clientEmail, clientBirthDate);
Order order = new Order(orderStatus, client);

//products
Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data");
    Console.Write("Produt name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    decimal productPrice = decimal.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    //product instance
    Product product = new Product(productName, productPrice);

    //orderitem instance
    OrderItem orderItem = new OrderItem(quantity, productPrice, product);

    order.AddItem(orderItem);
}

//sumary
Console.WriteLine("ORDER SUMMARY: ");
Console.WriteLine($"Oder moment: {order.Moment.ToString("dd/MM/yyyy HH:mm")}");
Console.WriteLine(orderStatus);
Console.WriteLine($"Client: {clientName} {clientBirthDate.ToString("dd/MM/yyyy")} - {clientEmail}");
Console.WriteLine("Order items: ");
foreach (OrderItem orderitem in order.OrderItems)
{
    Console.WriteLine(orderitem);
}
Console.WriteLine($"Total price: {order.Total()}");

