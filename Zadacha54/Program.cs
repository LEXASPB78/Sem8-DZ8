/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

{


    static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("Задача 54. Сортировка массива по строкам");
        Console.WriteLine("***********************************************");
        int[,] arr = clsBasic2DimArrFunc.Init2DimIntArray(numRows: 0,
                                                           numCols: 0
                                                           );
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int[] arrRow = clsBasic2DimArrFunc.GetRowAsArray(arr, i);
            //Console.Write($"Строка {i}: ");
            //clsBasic1DimArrFunc.PrintArray(arrRow);
            //Console.WriteLine();
            clsBasic1DimArrFunc.Sort1DimArray(arrRow, 1);
            //Console.Write($"Строка {i} отсортированная: ");
            //clsBasic1DimArrFunc.PrintArray(arrRow);
            //Console.WriteLine();
            clsBasic2DimArrFunc.SetArrayAsRow(arr, i, arrRow);
        }
        Console.WriteLine("***********************************************");
        Console.WriteLine("Отсортированный по строкам массив");
        clsBasic2DimArrFunc.Print2DimArray(arr);
    }
}
