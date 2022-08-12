// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Задайте количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().NextDouble() * 100;
        Console.Write(Math.Round(array[i, j], 2) + "\t");
    }
    Console.WriteLine();
}
