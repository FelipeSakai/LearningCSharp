
using Exercise;
using System.Globalization;

Bancaria conta;

Console.WriteLine("Digite o numero da Conta Bancaria: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o seu nome: ");
string nome =  Console.ReadLine();

Console.WriteLine("Havera Deposito ? ");
char resp = char.Parse(Console.ReadLine());
if (resp == 's' || resp== 'S')
{
    Console.WriteLine("Digite o valor para deposito Inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    conta = new Bancaria(numero, nome,depositoInicial);
}
else
{
    conta = new Bancaria(numero, nome);
}

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);