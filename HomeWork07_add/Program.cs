// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
//Требуется транспонировать ее относительно горизонтали

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
Console.WriteLine();

int[,] trans = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        trans[i, j] = array[m - i - 1, j];
        Console.Write($"{trans[i, j]}" + "\t");
    }
Console.WriteLine();
}
