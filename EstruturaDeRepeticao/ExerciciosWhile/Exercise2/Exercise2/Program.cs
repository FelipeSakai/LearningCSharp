Console.WriteLine("Digite as Cordenadas [X,Y]");

string[] valores = Console.ReadLine().Split(' '); 
int x = int.Parse(valores[0]);
int y = int.Parse(valores[1]);

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro :D !");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Segundo :D !!");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Terceiro :D !!!");
    }
    else
    {
        Console.WriteLine("Quarto :C !");
    }
    valores = Console.ReadLine().Split(' ');
    x = int.Parse(valores[0]);
    y = int.Parse(valores[1]);
}