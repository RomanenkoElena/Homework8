// 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] firstMatrix = new int[2, 2]; // иниц-ция исходных матриц
int[,] secondMatrix = new int[2, 2];
firstMatrix = FillArray(firstMatrix); // заполнение исходных матриц
secondMatrix = FillArray(secondMatrix);
Console.WriteLine("Первая матрица:"); // печать исходных матриц
PrintArray(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[2, 2]; // иниц-ция матрицы с решением
resultMatrix = MultiMatrix(resultMatrix, firstMatrix, secondMatrix);
Console.WriteLine("Произведение двух матриц:");
PrintArray(resultMatrix);

int [,] MultiMatrix(int[,] matrix, int[,] first, int[,] second)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
                sum += first[i, k] * second[k, j];
            }
            matrix[i, j] = sum;
        }
    }
    return matrix;
}

int[,] FillArray(int[,] matrix) // м-д заполнения массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
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

