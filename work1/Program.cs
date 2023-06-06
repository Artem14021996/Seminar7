// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.Write("Введите количество строк двумерного массива: ");
int linesVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Ввведите количество столбцов двумерного массива: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// 2 вариант

Console.Write("Задайте количество строк двумерного массива m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Задайте количество столбцов двумерного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

double[,] Array = new double[m, n];
Random myRandom = new Random();


{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Array[i, j] = myRandom.Next(-100, 100);
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}