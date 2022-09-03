/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void MultiplicationMatrix(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array3[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    array3[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        PrintMatrix(array3);
    }
    else Console.WriteLine("Умножение 2-х данных матриц не возможно");
}

// int[,] array1 = new int[,]
// {
//     {3, 2, 1},
//     {0, 1, 2}
// };
// int[,] array2 = new int[,]
// {
//     {1},
//     {2},
//     {3}
// };

Console.Write("Веедите колличество строк в матрице 1: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите колличество столбцов в матрице 1: ");
int column1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = CreateMatrix(row1, column1);

Console.Write("Веедите колличество строк в матрице 2: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Веедите колличество столбцов в матрице 2: ");
int column2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = CreateMatrix(row2, column2);

PrintMatrix(array1);
Console.WriteLine();
PrintMatrix(array2);
Console.WriteLine();
MultiplicationMatrix(array1, array2);
