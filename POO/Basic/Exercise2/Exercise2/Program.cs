using Course;
using System.Globalization;

Funcionario func = new Funcionario();

Console.WriteLine("Digite seu nome: ");
func.Nome = Console.ReadLine();
Console.WriteLine("Digite seu salario bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite o imposto: ");
func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.Write("Deseja aumentar o salário em qual porcentagem? ");
double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
func.AumentarSalario(porcent);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + func);




