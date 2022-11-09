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
MultiMatrix(resultMatrix);
Console.WriteLine("Произведение двух матриц:");
PrintArray(resultMatrix);

void MultiMatrix(int[,] matrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
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

