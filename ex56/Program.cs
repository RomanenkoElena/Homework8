// 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int row = new Random().Next(2, 5);
int column = new Random().Next(2, 5);
Console.WriteLine($"Исходный массив {row}*{column}");

int[,] matrix = new int[row, column];
matrix = FillArray(matrix);
PrintArray(matrix);
MinSumRowElem(matrix);

int[,] FillArray(int[,] matrix) // м-д заполнения массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix) // м-д печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumRowElem(int[,] matrix) // м-д нахождения строки с мин.суммой элем-тов
{
    int minsum = 0;
    int row = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minsum = minsum + matrix[0, i];
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix [i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            row = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов - {minsum}, в строке {row}");
}