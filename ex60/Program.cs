// 60. Сформируйте трехмерный массив из двузначных чисел. 
//     Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] array3D = new int[2, 2, 2];
array3D = FillArray3D(array3D);
PrintArray3D(array3D);


int[,,] FillArray3D(int[,,] array) // м-д наполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = new Random().Next(10, 99);
            }
        }
    }
    return array;
}


void PrintArray3D(int[,,] array) // м-д вывода на экран построчно
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++, Console.WriteLine(""))
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[i, j, z]} ({i},{j},{z}) \t");
            }
        }
    }
}

