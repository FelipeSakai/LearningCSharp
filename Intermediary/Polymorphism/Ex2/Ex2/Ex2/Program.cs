using Ex2.Entities;
using System.Globalization;


List<Product> list = new List<Product>();
Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported (c/u/i)");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Customs Fee: ");
    if (type == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (type == 'u')
    {
        Console.WriteLine("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Product(name, price));

    }
    else
    {
        Console.WriteLine("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Product(name, price));
    }
    Console.WriteLine();
    Console.WriteLine("PRICE TAGS:");
    foreach (Product prod in list)
    {
        Console.WriteLine(prod.PriceTag());
    }
}