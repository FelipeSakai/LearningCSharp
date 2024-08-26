Console.WriteLine("Digite a senha do banco");
int senha = int.Parse(Console.ReadLine());

while (senha != 2003)
{
    Console.WriteLine("Senha INVALIDA");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso Permitido");
