using MiniProject.Entities.Enum;
using MiniProject.Entities;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Department's Name: ");
        string deptName = Console.ReadLine();
        Console.WriteLine("Enter Worker Date: ");
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Level: ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.WriteLine("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department dept = new Department(deptName);
        Worker worker = new Worker(name, level, baseSalary, dept);

        Console.WriteLine("How Many Contract's for this Worker");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} contract data: ");
            Console.WriteLine("(DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ValuePerHour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Duration (Hours): ");
            int hours = int.Parse(Console.ReadLine());
            HourContract contract = new HourContract(date, valuePerHour, hours);
            worker.AddContract(contract);
        }

        Console.WriteLine("Enter M and Y in the format Correct '04/2024' ");
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));
        Console.WriteLine("Name: " + worker.Name);
        Console.WriteLine("Department: " + worker.Department.Name);
        Console.WriteLine("Income: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
    }
}