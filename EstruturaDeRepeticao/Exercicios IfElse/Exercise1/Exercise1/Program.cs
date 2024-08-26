using System.ComponentModel.Design;

int Num =int.Parse(Console.ReadLine());

if (Num < 0 )
{
    Console.WriteLine("NEGATIVO");
}
else if(Num > 0)
{
    Console.WriteLine("POSITIVO");
}
else {
    Console.WriteLine("NEUTRO");
}
