
using System;
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
int[,] mas =  new int[n, m];
Console.WriteLine();
for (int i = 0; i < mas.GetLength(0); i++)
{
    int max_row = int.MinValue, min_row = int.MaxValue;
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (i == 0 || j==0) { mas[i, j] = 1; }
        else { mas[i, j] = mas[i - 1, j] + mas[i, j - 1]; }
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}