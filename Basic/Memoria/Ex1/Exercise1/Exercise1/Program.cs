using Exercise1;
using System;


class Program { 
static void Main(string[] args)
{
    Estudante[] vect = new Estudante[10];

    Console.WriteLine("Quantos quartos serao alugados ? ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine();
        Console.WriteLine($"Aluguel #{i}: ");
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Quarto: ");
        int quarto = int.Parse(Console.ReadLine());
        vect[quarto] = new Estudante(nome, email);

    }
    Console.WriteLine();
    Console.WriteLine("Quartos Ocupados: ");
    for (int i = 0; i < 10; i++)
    {
        if (vect[i] != null)
        {
            Console.WriteLine(i + ": " + vect[i]);
        }
    }

}
}