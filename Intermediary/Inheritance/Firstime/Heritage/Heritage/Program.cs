using Heritage.Entities;

class Program
{
    static void Main(string[] args)
    {
        BussinesAccount account = new BussinesAccount(8010,"Tonho Culher",100.00,500.00);


        Console.WriteLine(account.Balance);
    }
}