// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

Console.Write("Задайте количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write($"{array[i, j]}" + "\t");
    }
    Console.WriteLine();
}
Console.Write("Введите искомое число: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (x == array[i, j])
        {
            Console.WriteLine(array[i, j]);
            count++;
        }
    }
}
if (count == 0)
    Console.WriteLine("Такого числа нет в данном массиве.");
