double num = double.Parse(Console.ReadLine());

if (num < 0.0 || num > 100)
{
    Console.WriteLine("Fora do Range");
}
else if (num <= 25.0)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if (num <= 50.0)
{
    Console.WriteLine("Intervalo [25,50]");
}
else if (num <= 75.0)
{
    Console.WriteLine("Intervalo [50,75]");
}
else {
    Console.WriteLine("Intervalo de [75,100]");
}