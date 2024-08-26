using Oop1;

Person p1 = new Person();
Person p2 = new Person();

Console.WriteLine("Digite o nome da primeira Pessoa: ");
Console.Write("Nome: ");
p1.nome = Console.ReadLine();
Console.Write("Idade: ");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome da Segunda Pessoa: ");
Console.Write("Nome: ");
p2.nome = Console.ReadLine();
Console.Write("Idade: ");
p2.idade = int.Parse(Console.ReadLine());

if(p1.idade > p2.idade)
{
    Console.WriteLine("Pessoa Mais velha " + p1.nome);
}
else
{
    Console.WriteLine("Pessoa Mais Velha " + p2.nome);
}