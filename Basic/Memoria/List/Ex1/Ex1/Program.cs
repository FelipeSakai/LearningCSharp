using System;
using System.Globalization;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many employees will be registered? ");
        int n = int.Parse(Console.ReadLine());

        List<Employee> list = new List<Employee>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Employee# "+i+":");
            Console.Write("Id:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            list.Add(new Employee(id, name, salary));
            Console.WriteLine();
        }

        Console.WriteLine("Enter the employee ID that will have a new salary: ");
        int searchId = int.Parse(Console.ReadLine());

        Employee emp = list.Find(x => x.Id == searchId);
        if (emp !=null)
        {
            Console.WriteLine("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.IncreaseSalary(percentage);
        }
        else
        {
            Console.WriteLine("This Id does not exist");
        }

        Console.WriteLine();
        Console.WriteLine("Updated list of Employees");
        foreach(Employee obj in list)
        {
            Console.WriteLine(obj);
        }
    }
}
