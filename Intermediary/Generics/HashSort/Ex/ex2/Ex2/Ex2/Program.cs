class Program
{
    static void Main(string[] args)
    {
        HashSet<int> groupA = new HashSet<int>();
        HashSet<int> groupB = new HashSet<int>();
        HashSet<int> groupC = new HashSet<int>();

        Console.Write("How many students in the Group A: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int cod = int.Parse(Console.ReadLine());
            groupA.Add(cod);
        }

        Console.Write("How many students in the Group B: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int cod = int.Parse(Console.ReadLine());
            groupB.Add(cod);
        }

        Console.Write("How many students in the Group C: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int cod = int.Parse(Console.ReadLine());
            groupC.Add(cod);
        }

        HashSet<int> all = new HashSet<int>(groupA);
        all.UnionWith(groupB);
        all.UnionWith(groupC);
        Console.WriteLine("Total Students: "+ all.Count);

    }
}