// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


using System;
using static System.Console;

Clear();

Write("Для спирального заполнения нам нужна квадратная матрица. Введите количество строк и столбцов: ");
int n = int.Parse(ReadLine());
PrintArray(SpiralArray(n));

int [,] SpiralArray (int n)
{
    int[,] array = new int[n, n];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= n * n)
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < n - 1) j++;
        else 
            { 
                if (i < j && i + j >= n - 1) i++;
                else 
                    {
                        if (i >= j && i + j > n - 1) j--;
                        else i--;
                    }
            }
    }  
    return array;
}
    




void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}