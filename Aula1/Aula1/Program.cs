using System;
using System.Globalization;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            string genero = "M";

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($" Produtos: \n {produto1},cujo preço é ${preco1}" +
                $"\n {produto2}, cujo preço é ${preco2}");

            Console.WriteLine($"Registo: {idade}, codigo {codigo} e genero:{genero}.");
            
            Console.WriteLine($"{medida:F8}");
            Console.WriteLine($"{medida:F3}");
            Console.WriteLine(medida.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}