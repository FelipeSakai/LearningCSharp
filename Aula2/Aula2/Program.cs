using System.Diagnostics.Contracts;
using System.Globalization;

Console.WriteLine("ESCREVA SEU NOME: ");
string nome = Console.ReadLine();

Console.WriteLine("ESCREVA QUANTOS QUARTOS TEM NA SUA CASA: ");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("ESCREVA O PREÇO DO PRODUTO: ");
double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("ESCREVA SEU SOBRENOME, IDADE E ALTURA: ");
string[] pessoa = Console.ReadLine().Split(' ');
string sobrenome = pessoa[0];
int idade = int.Parse(pessoa[1]);
double altura = double.Parse(pessoa[2],CultureInfo.InvariantCulture);




Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F"));
Console.WriteLine(sobrenome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));