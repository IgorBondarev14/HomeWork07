// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

Console.Write("Задайте количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]}" + "\t");
    }
    Console.WriteLine();
}
double[] arithmetic = new double[n];
for (int i = 0; i < n; i++)
{
    arithmetic[i] = 0;
    for (int j = 0; j < m; j++)
        arithmetic[i] = (arithmetic[i] + array[j, i]);
    arithmetic[i] = arithmetic[i] / n;
}

Console.Write("[" + string.Join(";   ", arithmetic) + "]");
Console.WriteLine();
