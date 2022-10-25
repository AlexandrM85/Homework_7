// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("--------------Задача №47.--------------");
Console.WriteLine("Введите колличество строк: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите колличество столбцов: ");
int columns1 = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows1, columns1, -100, 100);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) / 10;
        }
    }
    return result;
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("--------------Задача №50.--------------");
int rows = 3;
int columns = 4;
int[,] arr = GetArray2(rows, columns, 0, 10);
PrintArray2(arr);

int[,] GetArray2(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray2(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("i = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("j = ");
int b = int.Parse(Console.ReadLine()!);

if (a >= columns || b >= rows)
{
    Console.WriteLine("Такого числа в массиве нет.");
}
else
{
    rows = a; columns = b;
    int c = arr[b,a];
    Console.WriteLine(c);
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("--------------Задача №52.--------------");
int m = 3;
int n = 4;
int[,] matrix = GetArray3(m, n, 0, 10);
double[] sum = new double[n];
PrintArray3(matrix);

int[,] GetArray3(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray3(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[i] += matrix[j,i];
    }
    Console.Write($"{(sum[i] / m):f1}  |  ");
}