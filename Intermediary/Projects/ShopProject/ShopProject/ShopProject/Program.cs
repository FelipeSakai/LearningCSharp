using ShopProject.Entities;
using ShopProject.Entities.Enum;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Client Data: ");
        Console.Write("Name: ");
        string Clientname = (Console.ReadLine());
        Console.Write("Email: ");
        string email = (Console.ReadLine());
        Console.Write("Birthdate: ");
        DateTime birtdate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter the order Date: ");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Client client = new Client(Clientname, email, birtdate);
        Order order = new Order(DateTime.Now, status, client);

        Console.WriteLine("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} the item data: ");
            Console.Write("Product name: ");
            string productName = Console.ReadLine();
            Console.Write("Product Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(productName, price);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(quantity,price,product);

            order.addItem(orderItem);
        }

        Console.WriteLine();
        Console.WriteLine("Order Summary: ");
        Console.WriteLine(order);
    }

}

