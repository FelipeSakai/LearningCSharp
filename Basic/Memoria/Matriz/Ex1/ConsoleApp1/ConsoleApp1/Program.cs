﻿int n =int.Parse(Console.ReadLine());

int [,] mat = new int[n,n];

for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        mat[i,j]= int.Parse(values[j]);
    }
}

Console.WriteLine("Main Diagonal: ");
for (int i = 0;i < n; i++)
{
    Console.Write(mat[i,i]+" ");
}
Console.WriteLine();

int count = 0;
foreach (int i in mat) if (i < 0) count++;
Console.WriteLine("Negatives Numbers: "+ count);
