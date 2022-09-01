/*
Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
*/

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
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min_position = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min_position])
            {
                min_position = j;
            }
        }
        // int temp = array[min_position];
        // array[min_position] = array[i];
        // array[i] = temp;
        int temp = array[i];
        array[i] = array[min_position];
        array[min_position] = temp;
    }
}

int[] Convert2Demetion2One(int[,] array2)
{
    int[] array1 = new int[array2.GetLength(0) * array2.GetLength(1)];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array1[i * array2.GetLength(1) + j] = array2[i, j];
        }
    }
    return array1;
}

void FrequencyNumber(int[] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1]) count++;
        else if (arr[i] != arr[i + 1])
        {
            Console.WriteLine($"Количество {arr[i]} = {count}");
            count = 1;
        }
        //   Console.WriteLine($"Количество {arr[i]} = {count}");
        if (arr[i] == arr[i + 1] && i + 1 == arr.Length - 1)
        {
            Console.WriteLine($"Количество {arr[i]} = {count}");
        }
    }
}

int[,] array2 = new int[3, 4]
{
    {22,3,4,22},
    {5,4,22,3},
    {4,8,3,5}
};
// PrintArray(array);
// Console.WriteLine();
PrintMatrix(array2);
Console.WriteLine();
int[] array1 = Convert2Demetion2One(array2);
PrintArray(array1);
SortArray(array1);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
FrequencyNumber(array1);
