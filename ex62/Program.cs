// 62. Напишите программу, которая спирально заполнит массив 4*4.

int n = 4; // программа будет работать для любого квадратного массива
int[,] sqMatrix = new int[n, n];
int startNum = 1, i = 0, j = 0;
sqMatrix = FillArray(sqMatrix);
PrintArray(sqMatrix);


int[,] FillArray(int[,] array)
{
    while (startNum <= n * n)
    {
        sqMatrix[i, j] = startNum;
        startNum++;
        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= n - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
