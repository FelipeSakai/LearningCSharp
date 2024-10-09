using Ex1.Entities;
using System.Globalization;

List<Employee> list = new List<Employee>();

Console.WriteLine("Enter the number of Employee");
int n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsourced (y/n)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    String name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (ch == 'y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new OutSourcedEmployee(additionalCharge, name, hours, valuePerHour));
    }
    else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }
}

Console.WriteLine();
Console.WriteLine("PAYMENTS:");
foreach (Employee emp in list)
{
    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
}
