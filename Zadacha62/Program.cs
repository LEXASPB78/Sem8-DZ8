/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void Spiral(int[,] matrix)
{
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int visits = m;
    // Console.WriteLine(matrix.Length);
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        // Console.WriteLine($"{matrix[row, col]}, ({row},{col})");
        // Console.WriteLine($"visits ={visits}");
        visits -= 1;
        if (visits == 0)
        {
            // Console.WriteLine($"m * (dirChanges %2) ={m * (dirChanges %2)}");
            visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            // Console.WriteLine($"visits2 ={visits}");
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
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

int n = 5;
int m = 4;
int[,] matrix = new int[n, m];

Spiral(matrix);
PrintMatrix(matrix);
