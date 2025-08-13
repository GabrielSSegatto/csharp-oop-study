
using System.Collections.Generic;
using Products.Entities; 

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> list = new List<Product>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Product {i + 1} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    char category = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    if (category == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (category == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateOnly manufactureDate = DateOnly.ParseExact(Console.ReadLine() ?? "", "dd/MM/yyyy");
        list.Add(new UsedProduct(name, price, manufactureDate));
    }
    else if (category == 'i')
    {
        Console.Write("Customs fee: ");
        decimal customsFee = decimal.Parse(Console.ReadLine());
        list.Add(new ImportedProduct(name, price, customsFee));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach (Product product in list)
{
    Console.WriteLine(product.PriceTag());
}