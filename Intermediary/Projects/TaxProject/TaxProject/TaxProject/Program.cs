using System.Globalization;
using TaxProject.Entities;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the Number of Tax Payer: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax Payer #{i} data: ");
    Console.Write("Individual or Company (I/C)? ");
    char Type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string Name = Console.ReadLine();
    Console.Write("Annual Income: ");
    double Income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (Type == 'I')
    {
        Console.Write("Health Expenditures: ");
        double HealthExpedintures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(Name, Income, HealthExpedintures));
    }
    else
    {
        Console.Write("Number of Employee: ");
        int Employee = int.Parse(Console.ReadLine());
        list.Add(new Individual(Name, Income, Employee));
    }
}

double sum = 0.0;
Console.WriteLine();
Console.WriteLine("TAXES PAID: ");
foreach (TaxPayer tp in list)
{
    double tax = tp.Tax();
    Console.WriteLine(tp.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));
    sum += tax;
}

Console.WriteLine();
Console.WriteLine("Total TAXES: "+ sum.ToString("F2",CultureInfo.InvariantCulture));
