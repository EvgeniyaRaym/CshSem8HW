// SЗадача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();

Write("Давайте содадим прямоугольный массив. Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
while (rows == columns) 
{
    Write("Массив не является прямоугольным. ");
    Write("Введите количество строк массива: ");
    rows = int.Parse(ReadLine());
    Write("Введите количество столбцов массива: ");
    columns = int.Parse(ReadLine());
}


int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

WriteLine($"Наименьшая сумма элементов в строке под номером {MinSumLine(array)+1}");

int MinSumLine (int [,] array)
{
    int line  = 0;
    int minsum = 0;
    for (int i = 0; i<array.GetLength(1); i++)
    {
        minsum = minsum + array[0,i];
    }
    for (int i = 1; i<array.GetLength(0); i++)
    {
        int sum = 0; 
        for (int j = 0; j<array.GetLength(1); j++)
        {
            sum = sum+array[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            line = i;
        }
    }
    return line;
}
    

         
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
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
