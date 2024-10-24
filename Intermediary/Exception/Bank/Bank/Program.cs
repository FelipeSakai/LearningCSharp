﻿using Bank;
using Bank.Entities.Exceptions;
using System.Globalization;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
String holder = Console.ReadLine();
Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc = new Account(number, holder, balance, withdrawLimit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    acc.Withdraw(amount);
    Console.WriteLine("New Balance: "+acc.Balance.ToString("F2",CultureInfo.InvariantCulture));
}
catch(DomainException e )
{
    Console.WriteLine("Withdraw Error: "+ e.Message);
}